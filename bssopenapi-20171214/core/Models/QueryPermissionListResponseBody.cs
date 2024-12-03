// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryPermissionListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPermissionListResponseBodyData Data { get; set; }
        public class QueryPermissionListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the relationship expired. If no value is returned, the relationship is still valid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-06T15:12Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The ID of the management account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1990699401005016</para>
            /// </summary>
            [NameInMap("MasterId")]
            [Validation(Required=false)]
            public long? MasterId { get; set; }

            /// <summary>
            /// <para>The ID of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1851253838840762</para>
            /// </summary>
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public long? MemberId { get; set; }

            /// <summary>
            /// <para>The list of permissions.</para>
            /// </summary>
            [NameInMap("PermissionList")]
            [Validation(Required=false)]
            public List<QueryPermissionListResponseBodyDataPermissionList> PermissionList { get; set; }
            public class QueryPermissionListResponseBodyDataPermissionList : TeaModel {
                /// <summary>
                /// <para>The time when the permission expired. If no value is returned, the permission is still valid. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC. For example, 2016-05-23T12:00:00Z indicates that the permission expired at 20:00:00 on May 23, 2016 (UTC+8).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-05T15:12Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The code of the permission.</para>
                /// 
                /// <b>Example:</b>
                /// <para>allow_synchronize_finance_identity</para>
                /// </summary>
                [NameInMap("PermissionCode")]
                [Validation(Required=false)]
                public string PermissionCode { get; set; }

                /// <summary>
                /// <para>The name of the permission.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The management account shares the credit control identity with the member.</para>
                /// </summary>
                [NameInMap("PermissionName")]
                [Validation(Required=false)]
                public string PermissionName { get; set; }

                /// <summary>
                /// <para>The time when the permission took effect. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC. For example, 2016-05-23T12:00:00Z indicates that the permission took effect at 20:00:00 on May 23, 2016 (UTC+8).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-02T15:12Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>The type of the relationship. Valid values: FinancialManagement and FinancialTrusteeship.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinancialManagement</para>
            /// </summary>
            [NameInMap("RelationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

            /// <summary>
            /// <para>The time when the relationship was established. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC. For example, 2016-05-23T12:00:00Z indicates that the relationship was established at 20:00:00 on May 23, 2016 (UTC+8).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-02T15:12Z</para>
            /// </summary>
            [NameInMap("SetupTime")]
            [Validation(Required=false)]
            public string SetupTime { get; set; }

            /// <summary>
            /// <para>The time when the relationship took effect. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC. For example, 2016-05-23T12:00:00Z indicates that the relationship took effect at 20:00:00 on May 23, 2016 (UTC+8).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-02T15:12Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the relationship. For more information about valid values of this parameter, see the enumeration values of the RelationshipStatusEnum type in the following table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RELATED</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F6E29451-A3CD-4705-806D-0112D08F5C49</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
