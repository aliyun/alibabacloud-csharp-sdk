// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListClustersRequest : TeaModel {
        /// <summary>
        /// <para>A list of cluster IDs. The number of array elements N can range from 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzabjyop****</para>
        /// </summary>
        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public List<string> ClusterIds { get; set; }

        /// <summary>
        /// <para>The name of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>emrtest</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>An array of cluster states. The number of array elements N can range from 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;HADOOP&quot;]</para>
        /// </summary>
        [NameInMap("ClusterStates")]
        [Validation(Required=false)]
        public List<string> ClusterStates { get; set; }

        /// <summary>
        /// <para>A list of cluster types. The number of array elements N can range from 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;c-b933c5aac8fe****&quot;]</para>
        /// </summary>
        [NameInMap("ClusterTypes")]
        [Validation(Required=false)]
        public List<string> ClusterTypes { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that specifies the position from which to start the query. If you leave this parameter empty, the query starts from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJlY21OZXh0VG9rZW4iOiIxIiwidGFpaGFvTmV4dFRva2VuIjoiNTYiLCJ0YWloYW9OZXh0VG9rZW5JbnQiOjU2LCJlY21OZXh0VG9rZW5JbnQiOjF9</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The billing methods. The number of array elements N can be 1 or 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ECS&quot;]</para>
        /// </summary>
        [NameInMap("PaymentTypes")]
        [Validation(Required=false)]
        public List<string> PaymentTypes { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzabjyop****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>A list of tags. The number of array elements N can range from 1 to 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;PayAsYouGo&quot;]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

    }

}
