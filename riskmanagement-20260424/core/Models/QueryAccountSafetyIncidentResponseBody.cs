// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class QueryAccountSafetyIncidentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAccountSafetyIncidentResponseBodyData Data { get; set; }
        public class QueryAccountSafetyIncidentResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryAccountSafetyIncidentResponseBodyDataList> List { get; set; }
            public class QueryAccountSafetyIncidentResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>success_service</para>
                /// </summary>
                [NameInMap("ActionCode")]
                [Validation(Required=false)]
                public string ActionCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>处罚直接成功</para>
                /// </summary>
                [NameInMap("ActionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-03-16 15:15:00</para>
                /// </summary>
                [NameInMap("AntiPunishTime")]
                [Validation(Required=false)]
                public string AntiPunishTime { get; set; }

                [NameInMap("DateExtras")]
                [Validation(Required=false)]
                public QueryAccountSafetyIncidentResponseBodyDataListDateExtras DateExtras { get; set; }
                public class QueryAccountSafetyIncidentResponseBodyDataListDateExtras : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("AlertEndTime")]
                    [Validation(Required=false)]
                    public string AlertEndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("AlertStartTime")]
                    [Validation(Required=false)]
                    public string AlertStartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-03-16 15:15:00</para>
                    /// </summary>
                    [NameInMap("LastCheckTime")]
                    [Validation(Required=false)]
                    public string LastCheckTime { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4ba4065e0b2206c05f86d5eaa00ae520</para>
                /// </summary>
                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ak leak.</para>
                /// </summary>
                [NameInMap("EventImpact")]
                [Validation(Required=false)]
                public string EventImpact { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ak leak.</para>
                /// </summary>
                [NameInMap("EventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ak leak.</para>
                /// </summary>
                [NameInMap("EventReason")]
                [Validation(Required=false)]
                public string EventReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-03-16 15:15:00</para>
                /// </summary>
                [NameInMap("PunishTime")]
                [Validation(Required=false)]
                public string PunishTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>suggestion</para>
                /// </summary>
                [NameInMap("Reinforcement")]
                [Validation(Required=false)]
                public string Reinforcement { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>i-2zeanc2b2vgfpbvp60cs</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>customer</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Executing</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>suggestion</para>
                /// </summary>
                [NameInMap("Tip")]
                [Validation(Required=false)]
                public string Tip { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>help</para>
                /// </summary>
                [NameInMap("UserGuideName")]
                [Validation(Required=false)]
                public string UserGuideName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://xxx.aliyun.com/">https://xxx.aliyun.com/</a></para>
                /// </summary>
                [NameInMap("UserGuideUrl")]
                [Validation(Required=false)]
                public string UserGuideUrl { get; set; }

            }

            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public QueryAccountSafetyIncidentResponseBodyDataPageInfo PageInfo { get; set; }
            public class QueryAccountSafetyIncidentResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Current")]
                [Validation(Required=false)]
                public string Current { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public string PageSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public string Total { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful‌</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2FBDD713-00A5-5C98-B661-3FD31A349B6E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
