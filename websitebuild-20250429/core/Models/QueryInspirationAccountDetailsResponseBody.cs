// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class QueryInspirationAccountDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the permission verification failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Indicates whether retries are allowed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: Retries are not allowed.</description></item>
        /// <item><description>true: Retries are allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>The name of the application. The system queries the application with this name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>or</para>
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
        /// <para>The dynamic message.</para>
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
        public QueryInspirationAccountDetailsResponseBodyModule Module { get; set; }
        public class QueryInspirationAccountDetailsResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("CurrentPageNum")]
            [Validation(Required=false)]
            public int? CurrentPageNum { get; set; }

            /// <summary>
            /// <para>The request results.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryInspirationAccountDetailsResponseBodyModuleData> Data { get; set; }
            public class QueryInspirationAccountDetailsResponseBodyModuleData : TeaModel {
                /// <summary>
                /// <para>The acquisition time. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-03-03 12:00:00</para>
                /// </summary>
                [NameInMap("AcquisitionTime")]
                [Validation(Required=false)]
                public string AcquisitionTime { get; set; }

                /// <summary>
                /// <para>The balance, which is calculated by subtracting the used amount from the initial quota (initQuota - used).</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("Balance")]
                [Validation(Required=false)]
                public long? Balance { get; set; }

                /// <summary>
                /// <para>The exact value of the balance. The value is of the String type to support decimal display.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("BalanceStr")]
                [Validation(Required=false)]
                public string BalanceStr { get; set; }

                /// <summary>
                /// <para>The expiration time of the validity period. The time is in the YYYY-MM-DD HH:mm:ss Z format, where Z is the time zone offset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-04-11 10:26:27 +0800</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// <para>Indicates whether the quota has expired (endDate &lt; current time). The frontend displays the item in gray based on this value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>False</para>
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                /// <summary>
                /// <para>The acquired amount, which is the initial quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123123</para>
                /// </summary>
                [NameInMap("InitQuota")]
                [Validation(Required=false)]
                public long? InitQuota { get; set; }

                /// <summary>
                /// <para>The exact value of the acquired amount. The value is of the String type to support decimal display.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123123</para>
                /// </summary>
                [NameInMap("InitQuotaStr")]
                [Validation(Required=false)]
                public string InitQuotaStr { get; set; }

                /// <summary>
                /// <para>The code of the source type. Examples: FREE_TRIAL_GIFT, INSTANCE_GIFT, UPGRADE_GRANT, and PURCHASED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MARKET_CLOUD_DREAM</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The Chinese name of the source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FREE_TRIAL_GIFT</para>
                /// </summary>
                [NameInMap("SourceTypeName")]
                [Validation(Required=false)]
                public string SourceTypeName { get; set; }

                /// <summary>
                /// <para>The status of the inspiration credit account.</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The decision weight.</para>
            /// </summary>
            [NameInMap("Next")]
            [Validation(Required=false)]
            public QueryInspirationAccountDetailsResponseBodyModuleNext Next { get; set; }
            public class QueryInspirationAccountDetailsResponseBodyModuleNext : TeaModel {
                /// <summary>
                /// <para>The acquisition time. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-03-03 12:00:00</para>
                /// </summary>
                [NameInMap("AcquisitionTime")]
                [Validation(Required=false)]
                public string AcquisitionTime { get; set; }

                /// <summary>
                /// <para>The balance, which is calculated by subtracting the used amount from the initial quota (initQuota - used).</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("Balance")]
                [Validation(Required=false)]
                public long? Balance { get; set; }

                /// <summary>
                /// <para>The exact value of the balance. The value is of the String type to support decimal display.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("BalanceStr")]
                [Validation(Required=false)]
                public string BalanceStr { get; set; }

                /// <summary>
                /// <para>The expiration time of the validity period. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-02-25 10:11:25</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// <para>Indicates whether the quota has expired (endDate &lt; current time). The frontend displays the item in gray based on this value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>False</para>
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                /// <summary>
                /// <para>The acquired amount, which is the initial quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123123</para>
                /// </summary>
                [NameInMap("InitQuota")]
                [Validation(Required=false)]
                public long? InitQuota { get; set; }

                /// <summary>
                /// <para>The exact value of the acquired amount. The value is of the String type to support decimal display.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123123</para>
                /// </summary>
                [NameInMap("InitQuotaStr")]
                [Validation(Required=false)]
                public string InitQuotaStr { get; set; }

                /// <summary>
                /// <para>The code of the source type. Examples: FREE_TRIAL_GIFT, INSTANCE_GIFT, UPGRADE_GRANT, and PURCHASED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MARKET_CLOUD_DREAM</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The Chinese name of the source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FREE_TRIAL_GIFT</para>
                /// </summary>
                [NameInMap("SourceTypeName")]
                [Validation(Required=false)]
                public string SourceTypeName { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether a next page exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("NextPage")]
            [Validation(Required=false)]
            public bool? NextPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Indicates whether a previous page exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("PrePage")]
            [Validation(Required=false)]
            public bool? PrePage { get; set; }

            /// <summary>
            /// <para>In addition to the pagination limit, the server processes a maximum of the latest 1,000 records for the current query. If the number of results exceeds 1,000, <b>ResultLimit</b> is <b>true</b>. In this case, narrow down the time range and search again. Otherwise, <b>ResultLimit</b> is <b>false</b>.</para>
            /// </summary>
            [NameInMap("ResultLimit")]
            [Validation(Required=false)]
            public bool? ResultLimit { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalItemNum")]
            [Validation(Required=false)]
            public int? TotalItemNum { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
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
