// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class SetListenerAccessControlStatusRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>open_white_list</b>: enables the whitelist.</description></item>
        /// <item><description><b>close</b>: disables the whitelist.</description></item>
        /// </list>
        /// <remarks>
        /// <para> After the whitelist is enabled, if no IP address is added to the whitelist, the CLB instance does not distribute network traffic.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>open_white_list</para>
        /// </summary>
        [NameInMap("AccessControlStatus")]
        [Validation(Required=false)]
        public string AccessControlStatus { get; set; }

        /// <summary>
        /// <para>The frontend port that is used by the CLB instance.</para>
        /// <para>Valid values: <b>1 to 65535</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The frontend protocol that is used by the CLB instance.</para>
        /// <remarks>
        /// <para> This parameter is required when listeners that use different protocols listen on the same port.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>https</para>
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// <para>The ID of the CLB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-8vb86hxixo8lvsja8****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region where the Classic Load Balancer (CLB) instance is created.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/27584.html">DescribeRegions</a> operation to query the most recent region list.</para>
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

    }

}
