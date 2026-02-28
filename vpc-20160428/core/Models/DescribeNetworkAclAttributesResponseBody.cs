// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeNetworkAclAttributesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the network ACLs.</para>
        /// </summary>
        [NameInMap("NetworkAclAttribute")]
        [Validation(Required=false)]
        public DescribeNetworkAclAttributesResponseBodyNetworkAclAttribute NetworkAclAttribute { get; set; }
        public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttribute : TeaModel {
            /// <summary>
            /// <para>The time when the network ACL was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-25 11:33:27</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the network ACL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is my NetworkAcl.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EgressAclEntries")]
            [Validation(Required=false)]
            public DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeEgressAclEntries EgressAclEntries { get; set; }
            public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeEgressAclEntries : TeaModel {
                [NameInMap("EgressAclEntry")]
                [Validation(Required=false)]
                public List<DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeEgressAclEntriesEgressAclEntry> EgressAclEntry { get; set; }
                public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeEgressAclEntriesEgressAclEntry : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("DestinationCidrIp")]
                    [Validation(Required=false)]
                    public string DestinationCidrIp { get; set; }

                    [NameInMap("EntryType")]
                    [Validation(Required=false)]
                    public string EntryType { get; set; }

                    [NameInMap("IpVersion")]
                    [Validation(Required=false)]
                    public string IpVersion { get; set; }

                    [NameInMap("NetworkAclEntryId")]
                    [Validation(Required=false)]
                    public string NetworkAclEntryId { get; set; }

                    [NameInMap("NetworkAclEntryName")]
                    [Validation(Required=false)]
                    public string NetworkAclEntryName { get; set; }

                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                }

            }

            [NameInMap("IngressAclEntries")]
            [Validation(Required=false)]
            public DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeIngressAclEntries IngressAclEntries { get; set; }
            public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeIngressAclEntries : TeaModel {
                [NameInMap("IngressAclEntry")]
                [Validation(Required=false)]
                public List<DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeIngressAclEntriesIngressAclEntry> IngressAclEntry { get; set; }
                public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeIngressAclEntriesIngressAclEntry : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("EntryType")]
                    [Validation(Required=false)]
                    public string EntryType { get; set; }

                    [NameInMap("IpVersion")]
                    [Validation(Required=false)]
                    public string IpVersion { get; set; }

                    [NameInMap("NetworkAclEntryId")]
                    [Validation(Required=false)]
                    public string NetworkAclEntryId { get; set; }

                    [NameInMap("NetworkAclEntryName")]
                    [Validation(Required=false)]
                    public string NetworkAclEntryName { get; set; }

                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    [NameInMap("SourceCidrIp")]
                    [Validation(Required=false)]
                    public string SourceCidrIp { get; set; }

                }

            }

            /// <summary>
            /// <para>The ID of the network ACL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nacl-a2do9e413e0spnhmj****</para>
            /// </summary>
            [NameInMap("NetworkAclId")]
            [Validation(Required=false)]
            public string NetworkAclId { get; set; }

            /// <summary>
            /// <para>The name of the network ACL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acl-1</para>
            /// </summary>
            [NameInMap("NetworkAclName")]
            [Validation(Required=false)]
            public string NetworkAclName { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the network ACL belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>253460731706911258</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            /// <summary>
            /// <para>The region ID of the network ACL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Resources")]
            [Validation(Required=false)]
            public DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeResources Resources { get; set; }
            public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeResources : TeaModel {
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public List<DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeResourcesResource> Resource { get; set; }
                public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeResourcesResource : TeaModel {
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    [NameInMap("ResourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }

            /// <summary>
            /// <para>The association status of the resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Available</b></description></item>
            /// <item><description><b>Modifying</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeTags Tags { get; set; }
            public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeTags : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeTagsTag> Tag { get; set; }
                public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeTagsTag : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The ID of the VPC to which the network ACL belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-a2d33rfpl72k5defr****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5905F9C-0161-4E72-9CB1-1F3F3CF6268A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
