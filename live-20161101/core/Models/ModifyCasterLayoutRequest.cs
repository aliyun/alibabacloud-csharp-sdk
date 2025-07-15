// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyCasterLayoutRequest : TeaModel {
        /// <summary>
        /// <para>The audio layers.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AudioLayer")]
        [Validation(Required=false)]
        public List<ModifyCasterLayoutRequestAudioLayer> AudioLayer { get; set; }
        public class ModifyCasterLayoutRequestAudioLayer : TeaModel {
            /// <summary>
            /// <para>The fixed delay of the audio layer. This parameter is used to synchronize the audio with subtitles. Unit: milliseconds. Default value: <b>0</b>. Valid values: <b>0 to 5000</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("FixedDelayDuration")]
            [Validation(Required=false)]
            public int? FixedDelayDuration { get; set; }

            /// <summary>
            /// <para>The sound channels that are used for volume input in the audio layer. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>leftChannel</b>: the left channel</description></item>
            /// <item><description><b>rightChannel</b>: the right channel</description></item>
            /// <item><description><b>all</b> (default): both the left and right channels</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("ValidChannel")]
            [Validation(Required=false)]
            public string ValidChannel { get; set; }

            /// <summary>
            /// <para>The normalized value of the height of the audio layer. The width of the audio layer is proportionally scaled based on this parameter.</para>
            /// <para>The default value is <b>0</b>, which indicates that the audio layer is not scaled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VolumeRate")]
            [Validation(Required=false)]
            public float? VolumeRate { get; set; }

        }

        /// <summary>
        /// <para>The location IDs of the video layers, which are in the same order as the video layers.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/2848020.html">AddCasterVideoResource</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RV02</para>
        /// </summary>
        [NameInMap("BlendList")]
        [Validation(Required=false)]
        public List<string> BlendList { get; set; }

        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <list type="bullet">
        /// <item><description>If the production studio was created by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, check the value of the response parameter CasterId to obtain the ID.</description></item>
        /// <item><description>If the production studio was created by using the ApsaraVideo Live console, obtain the ID on the <b>Production Studio Management</b> page. To go to the page, log on to the <b>ApsaraVideo Live console</b> and click <b>Production Studios</b> in the left-side navigation pane.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can find the ID of the production studio in the Instance ID/Name column.</para>
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
        /// <para>The ID of the layout. If the layout was added by calling the <a href="https://help.aliyun.com/document_detail/2848025.html">AddCasterLayout</a> operation, check the value of the response parameter LayoutId to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21926b36-7dd2-4fde-ae25-51b5bc8e****</para>
        /// </summary>
        [NameInMap("LayoutId")]
        [Validation(Required=false)]
        public string LayoutId { get; set; }

        /// <summary>
        /// <para>The location IDs of the audio layers, which are in the same order as the audio layers.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/2848020.html">AddCasterVideoResource</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RV02</para>
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
        /// <para>The video layers.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VideoLayer")]
        [Validation(Required=false)]
        public List<ModifyCasterLayoutRequestVideoLayer> VideoLayer { get; set; }
        public class ModifyCasterLayoutRequestVideoLayer : TeaModel {
            /// <summary>
            /// <para>The scaling mode of the video layer. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>none</b> (default): indicates that the video layer is not scaled. The video layer is displayed based on its original size.</description></item>
            /// <item><description><b>fit</b>: indicates that the video layer is adapted to the fill area. In this case, the video layer is scaled proportionally, with its original aspect ratio retained. The video layer is placed in the center, with its longer sides aligned with the fill area. If the aspect ratio of the video layer is different from that of the fill area, the content of the lower layer is displayed alongside the shorter sides. If there is no lower layer, black bars are displayed instead.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fit</para>
            /// </summary>
            [NameInMap("FillMode")]
            [Validation(Required=false)]
            public string FillMode { get; set; }

            /// <summary>
            /// <para>The fixed delay of the video layer. This parameter is used to synchronize the video with subtitles. Unit: milliseconds. Default value: <b>0</b>. Valid values: <b>0 to 5000</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("FixedDelayDuration")]
            [Validation(Required=false)]
            public int? FixedDelayDuration { get; set; }

            /// <summary>
            /// <para>The normalized value of the height of the video layer.</para>
            /// <list type="bullet">
            /// <item><description>If the FillMode parameter of the video layer is set to none, the width of the video layer is proportionally scaled based on this parameter. The default value is <b>0</b>, which indicates that the video layer is not scaled.</description></item>
            /// <item><description>If the FillMode parameter of the video layer is set to fit, the value of this parameter is greater than <b>0</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HeightNormalized")]
            [Validation(Required=false)]
            public float? HeightNormalized { get; set; }

            /// <summary>
            /// <para>The normalized value of the position of the video layer, in the format of <c>[x,y]</c>. Default value: <c>[0,0]</c>.</para>
            /// <remarks>
            /// <para> The values of x and y are normalized.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("PositionNormalized")]
            [Validation(Required=false)]
            public List<float?> PositionNormalized { get; set; }

            /// <summary>
            /// <para>The reference coordinates of the video layer. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>topLeft</b> (default): the upper-left corner</description></item>
            /// <item><description><b>topRight</b>: the upper-right corner</description></item>
            /// <item><description><b>bottomLeft</b>: the lower-left corner</description></item>
            /// <item><description><b>bottomRight</b>: the lower-right corner</description></item>
            /// <item><description><b>center</b>: the center</description></item>
            /// <item><description><b>topCenter</b>: the upper center</description></item>
            /// <item><description><b>bottomCenter</b>: the lower center</description></item>
            /// <item><description><b>leftCenter</b>: the left center</description></item>
            /// <item><description><b>rightCenter</b>: the right center</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>topLeft</para>
            /// </summary>
            [NameInMap("PositionRefer")]
            [Validation(Required=false)]
            public string PositionRefer { get; set; }

            /// <summary>
            /// <para>The normalized value of the width of the video layer.</para>
            /// <list type="bullet">
            /// <item><description>If the FillMode parameter of the video layer is set to none, the height of the video layer is proportionally scaled based on this parameter. The default value is <b>0</b>, which indicates that the video layer is not scaled.</description></item>
            /// <item><description>If the FillMode parameter of the video layer is set to fit, the value of this parameter is greater than <b>0</b>.</description></item>
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
