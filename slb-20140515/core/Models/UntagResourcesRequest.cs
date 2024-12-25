// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove all tags from the specified resource. This parameter takes effect only if <b>TagKey.N</b> is empty.</para>
        /// <para>Valid values: <b>true</b> and <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the Classic Load Balancer (CLB) instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/27584.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource. You can specify at most 20 resources.</para>
        /// <remarks>
        /// <para> Set <b>ResourceId</b> of the <b>listener</b> to <b>LoadBalancerId_Listener protocol_Port</b>. Set LoadBalancerId to the ID of the CLB instance, and Port to the listener port.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp16qjewdsunr41m1****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The type of resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>instance</b>: CLB instance</description></item>
        /// <item><description><b>certificate</b>: certificate</description></item>
        /// <item><description><b>acl</b>: access control list (ACL)</description></item>
        /// <item><description><b>listener</b>: listener</description></item>
        /// <item><description><b>vservergroup</b>: vServer group</description></item>
        /// <item><description><b>masterslaveservergroup</b>: primary/secondary server group</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tag key. You can specify at most 20 tag keys. The tag key cannot be an empty string.</para>
        /// <para>The tag key can be up to 64 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
        /// <remarks>
        /// <para> If you do not specify <b>TagKey</b>, all tags are removed from the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>FinanceDept</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
