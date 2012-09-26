/*
 * Copyright (c) 2012 Adobe Systems Incorporated. All rights reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

precision mediump float;

varying vec2 v_texCoord;

varying float pointLightIntensity;

uniform vec3 pointLightColor;
uniform vec3 ambientLightColor;

void main()
{
	float frontFacing = gl_FrontFacing ? 1.0 : -1.0;
	float facePointLightIntensity = max(frontFacing * pointLightIntensity, 0.0);
	vec3 color = min(ambientLightColor + facePointLightIntensity * pointLightColor, 1.0);

	css_MixColor = vec4(color, 1.0);
}
