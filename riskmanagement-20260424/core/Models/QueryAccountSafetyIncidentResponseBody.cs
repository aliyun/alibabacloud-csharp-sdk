// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class QueryAccountSafetyIncidentResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <remarks>
        /// <para>200: success. Other values (such as 500 or 400): error codes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAccountSafetyIncidentResponseBodyData Data { get; set; }
        public class QueryAccountSafetyIncidentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The event data.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryAccountSafetyIncidentResponseBodyDataList> List { get; set; }
            public class QueryAccountSafetyIncidentResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The control action name code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success_service</para>
                /// </summary>
                [NameInMap("ActionCode")]
                [Validation(Required=false)]
                public string ActionCode { get; set; }

                /// <summary>
                /// <para>The control action name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>处罚直接成功</para>
                /// </summary>
                [NameInMap("ActionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

                /// <summary>
                /// <para>The control removal time.</para>
                /// <remarks>
                /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2026-03-16 15:15:00</para>
                /// </summary>
                [NameInMap("AntiPunishTime")]
                [Validation(Required=false)]
                public string AntiPunishTime { get; set; }

                /// <summary>
                /// <para>The called API operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AddDomainRecord</para>
                /// </summary>
                [NameInMap("CallApi")]
                [Validation(Required=false)]
                public string CallApi { get; set; }

                /// <summary>
                /// <para>The control time information.</para>
                /// </summary>
                [NameInMap("DateExtras")]
                [Validation(Required=false)]
                public QueryAccountSafetyIncidentResponseBodyDataListDateExtras DateExtras { get; set; }
                public class QueryAccountSafetyIncidentResponseBodyDataListDateExtras : TeaModel {
                    /// <summary>
                    /// <para>The alert end time.</para>
                    /// <remarks>
                    /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("AlertEndTime")]
                    [Validation(Required=false)]
                    public string AlertEndTime { get; set; }

                    /// <summary>
                    /// <para>The first alert time.</para>
                    /// <remarks>
                    /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("AlertStartTime")]
                    [Validation(Required=false)]
                    public string AlertStartTime { get; set; }

                    /// <summary>
                    /// <para>The latest detection time.</para>
                    /// <remarks>
                    /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("LastCheckTime")]
                    [Validation(Required=false)]
                    public string LastCheckTime { get; set; }

                }

                /// <summary>
                /// <para>The event ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4ba4065e0b2206c05f86d5eaa00ae520</para>
                /// </summary>
                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                /// <summary>
                /// <para>The event impact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ak leak.</para>
                /// </summary>
                [NameInMap("EventImpact")]
                [Validation(Required=false)]
                public string EventImpact { get; set; }

                /// <summary>
                /// <para>The control event name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ak leak.</para>
                /// </summary>
                [NameInMap("EventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                /// <summary>
                /// <para>The event reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ak leak.</para>
                /// </summary>
                [NameInMap("EventReason")]
                [Validation(Required=false)]
                public string EventReason { get; set; }

                /// <summary>
                /// <para>The event subtype name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>可疑身份调用敏感</para>
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// <para>The exception call time.</para>
                /// <remarks>
                /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2026-03-16 15:15:00</para>
                /// </summary>
                [NameInMap("ExceptionCallTime")]
                [Validation(Required=false)]
                public string ExceptionCallTime { get; set; }

                /// <summary>
                /// <para>The exception IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>39.1X4.63.XX9</para>
                /// </summary>
                [NameInMap("ExceptionIp")]
                [Validation(Required=false)]
                public string ExceptionIp { get; set; }

                /// <summary>
                /// <para>The control start time.</para>
                /// <remarks>
                /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2026-03-16 15:15:00</para>
                /// </summary>
                [NameInMap("PunishTime")]
                [Validation(Required=false)]
                public string PunishTime { get; set; }

                /// <summary>
                /// <para>The hardening suggestion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>suggestion</para>
                /// </summary>
                [NameInMap("Reinforcement")]
                [Validation(Required=false)]
                public string Reinforcement { get; set; }

                /// <summary>
                /// <para>The cloud resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-2zeanc2b2vgfpbvp60cs</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The control object type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>customer</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The event status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Executing</b>: In progress.</description></item>
                /// <item><description><b>Removed</b>: Removed.</description></item>
                /// <item><description><b>Alerting</b>: Alerting.</description></item>
                /// <item><description><b>Ended</b>: Ended.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Executing</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The handling suggestion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>suggestion</para>
                /// </summary>
                [NameInMap("Tip")]
                [Validation(Required=false)]
                public string Tip { get; set; }

                /// <summary>
                /// <para>The help topic name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>help</para>
                /// </summary>
                [NameInMap("UserGuideName")]
                [Validation(Required=false)]
                public string UserGuideName { get; set; }

                /// <summary>
                /// <para>The help topic URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxx.aliyun.com/">https://xxx.aliyun.com/</a></para>
                /// </summary>
                [NameInMap("UserGuideUrl")]
                [Validation(Required=false)]
                public string UserGuideUrl { get; set; }

            }

            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public QueryAccountSafetyIncidentResponseBodyDataPageInfo PageInfo { get; set; }
            public class QueryAccountSafetyIncidentResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// <para>The current page number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Current")]
                [Validation(Required=false)]
                public string Current { get; set; }

                /// <summary>
                /// <para>The number of assets displayed on each page in a paging query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public string PageSize { get; set; }

                /// <summary>
                /// <para>The total number of events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public string Total { get; set; }

            }

        }

        /// <summary>
        /// <para>The prompt message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful‌</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FBDD713-00A5-5C98-B661-3FD31A349B6E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
