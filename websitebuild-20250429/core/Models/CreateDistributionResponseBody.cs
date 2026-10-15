// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateDistributionResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason why access was denied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Indicates whether retry is allowed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: Retry is not allowed.</description></item>
        /// <item><description>true: Retry is allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>watermark</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The returned error parameters.</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public CreateDistributionResponseBodyModule Module { get; set; }
        public class CreateDistributionResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The article ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>28733</para>
            /// </summary>
            [NameInMap("ArticleId")]
            [Validation(Required=false)]
            public string ArticleId { get; set; }

            /// <summary>
            /// <para>The distribution batch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pcb-uf6dkhq311uxuwo2</para>
            /// </summary>
            [NameInMap("BatchId")]
            [Validation(Required=false)]
            public string BatchId { get; set; }

            /// <summary>
            /// <para>The creation time, in millisecond timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-03 02:05:01</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The list of channel drafts within the batch.</para>
            /// </summary>
            [NameInMap("Drafts")]
            [Validation(Required=false)]
            public List<CreateDistributionResponseBodyModuleDrafts> Drafts { get; set; }
            public class CreateDistributionResponseBodyModuleDrafts : TeaModel {
                /// <summary>
                /// <para>The AI adaptation status. Valid values: NONE, ADAPTING, DONE, and FAILED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("AdaptStatus")]
                [Validation(Required=false)]
                public string AdaptStatus { get; set; }

                /// <summary>
                /// <para>The channel-adapted content body.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("AdaptedContent")]
                [Validation(Required=false)]
                public string AdaptedContent { get; set; }

                /// <summary>
                /// <para>The channel-adapted title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("AdaptedTitle")]
                [Validation(Required=false)]
                public string AdaptedTitle { get; set; }

                /// <summary>
                /// <para>The channel enumeration value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WECHAT</para>
                /// </summary>
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>The publishing account snapshot. For overseas channels, this is the OWLAIS socialAccountNo.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("ChannelAccount")]
                [Validation(Required=false)]
                public string ChannelAccount { get; set; }

                /// <summary>
                /// <para>The display name of the publishing account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("ChannelAccountName")]
                [Validation(Required=false)]
                public string ChannelAccountName { get; set; }

                /// <summary>
                /// <para>The display name of the channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ch3</para>
                /// </summary>
                [NameInMap("ChannelName")]
                [Validation(Required=false)]
                public string ChannelName { get; set; }

                /// <summary>
                /// <para>The channel type. Valid values: DOMESTIC, OVERSEA, and INTERNAL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ChannelType")]
                [Validation(Required=false)]
                public string ChannelType { get; set; }

                /// <summary>
                /// <para>The list of channel cover images.</para>
                /// </summary>
                [NameInMap("CoverImages")]
                [Validation(Required=false)]
                public List<CreateDistributionResponseBodyModuleDraftsCoverImages> CoverImages { get; set; }
                public class CreateDistributionResponseBodyModuleDraftsCoverImages : TeaModel {
                    /// <summary>
                    /// <para>The file ID in the material center.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("MaterialFileId")]
                    [Validation(Required=false)]
                    public string MaterialFileId { get; set; }

                    /// <summary>
                    /// <para>The CDN URL of the image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://another-bucket.oss-cn-hangzhou.aliyuncs.com/path/to/file3%5C%5C%22%5C%5C%22%60curl">http://another-bucket.oss-cn-hangzhou.aliyuncs.com/path/to/file3\\&quot;\\&quot;`curl</a> YFLd1vS4.popscan.xaliyun.com`\&quot;\&quot;</para>
                    /// </summary>
                    [NameInMap("OssUrl")]
                    [Validation(Required=false)]
                    public string OssUrl { get; set; }

                    /// <summary>
                    /// <para>The sort order number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Desc</para>
                    /// </summary>
                    [NameInMap("SortOrder")]
                    [Validation(Required=false)]
                    public int? SortOrder { get; set; }

                }

                /// <summary>
                /// <para>The channel draft ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>draft-789</para>
                /// </summary>
                [NameInMap("DraftId")]
                [Validation(Required=false)]
                public string DraftId { get; set; }

                /// <summary>
                /// <para>The ID returned by the platform.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1378080</para>
                /// </summary>
                [NameInMap("ExternalId")]
                [Validation(Required=false)]
                public string ExternalId { get; set; }

                /// <summary>
                /// <para>The redirect URL of the platform.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://net-video.mistong.com:10160/api/preview/video/2026/04/15/67603b7c84694e619435e4662e98cb23_20260415095633.mp4">https://net-video.mistong.com:10160/api/preview/video/2026/04/15/67603b7c84694e619435e4662e98cb23_20260415095633.mp4</a></para>
                /// </summary>
                [NameInMap("ExternalUrl")]
                [Validation(Required=false)]
                public string ExternalUrl { get; set; }

                /// <summary>
                /// <para>The failure reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("FailReason")]
                [Validation(Required=false)]
                public string FailReason { get; set; }

                /// <summary>
                /// <para>The channel-specific publish configuration in JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("PublishConfig")]
                [Validation(Required=false)]
                public string PublishConfig { get; set; }

                /// <summary>
                /// <para>The publish time, in millisecond timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("PublishedAt")]
                [Validation(Required=false)]
                public long? PublishedAt { get; set; }

                /// <summary>
                /// <para>The status. Valid values: EDITING, PUBLISHING, SUCCESS, and FAILED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>System exception</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is processed synchronously.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
