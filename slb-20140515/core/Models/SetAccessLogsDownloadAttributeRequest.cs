// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class SetAccessLogsDownloadAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1b6c719dfa08ex*****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The access log forwarding rule. Parameters:</para>
        /// <list type="bullet">
        /// <item><description><b>LogProject</b>: the name of the project of Simple Log Service.</description></item>
        /// <item><description><b>LogStore</b>: the name of the Logstore of Simple Log Service.</description></item>
        /// <item><description><b>LoadBalancerId</b>: the ID of the CLB instance.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;logProject&quot;:&quot;my-project&quot;, &quot;LogStore&quot;:&quot;my-log-store&quot;, &quot;LoadBalancerId&quot;:&quot;lb-uf68ps3rekbljmdb0****&quot;}]</para>
        /// </summary>
        [NameInMap("LogsDownloadAttributes")]
        [Validation(Required=false)]
        public string LogsDownloadAttributes { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the CLB instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/27584.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tags that are added to the CLB instance. The tags must be key-value pairs that are contained in a JSON dictionary.</para>
        /// <para>You can specify up to 10 tags in each call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;tagKey&quot;:&quot;Key1&quot;,&quot;tagValue&quot;:&quot;Value1&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
