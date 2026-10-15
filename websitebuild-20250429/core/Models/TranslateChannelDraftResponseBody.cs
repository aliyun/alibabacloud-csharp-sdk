// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class TranslateChannelDraftResponseBody : TeaModel {
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
        /// <para>Indicates whether retry is allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>The application name used to query the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ish-intelligence-store-platform-admin-web</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The dynamic code. This parameter is not in use. Ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message that is used to replace the <c>%s</c> variable in the <b>ErrMessage</b> return parameter.</para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, the value of the request parameter <b>DtsJobId</b> is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error parameters.</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>Indicates whether the deletion was successful.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public TranslateChannelDraftResponseBodyModule Module { get; set; }
        public class TranslateChannelDraftResponseBodyModule : TeaModel {
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
            /// <para>The publishing account snapshot.</para>
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
            /// <para>channel_905</para>
            /// </summary>
            [NameInMap("ChannelName")]
            [Validation(Required=false)]
            public string ChannelName { get; set; }

            /// <summary>
            /// <para>The channel type. Valid values: DOMESTIC, OVERSEA, and INTERNAL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wechat</para>
            /// </summary>
            [NameInMap("ChannelType")]
            [Validation(Required=false)]
            public string ChannelType { get; set; }

            /// <summary>
            /// <para>The list of channel cover images.</para>
            /// </summary>
            [NameInMap("CoverImages")]
            [Validation(Required=false)]
            public List<TranslateChannelDraftResponseBodyModuleCoverImages> CoverImages { get; set; }
            public class TranslateChannelDraftResponseBodyModuleCoverImages : TeaModel {
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
                /// <para>oss://anchashiscan.oss-cn-hangzhou.aliyuncs.com/prodpopscanBnlK054f</para>
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
            /// <para>The ID of the channel draft.</para>
            /// 
            /// <b>Example:</b>
            /// <para>85e219ef-c458-4a0d-a249-2776864143bb</para>
            /// </summary>
            [NameInMap("DraftId")]
            [Validation(Required=false)]
            public string DraftId { get; set; }

            /// <summary>
            /// <para>The ID returned by the platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a367d19c02ff004ac20a7b2078066fe1f370</para>
            /// </summary>
            [NameInMap("ExternalId")]
            [Validation(Required=false)]
            public string ExternalId { get; set; }

            /// <summary>
            /// <para>The redirect URL of the platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://net-video.mistong.com:10160/api/preview/video/2026/02/02/7181627703f6437480a7bffe8ed1e7b0_20260202100338.mp4">https://net-video.mistong.com:10160/api/preview/video/2026/02/02/7181627703f6437480a7bffe8ed1e7b0_20260202100338.mp4</a></para>
            /// </summary>
            [NameInMap("ExternalUrl")]
            [Validation(Required=false)]
            public string ExternalUrl { get; set; }

            /// <summary>
            /// <para>The reason for the failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Invalid parameter</para>
            /// </summary>
            [NameInMap("FailReason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

            /// <summary>
            /// <para>The channel-specific publishing configuration in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("PublishConfig")]
            [Validation(Required=false)]
            public string PublishConfig { get; set; }

            /// <summary>
            /// <para>The publishing time, in millisecond timestamp format.</para>
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
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
        /// <para>The exception message.</para>
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
