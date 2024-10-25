// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AccosicateNetworkAclRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the network ACL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nacl-a2do9e413e0sp****</para>
        /// </summary>
        [NameInMap("NetworkAclId")]
        [Validation(Required=false)]
        public string NetworkAclId { get; set; }

        /// <summary>
        /// <para>The type of resource with which you want to associate the network ACL.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public List<AccosicateNetworkAclRequestResource> Resource { get; set; }
        public class AccosicateNetworkAclRequestResource : TeaModel {
            /// <summary>
            /// <para>The ID of the associated resource.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n-5****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The type of the associated resource. Set the value to <b>Network</b>.</para>
            /// <para>Valid values of <b>N</b>: 0 to 29. You can associate a network ACL with at most 30 resources.</para>
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
