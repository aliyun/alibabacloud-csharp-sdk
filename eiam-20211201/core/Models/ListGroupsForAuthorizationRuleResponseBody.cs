// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListGroupsForAuthorizationRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of groups.</para>
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<ListGroupsForAuthorizationRuleResponseBodyGroups> Groups { get; set; }
        public class ListGroupsForAuthorizationRuleResponseBodyGroups : TeaModel {
            /// <summary>
            /// <para>The group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group_d6sbsuumeta4h66ec3il7yxxxx</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

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
            /// <para>The time range of the validity period. This parameter takes effect only when <b>ValidityType</b> is set to <b>time_bound</b>.</para>
            /// </summary>
            [NameInMap("ValidityPeriod")]
            [Validation(Required=false)]
            public ListGroupsForAuthorizationRuleResponseBodyGroupsValidityPeriod ValidityPeriod { get; set; }
            public class ListGroupsForAuthorizationRuleResponseBodyGroupsValidityPeriod : TeaModel {
                /// <summary>
                /// <para>The end time of the validity period. The value is a UNIX timestamp. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1704042061000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The start time of the validity period. The value is a UNIX timestamp. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1704042061000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            /// <summary>
            /// <para>The type of the validity period of the relationship. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>permanent: permanent</para>
            /// </description></item>
            /// <item><description><para>time_bound: custom time range</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>permanent</para>
            /// </summary>
            [NameInMap("ValidityType")]
            [Validation(Required=false)]
            public string ValidityType { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is returned for the next page.</para>
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

    }

}
