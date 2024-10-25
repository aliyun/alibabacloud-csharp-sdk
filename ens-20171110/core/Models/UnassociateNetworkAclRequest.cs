// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class UnassociateNetworkAclRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the network ACL that you want to disassociate from a resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nacl-a2do9e413e0sp****</para>
        /// </summary>
        [NameInMap("NetworkAclId")]
        [Validation(Required=false)]
        public string NetworkAclId { get; set; }

        /// <summary>
        /// <para>Resources that you want to disassociate. Valid values of <b>N</b>: 0 to 29. A maximum of 30 resources can be unbound.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public List<UnassociateNetworkAclRequestResource> Resource { get; set; }
        public class UnassociateNetworkAclRequestResource : TeaModel {
            /// <summary>
            /// <para>The ID of the resource that you want to disassociate.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n-5***</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The type of the resource that you want to disassociate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Network</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Network</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
