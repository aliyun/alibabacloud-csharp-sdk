// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListSynchronizationJobsRequest : TeaModel {
        /// <summary>
        /// <para>The direction of the synchronization task. Valid values:</para>
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
        /// <para>The end time of the synchronization. The time is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649830226000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The filter parameters.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ListSynchronizationJobsRequestFilters> Filters { get; set; }
        public class ListSynchronizationJobsRequestFilters : TeaModel {
            /// <summary>
            /// <para>The name of the dynamic parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qps</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the dynamic parameter.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to query the next page. If no more pages exist, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The start time of the synchronization. The time is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649830226000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The status of the synchronization task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>pending: initial state</para>
        /// </description></item>
        /// <item><description><para>running: running</para>
        /// </description></item>
        /// <item><description><para>failed: failed</para>
        /// </description></item>
        /// <item><description><para>partial_success: partially successful</para>
        /// </description></item>
        /// <item><description><para>success: successful</para>
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
        /// <para>The list of synchronization target IDs. Example: [idp_111XXXX,idp_222XXXX].</para>
        /// 
        /// <b>Example:</b>
        /// <para>target_001</para>
        /// </summary>
        [NameInMap("TargetIds")]
        [Validation(Required=false)]
        public List<string> TargetIds { get; set; }

        /// <summary>
        /// <para>The type of the synchronization target. Valid values:</para>
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
