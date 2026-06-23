// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListSynchronizationJobsRequest : TeaModel {
        /// <summary>
        /// <para>Synchronization job direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ingress: inbound</para>
        /// </description></item>
        /// <item><description><para>egress: outbound</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ingress</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>Synchronization end time in Unix timestamp format, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649830226000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Filter parameters</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ListSynchronizationJobsRequestFilters> Filters { get; set; }
        public class ListSynchronizationJobsRequestFilters : TeaModel {
            /// <summary>
            /// <para>Dynamic parameter name</para>
            /// 
            /// <b>Example:</b>
            /// <para>qps</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Dynamic parameter values</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Number of rows per page for paginated queries. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>Token for querying the next page. This parameter is not returned when there are no more pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Page number, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Synchronization start time in Unix timestamp format, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649830226000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>Synchronization job status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>pending: initial state</para>
        /// </description></item>
        /// <item><description><para>running: running</para>
        /// </description></item>
        /// <item><description><para>failed: failed</para>
        /// </description></item>
        /// <item><description><para>partial_success: partially succeeded</para>
        /// </description></item>
        /// <item><description><para>success: succeeded</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>List of synchronization target IDs. [idp_111XXXX,idp_222XXXX]</para>
        /// 
        /// <b>Example:</b>
        /// <para>target_001</para>
        /// </summary>
        [NameInMap("TargetIds")]
        [Validation(Required=false)]
        public List<string> TargetIds { get; set; }

        /// <summary>
        /// <para>Synchronization target type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>identity_provider: identity provider</para>
        /// </description></item>
        /// <item><description><para>application: application</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>identity_provider</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
