// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The list of sold instance IDs, which is used to specify the instances for this operation.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The maximum number of records to return per query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Leave it empty for the first query. For subsequent queries, pass the NextToken value returned in the previous response as is. Do not construct or decode it yourself.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6k=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to query only instances that are not associated with a business resource ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Queries only unassociated instances.</description></item>
        /// <item><description>false or empty: Does not filter by this condition.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("NoResourceId")]
        [Validation(Required=false)]
        public bool? NoResourceId { get; set; }

        /// <summary>
        /// <para>The list of instance property names to be filtered.</para>
        /// </summary>
        [NameInMap("PropertyKeyList")]
        [Validation(Required=false)]
        public List<string> PropertyKeyList { get; set; }

        /// <summary>
        /// <para>The list of associated business resource IDs.</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The resource type. For example, CorePackage indicates a core-hour package. It must be consistent with the resource type of the target instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreditPackage</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of instance statuses used for filtering. You can use NORMAL, DELETED, PENDING, and EXPIRED. ARCHIVED indicates the historical archived status.</para>
        /// </summary>
        [NameInMap("StateList")]
        [Validation(Required=false)]
        public List<string> StateList { get; set; }

    }

}
