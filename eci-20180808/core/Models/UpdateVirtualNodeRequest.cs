// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class UpdateVirtualNodeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotency of requests?</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The IP address of the DNS server. If <c>dnsPolicy=ClusterFirst</c> is configured for the Elastic Container Instance pod, Elastic Container Instance uses the configuration to provide DNS services to containers. You can configure multiple IP addresses. Separate multiple IP addresses with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.1.XX.XX</para>
        /// </summary>
        [NameInMap("ClusterDNS")]
        [Validation(Required=false)]
        public string ClusterDNS { get; set; }

        /// <summary>
        /// <para>The domain name of the cluster. If this parameter is specified, in addition to the search domain of the host, Kubelet configures all containers to search for the specified domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("ClusterDomain")]
        [Validation(Required=false)]
        public string ClusterDomain { get; set; }

        /// <summary>
        /// <para>The custom resources that are supported by the virtual node. If a custom resource is specified in the request of an Elastic Container Instance pod, the pod is scheduled to run on the virtual node that supports the custom resource. You can use the <c>Resource name = Number of resources</c> format to specify custom resources. Separate multiple resources with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>example1.com=100,example2.com=200</para>
        /// </summary>
        [NameInMap("CustomResources")]
        [Validation(Required=false)]
        public string CustomResources { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the virtual node.</para>
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
        /// <para>The tags to add to the virtual node.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<UpdateVirtualNodeRequestTag> Tag { get; set; }
        public class UpdateVirtualNodeRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the virtual node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the virtual node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the virtual node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vnd-2ze960zkdqrldeaw****</para>
        /// </summary>
        [NameInMap("VirtualNodeId")]
        [Validation(Required=false)]
        public string VirtualNodeId { get; set; }

        /// <summary>
        /// <para>The name of the virtual node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testNode</para>
        /// </summary>
        [NameInMap("VirtualNodeName")]
        [Validation(Required=false)]
        public string VirtualNodeName { get; set; }

    }

}
