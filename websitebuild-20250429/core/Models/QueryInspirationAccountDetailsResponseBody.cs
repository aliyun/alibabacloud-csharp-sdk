// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class QueryInspirationAccountDetailsResponseBody : TeaModel {
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
        /// <para>or</para>
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
        public QueryInspirationAccountDetailsResponseBodyModule Module { get; set; }
        public class QueryInspirationAccountDetailsResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("CurrentPageNum")]
            [Validation(Required=false)]
            public int? CurrentPageNum { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryInspirationAccountDetailsResponseBodyModuleData> Data { get; set; }
            public class QueryInspirationAccountDetailsResponseBodyModuleData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-03-03 12:00:00</para>
                /// </summary>
                [NameInMap("AcquisitionTime")]
                [Validation(Required=false)]
                public string AcquisitionTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("Balance")]
                [Validation(Required=false)]
                public long? Balance { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-04-11 10:26:27 +0800</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>False</para>
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123123</para>
                /// </summary>
                [NameInMap("InitQuota")]
                [Validation(Required=false)]
                public long? InitQuota { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MARKET_CLOUD_DREAM</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FREE_TRIAL_GIFT</para>
                /// </summary>
                [NameInMap("SourceTypeName")]
                [Validation(Required=false)]
                public string SourceTypeName { get; set; }

            }

            [NameInMap("Next")]
            [Validation(Required=false)]
            public QueryInspirationAccountDetailsResponseBodyModuleNext Next { get; set; }
            public class QueryInspirationAccountDetailsResponseBodyModuleNext : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-03-03 12:00:00</para>
                /// </summary>
                [NameInMap("AcquisitionTime")]
                [Validation(Required=false)]
                public string AcquisitionTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("Balance")]
                [Validation(Required=false)]
                public long? Balance { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-02-25 10:11:25</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>False</para>
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123123</para>
                /// </summary>
                [NameInMap("InitQuota")]
                [Validation(Required=false)]
                public long? InitQuota { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MARKET_CLOUD_DREAM</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FREE_TRIAL_GIFT</para>
                /// </summary>
                [NameInMap("SourceTypeName")]
                [Validation(Required=false)]
                public string SourceTypeName { get; set; }

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
