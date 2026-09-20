// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class CreateGlobalResourceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is automatically populated when the request is sent. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx-xxxxx-xxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the target instance. You can call the DescribeInstances operation to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hb-t4naqsay5gn****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>HbaseSLBThriftVip: Thrift SLB EPS resource.</para>
        /// </description></item>
        /// <item><description><para>SolrSlbVip: Solr SLB EPS resource.</para>
        /// </description></item>
        /// <item><description><para>PhoenixSLBQueryServerVip: Phoenix SLB EPS resource.</para>
        /// </description></item>
        /// <item><description><para>PubHbaseSLBThriftVip: Thrift SLB public network resource.</para>
        /// </description></item>
        /// <item><description><para>PubPhoenixSLBQueryServerVip: Phoenix SLB public network resource.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PubPhoenixSLBQueryServerVip</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The resource type. Set the value to <b>GLOBAL_VIP</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GLOBAL_VIP</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
