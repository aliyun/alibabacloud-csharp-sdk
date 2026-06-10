// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAppConversationsResponseBody : TeaModel {
        /// <summary>
        /// <para>Detailed reason for access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Indicates whether retry is allowed</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>Application name. Queries the application with this name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dewuApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>Faulty parameters.</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>Number of results per query.  </para>
        /// <para>Value range: 10 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Response data</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public ListAppConversationsResponseBodyModule Module { get; set; }
        public class ListAppConversationsResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>Request result.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListAppConversationsResponseBodyModuleData> Data { get; set; }
            public class ListAppConversationsResponseBodyModuleData : TeaModel {
                /// <summary>
                /// <para>aliyun_pk</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("AliyunPk")]
                [Validation(Required=false)]
                public string AliyunPk { get; set; }

                /// <summary>
                /// <para>Bot ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zero2</para>
                /// </summary>
                [NameInMap("BotId")]
                [Validation(Required=false)]
                public string BotId { get; set; }

                /// <summary>
                /// <para>Chat records</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ChatNum")]
                [Validation(Required=false)]
                public int? ChatNum { get; set; }

                /// <summary>
                /// <para>Session ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>799EAC1246C855CAC75B77955E43D841</para>
                /// </summary>
                [NameInMap("ConversationId")]
                [Validation(Required=false)]
                public string ConversationId { get; set; }

                /// <summary>
                /// <para>Creation Time</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-27T17:51:25.415+08:00</para>
                /// </summary>
                [NameInMap("GmtCreateTime")]
                [Validation(Required=false)]
                public string GmtCreateTime { get; set; }

                /// <summary>
                /// <para>Update Time.</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-10-02T02:21:07Z</para>
                /// </summary>
                [NameInMap("GmtModifiedTime")]
                [Validation(Required=false)]
                public string GmtModifiedTime { get; set; }

                /// <summary>
                /// <para>Extension information (in JSON string format)</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;MD5\&quot;:\&quot;296f6c01e7fea2697ffe1cf41082b774\&quot;,\&quot;driver\&quot;:\&quot;vhd\&quot;,\&quot;flag\&quot;:\&quot;12845825\&quot;,\&quot;imds_support\&quot;:\&quot;v1\&quot;,\&quot;io_optimized\&quot;:true,\&quot;nvme_supported\&quot;:true,\&quot;uefi_preferred\&quot;:false}</para>
                /// </summary>
                [NameInMap("MetaData")]
                [Validation(Required=false)]
                public string MetaData { get; set; }

                /// <summary>
                /// <para>Section ID of the checklist item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("SectionId")]
                [Validation(Required=false)]
                public string SectionId { get; set; }

                /// <summary>
                /// <para>Site ID. You can obtain it by invoking the <a href="~~ListSites~~">ListSites</a> API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1068725896006128</para>
                /// </summary>
                [NameInMap("SiteId")]
                [Validation(Required=false)]
                public string SiteId { get; set; }

                /// <summary>
                /// <para>Current viewpoint, equivalent to the news title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sometimes When We Touch</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>User ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>Page number. The default value is 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>Paging size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Resource count that matches the filter condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Token indicating the start of the next query. This field is empty if there is no next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAARbaCuN6hiD08qrLdwJ9Fh3BFw8paIJ7ylB6A7Qn9JjM</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>Abnormal message</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统异常</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
