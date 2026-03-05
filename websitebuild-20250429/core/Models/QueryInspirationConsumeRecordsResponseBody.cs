// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class QueryInspirationConsumeRecordsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ish-intelligence-store-platform-admin-web</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        [NameInMap("Module")]
        [Validation(Required=false)]
        public QueryInspirationConsumeRecordsResponseBodyModule Module { get; set; }
        public class QueryInspirationConsumeRecordsResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPageNum")]
            [Validation(Required=false)]
            public int? CurrentPageNum { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryInspirationConsumeRecordsResponseBodyModuleData> Data { get; set; }
            public class QueryInspirationConsumeRecordsResponseBodyModuleData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public long? Amount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-06-01 12:00:00</para>
                /// </summary>
                [NameInMap("ConsumeTime")]
                [Validation(Required=false)]
                public string ConsumeTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;MD5\&quot;:\&quot;296f6c01e7fea2697ffe1cf41082b774\&quot;,\&quot;driver\&quot;:\&quot;vhd\&quot;,\&quot;flag\&quot;:\&quot;12845825\&quot;,\&quot;imds_support\&quot;:\&quot;v1\&quot;,\&quot;io_optimized\&quot;:true,\&quot;nvme_supported\&quot;:true,\&quot;uefi_preferred\&quot;:false}</para>
                /// </summary>
                [NameInMap("MetaData")]
                [Validation(Required=false)]
                public string MetaData { get; set; }

                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

            }

            [NameInMap("Next")]
            [Validation(Required=false)]
            public QueryInspirationConsumeRecordsResponseBodyModuleNext Next { get; set; }
            public class QueryInspirationConsumeRecordsResponseBodyModuleNext : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public long? Amount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-06-01 12:00:00</para>
                /// </summary>
                [NameInMap("ConsumeTime")]
                [Validation(Required=false)]
                public string ConsumeTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;MD5\&quot;:\&quot;1042e65a2b7cdd3059b6a873ee1a3260\&quot;,\&quot;driver\&quot;:\&quot;vhd\&quot;,\&quot;flag\&quot;:\&quot;12845825\&quot;,\&quot;imds_support\&quot;:\&quot;v1\&quot;,\&quot;io_optimized\&quot;:true,\&quot;nvme_supported\&quot;:true,\&quot;uefi_preferred\&quot;:false}</para>
                /// </summary>
                [NameInMap("MetaData")]
                [Validation(Required=false)]
                public string MetaData { get; set; }

                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("NextPage")]
            [Validation(Required=false)]
            public bool? NextPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("PrePage")]
            [Validation(Required=false)]
            public bool? PrePage { get; set; }

            [NameInMap("ResultLimit")]
            [Validation(Required=false)]
            public bool? ResultLimit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalItemNum")]
            [Validation(Required=false)]
            public int? TotalItemNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPageNum")]
            [Validation(Required=false)]
            public int? TotalPageNum { get; set; }

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
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
