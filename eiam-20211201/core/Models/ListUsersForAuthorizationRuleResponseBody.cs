// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListUsersForAuthorizationRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page in a paged query. This is the paging size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token returned for the next page of results. Use this token in the next request to retrieve the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of account data.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListUsersForAuthorizationRuleResponseBodyUsers> Users { get; set; }
        public class ListUsersForAuthorizationRuleResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_d6sbsuumeta4h66ec3il7yxxxx</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The time range of the validity period. This parameter takes effect only when ValidityType is set to time_bound.</para>
            /// </summary>
            [NameInMap("ValidityPeriod")]
            [Validation(Required=false)]
            public ListUsersForAuthorizationRuleResponseBodyUsersValidityPeriod ValidityPeriod { get; set; }
            public class ListUsersForAuthorizationRuleResponseBodyUsersValidityPeriod : TeaModel {
                /// <summary>
                /// <para>The end time of the validity period, in UNIX timestamp format. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1704042061000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The start time of the validity period, in UNIX timestamp format. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1704042061000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            /// <summary>
            /// <para>The validity type of the relationship. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>permanent: permanent</description></item>
            /// <item><description>time_bound: custom time range.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>permanent</para>
            /// </summary>
            [NameInMap("ValidityType")]
            [Validation(Required=false)]
            public string ValidityType { get; set; }

        }

    }

}
