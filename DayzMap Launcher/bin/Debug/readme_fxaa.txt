Details
=======
It is possible to use post-processing anti-aliasing, namely FXAA (Fast Approximate Anti-Aliasing).
Version used: 3.11

Default
=======
The FXAA is disabled by default (PPAA=0;)

Settings
========
In Arma3Alpha.cfg there is a config entry: PPAA=<number>;

Accepted values are:
 0 - Disabled
 1 - FXAA_QUALITY_PRESET_12
 2 - FXAA_QUALITY_PRESET_25
 3 - FXAA_QUALITY_PRESET_39

Complexity of quality settings are based on default FXAA settings (in revision 3.11)
 10 to 15 - default medium dither (10=fastest, 15=highest quality)
 20 to 29 - less dither, more expensive (20=fastest, 29=highest quality)
 39 - no dither, very expensive NOTE: FXAA can be enabled even if Post-Processing was disabled in video options!

Sources
=======
http://timothylottes.blogspot.com/2011/07/fxaa-311-released.html
http://timothylottes.blogspot.com/2011/03/nvidia-fxaa.html
http://developer.download.nvidia.com/assets/gamedev/files/sdk/11/FXAA_WhitePaper.pdf

Legal
=====
Special thanks to NVIDIA Corporation
NVIDIA FXAA 3.11 by TIMOTHY LOTTES
------------------------------------------------------------------------------
COPYRIGHT (C) 2010, 2011 NVIDIA CORPORATION. ALL RIGHTS RESERVED.
------------------------------------------------------------------------------
TO THE MAXIMUM EXTENT PERMITTED BY APPLICABLE LAW, THIS SOFTWARE IS PROVIDED
*AS IS* AND NVIDIA AND ITS SUPPLIERS DISCLAIM ALL WARRANTIES, EITHER EXPRESS
OR IMPLIED, INCLUDING, BUT NOT LIMITED TO, IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE. IN NO EVENT SHALL NVIDIA
OR ITS SUPPLIERS BE LIABLE FOR ANY SPECIAL, INCIDENTAL, INDIRECT, OR
CONSEQUENTIAL DAMAGES WHATSOEVER (INCLUDING, WITHOUT LIMITATION, DAMAGES FOR
LOSS OF BUSINESS PROFITS, BUSINESS INTERRUPTION, LOSS OF BUSINESS INFORMATION,
OR ANY OTHER PECUNIARY LOSS) ARISING OUT OF THE USE OF OR INABILITY TO USE
THIS SOFTWARE, EVEN IF NVIDIA HAS BEEN ADVISED OF THE POSSIBILITY OF SUCH
DAMAGES.