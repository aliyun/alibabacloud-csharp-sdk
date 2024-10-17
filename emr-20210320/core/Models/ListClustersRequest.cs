// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListClustersRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the clusters. You can specify a maximum of 100 items.</para>
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
        /// <para>The states of clusters. You can specify a maximum of 100 items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;HADOOP&quot;]</para>
        /// </summary>
        [NameInMap("ClusterStates")]
        [Validation(Required=false)]
        public List<string> ClusterStates { get; set; }

        /// <summary>
        /// <para>The types of the clusters. You can specify a maximum of 100 items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;c-b933c5aac8fe****&quot;]</para>
        /// </summary>
        [NameInMap("ClusterTypes")]
        [Validation(Required=false)]
        public List<string> ClusterTypes { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The starting point of the current query. If you do not configure this parameter, the query starts from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJlY21OZXh0VG9rZW4iOiIxIiwidGFpaGFvTmV4dFRva2VuIjoiNTYiLCJ0YWloYW9OZXh0VG9rZW5JbnQiOjU2LCJlY21OZXh0VG9rZW5JbnQiOjF9</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The billing methods. You can specify a maximum of 2 items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ECS&quot;]</para>
        /// </summary>
        [NameInMap("PaymentTypes")]
        [Validation(Required=false)]
        public List<string> PaymentTypes { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-qingdao</description></item>
        /// <item><description>cn-beijing</description></item>
        /// <item><description>cn-zhangjiakou</description></item>
        /// <item><description>cn-huhehaote</description></item>
        /// <item><description>cn-hangzhou</description></item>
        /// <item><description>cn-shanghai</description></item>
        /// <item><description>cn-shenzhen</description></item>
        /// <item><description>cn-chengdu</description></item>
        /// <item><description>cn-hongkong</description></item>
        /// <item><description>cn-wulanchabu</description></item>
        /// <item><description>cn-heyuan-acdr-1</description></item>
        /// <item><description>cn-qingdao-acdr-ut-1</description></item>
        /// <item><description>ap-northeast-1</description></item>
        /// <item><description>ap-southeast-1</description></item>
        /// <item><description>ap-southeast-2</description></item>
        /// <item><description>ap-southeast-3</description></item>
        /// <item><description>ap-southeast-5</description></item>
        /// <item><description>ap-south-1</description></item>
        /// <item><description>us-east-1</description></item>
        /// <item><description>us-west-1</description></item>
        /// <item><description>me-east-1</description></item>
        /// <item><description>me-central-1</description></item>
        /// <item><description>eu-central-1</description></item>
        /// <item><description>eu-west-1</description></item>
        /// <item><description>cn-north-2-gov-1</description></item>
        /// </list>
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
        /// <para>The tags. Number of elements in the array: 1 to 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;PayAsYouGo&quot;]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

    }

}
