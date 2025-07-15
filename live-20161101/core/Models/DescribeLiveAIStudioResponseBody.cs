// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveAIStudioResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Valid values: 1 to 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The virtual studio templates.</para>
        /// </summary>
        [NameInMap("StudioConfigs")]
        [Validation(Required=false)]
        public DescribeLiveAIStudioResponseBodyStudioConfigs StudioConfigs { get; set; }
        public class DescribeLiveAIStudioResponseBodyStudioConfigs : TeaModel {
            [NameInMap("SubtitleConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveAIStudioResponseBodyStudioConfigsSubtitleConfig> SubtitleConfig { get; set; }
            public class DescribeLiveAIStudioResponseBodyStudioConfigsSubtitleConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the background material.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d0eb493192c771efba644531858c0102</para>
                /// </summary>
                [NameInMap("BackgroundResourceId")]
                [Validation(Required=false)]
                public string BackgroundResourceId { get; set; }

                /// <summary>
                /// <para>The URL of the background material. Make sure that the URL is accessible over the Internet. Either this parameter or the BackgroundResourceId parameter is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://testbucket.xx.com/2.jpg">https://testbucket.xx.com/2.jpg</a></para>
                /// </summary>
                [NameInMap("BackgroundResourceUrl")]
                [Validation(Required=false)]
                public string BackgroundResourceUrl { get; set; }

                /// <summary>
                /// <para>The type of the background material. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>VOD: a video in ApsaraVideo VOD</description></item>
                /// <item><description>PIC: an image</description></item>
                /// <item><description>LIVE: a live stream</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VOD</para>
                /// </summary>
                [NameInMap("BackgroundType")]
                [Validation(Required=false)]
                public string BackgroundType { get; set; }

                /// <summary>
                /// <para>The custom description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user defined description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The preview height. Unit: pixels.</para>
                /// <para>The following preview specifications (width × height) are supported:</para>
                /// <list type="bullet">
                /// <item><description>Landscape low definition 360p (640×360)</description></item>
                /// <item><description>Portrait low definition 360p (360×640)</description></item>
                /// <item><description>Landscape standard definition 480p (854×480)</description></item>
                /// <item><description>Portrait standard definition 480p (480×854)</description></item>
                /// <item><description>Landscape high definition 720p (1280×720)</description></item>
                /// <item><description>Portrait high definition 720p (720×1280)</description></item>
                /// <item><description>Landscape ultra-high definition 1080p (1920×1080)</description></item>
                /// <item><description>Portrait ultra-high definition 1080p (1080×1920)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1080</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// <para>The layout information of the multimedia material.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;{\&quot;positionY\&quot;:\&quot;0.0\&quot;,\&quot;positionX\&quot;:\&quot;0.0\&quot;,\&quot;heightNormalized\&quot;:\&quot;0.5\&quot;}&quot;</para>
                /// </summary>
                [NameInMap("MattingLayout")]
                [Validation(Required=false)]
                public string MattingLayout { get; set; }

                /// <summary>
                /// <para>The type of chroma key that is performed on ingested streams. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>green: green-key chroma key</description></item>
                /// <item><description>blue: blue-screen chroma key</description></item>
                /// <item><description>complex: background replacement</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>complex</para>
                /// </summary>
                [NameInMap("MattingType")]
                [Validation(Required=false)]
                public string MattingType { get; set; }

                /// <summary>
                /// <para>LIVE, live streaming</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;{\&quot;positionY\&quot;:\&quot;0.0\&quot;,\&quot;positionX\&quot;:\&quot;0.0\&quot;,\&quot;heightNormalized\&quot;:\&quot;0.5\&quot;}&quot;</para>
                /// </summary>
                [NameInMap("MediaLayout")]
                [Validation(Required=false)]
                public string MediaLayout { get; set; }

                /// <summary>
                /// <para>The ID of the multimedia material in ApsaraVideo VOD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d0eb493192c771efba644531858c0102</para>
                /// </summary>
                [NameInMap("MediaResourceId")]
                [Validation(Required=false)]
                public string MediaResourceId { get; set; }

                /// <summary>
                /// <para>The URL of the multimedia material.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://testbucket.xx.com/2.jpg">https://testbucket.xx.com/2.jpg</a></para>
                /// </summary>
                [NameInMap("MediaResourceUrl")]
                [Validation(Required=false)]
                public string MediaResourceUrl { get; set; }

                /// <summary>
                /// <para>The type of the multimedia material. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>VOD: a video in ApsaraVideo VOD</description></item>
                /// <item><description>PIC: an image</description></item>
                /// <item><description>LIVE: a live stream</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VOD</para>
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                /// <summary>
                /// <para>The IDs of the bound rules.</para>
                /// </summary>
                [NameInMap("RuleIds")]
                [Validation(Required=false)]
                public DescribeLiveAIStudioResponseBodyStudioConfigsSubtitleConfigRuleIds RuleIds { get; set; }
                public class DescribeLiveAIStudioResponseBodyStudioConfigsSubtitleConfigRuleIds : TeaModel {
                    [NameInMap("ruleId")]
                    [Validation(Required=false)]
                    public List<string> RuleId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the virtual studio template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24654384-f5ac-40ea-823b-74e85a61dd9f</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                /// <summary>
                /// <para>The name of the virtual studio template. The name is the same as the value of the StudioName parameter that was specified when you called the CreateLiveAiStudio operation to create the virtual studio template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>studio1</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <para>The preview width.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1920</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
