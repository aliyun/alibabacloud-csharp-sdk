// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterLayoutRequest : TeaModel {
        /// <summary>
        /// <para>Audio layout.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AudioLayer")]
        [Validation(Required=false)]
        public List<AddCasterLayoutRequestAudioLayer> AudioLayer { get; set; }
        public class AddCasterLayoutRequestAudioLayer : TeaModel {
            /// <summary>
            /// <para>The fixed delay of audio layer N. You can use this parameter to synchronize the audio with subtitles. Unit: milliseconds. Valid values: <b>0 to 5000</b>. Default value: <b>0</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("FixedDelayDuration")]
            [Validation(Required=false)]
            public int? FixedDelayDuration { get; set; }

            /// <summary>
            /// <para>The valid voice channels of audio layer N. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>leftChannel</b>: the left channel.</description></item>
            /// <item><description><b>rightChannel</b>: the right channel.</description></item>
            /// <item><description><b>all</b>: both the left and right channels. This is the default value.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("ValidChannel")]
            [Validation(Required=false)]
            public string ValidChannel { get; set; }

            /// <summary>
            /// <para>The multiples of the original volume at which audio layer N plays audio streams. Valid values: <b>0 to 10.0</b>.</para>
            /// <list type="bullet">
            /// <item><description>The default value <b>1.0</b> indicates that audio layer N plays audio streams at the original volume.</description></item>
            /// <item><description>A value smaller than <b>1.0</b> indicates that audio layer N plays audio streams at a lower volume than the original one.</description></item>
            /// <item><description>A value greater than <b>1.0</b> indicates that audio layer N plays audio streams at a higher volume than the original one.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("VolumeRate")]
            [Validation(Required=false)]
            public float? VolumeRate { get; set; }

        }

        /// <summary>
        /// <para>The element represents the location ID of the video resource, i.e., LocationId. Refer to <a href="https://help.aliyun.com/document_detail/60250.html">Adding Video Source</a> for LocationId, which corresponds in order with the VideoLayers elements.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RV01</para>
        /// </summary>
        [NameInMap("BlendList")]
        [Validation(Required=false)]
        public List<string> BlendList { get; set; }

        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <para>If you create a production studio through the <a href="~~69338#doc-api-live-CreateCaster~~" title="Creates a production studio.">CreateCaster</a> interface, check the value of the CasterId parameter in the response.</para>
        /// <para>If you create a production studio through the ApsaraVideo Live Console, log in to the console, then check the ID of the production studio through the following path:</para>
        /// <para>Production Studios &gt; Production Studio Management</para>
        /// <remarks>
        /// <para> The CasterId is reflected in the Name column on the Production Studio Management page.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIVEPRODUCER_POST-cn-0pp1czt****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The element represents the location ID of the audio resource, i.e., LocationId.
        /// LocationId is referred to in <a href="https://help.aliyun.com/document_detail/60250.html">Adding Video Source</a>, and corresponds in order with the AudioLayers elements.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RV01</para>
        /// </summary>
        [NameInMap("MixList")]
        [Validation(Required=false)]
        public List<string> MixList { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Video layout.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VideoLayer")]
        [Validation(Required=false)]
        public List<AddCasterLayoutRequestVideoLayer> VideoLayer { get; set; }
        public class AddCasterLayoutRequestVideoLayer : TeaModel {
            /// <summary>
            /// <para>The scaling mode of video layer N. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>none</b>: The image is not scaled to fill in the specified layout section. Set video layer N based on the image size of the video resource. This is the default value.</description></item>
            /// <item><description><b>fit</b>: The image is scaled with the original aspect ratio to fill in the specified layout section. Set video layer N based on the section size. The image is centered in the layout section with the long side of the image equaling that of the section. If the aspect ratio of the image is inconsistent with that of the section, the short side of the image may be shorter than that of the section. The area outside the image displays the next video layer or the background if no next video layer exists. By default, the background color is black.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fit</para>
            /// </summary>
            [NameInMap("FillMode")]
            [Validation(Required=false)]
            public string FillMode { get; set; }

            /// <summary>
            /// <para>The fixed delay of video layer N. You can use this parameter to synchronize the video with subtitles. Unit: milliseconds. Valid values: <b>0 to 5000</b>. Default value: <b>0</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("FixedDelayDuration")]
            [Validation(Required=false)]
            public int? FixedDelayDuration { get; set; }

            /// <summary>
            /// <para>The normalized value of the height of the image of video layer N.</para>
            /// <list type="bullet">
            /// <item><description>If the FillMode parameter of video layer N is set to none, the width of the video image is scaled based on this parameter. The default value is <b>0</b>, which indicates that the video image is displayed in the original size.</description></item>
            /// <item><description>If the FillMode parameter of video layer N is set to fit, you must set this parameter to a value greater than <b>0</b>. In this case, the video image is scaled with the original aspect ratio to fill in the specified layout section based on this parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HeightNormalized")]
            [Validation(Required=false)]
            public float? HeightNormalized { get; set; }

            /// <summary>
            /// <para>The normalized value of the <c>[x,y]</c> coordinates of video layer N in the production studio. The default coordinates are <c>[0,0]</c>.</para>
            /// <remarks>
            /// <para> The coordinates indicate the location of video layer N in the production studio. Set this parameter to the normalized value of the coordinates.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("PositionNormalized")]
            [Validation(Required=false)]
            public List<float?> PositionNormalized { get; set; }

            /// <summary>
            /// <para>The reference coordinates of video layer N in the production studio. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>topLeft</b>: the upper-left corner. This is the default value.</description></item>
            /// <item><description><b>topRight</b>: the upper-right corner.</description></item>
            /// <item><description><b>bottomLeft</b>: the lower-left corner.</description></item>
            /// <item><description><b>bottomRight</b>: the lower-right corner.</description></item>
            /// <item><description><b>center</b>: the center position.</description></item>
            /// <item><description><b>topCenter</b>: the upper center position.</description></item>
            /// <item><description><b>bottomCenter</b>: the lower center position.</description></item>
            /// <item><description><b>leftCenter</b>: the left center position.</description></item>
            /// <item><description><b>rightCenter</b>: the right center position.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>topLeft</para>
            /// </summary>
            [NameInMap("PositionRefer")]
            [Validation(Required=false)]
            public string PositionRefer { get; set; }

            /// <summary>
            /// <para>The normalized value of the width of the image of video layer N.</para>
            /// <list type="bullet">
            /// <item><description>If the FillMode parameter of video layer N is set to none, the height of the video image is scaled based on this parameter. The default value is <b>0</b>, which indicates that the video image is displayed in the original size.</description></item>
            /// <item><description>If the FillMode parameter of video layer N is set to fit, you must set this parameter to a value greater than <b>0</b>. In this case, the video image is scaled with the original aspect ratio to fill in the specified layout section based on this parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WidthNormalized")]
            [Validation(Required=false)]
            public float? WidthNormalized { get; set; }

        }

    }

}
