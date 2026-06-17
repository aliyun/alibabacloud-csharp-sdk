// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAddressBookResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of address books.</para>
        /// </summary>
        [NameInMap("Acls")]
        [Validation(Required=false)]
        public List<DescribeAddressBookResponseBodyAcls> Acls { get; set; }
        public class DescribeAddressBookResponseBodyAcls : TeaModel {
            /// <summary>
            /// <para>The ID of the ACK cluster connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ac-7c1bad6c3cc84c33baab</para>
            /// </summary>
            [NameInMap("AckClusterConnectorId")]
            [Validation(Required=false)]
            public string AckClusterConnectorId { get; set; }

            /// <summary>
            /// <para>The name of the ACK cluster connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack-cluster-connector-name</para>
            /// </summary>
            [NameInMap("AckClusterConnectorName")]
            [Validation(Required=false)]
            public string AckClusterConnectorName { get; set; }

            /// <summary>
            /// <para>A list of ACK pod labels.</para>
            /// </summary>
            [NameInMap("AckLabels")]
            [Validation(Required=false)]
            public List<DescribeAddressBookResponseBodyAclsAckLabels> AckLabels { get; set; }
            public class DescribeAddressBookResponseBodyAclsAckLabels : TeaModel {
                /// <summary>
                /// <para>The key of the ACK pod label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the ACK pod label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>storage-operator</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>A list of ACK namespaces.</para>
            /// </summary>
            [NameInMap("AckNamespaces")]
            [Validation(Required=false)]
            public List<string> AckNamespaces { get; set; }

            /// <summary>
            /// <para>A list of CIDR blocks in the address book.</para>
            /// </summary>
            [NameInMap("AddressList")]
            [Validation(Required=false)]
            public List<string> AddressList { get; set; }

            /// <summary>
            /// <para>The number of addresses in the address book.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AddressListCount")]
            [Validation(Required=false)]
            public int? AddressListCount { get; set; }

            /// <summary>
            /// <para>A list of addresses, each with a description.</para>
            /// </summary>
            [NameInMap("Addresses")]
            [Validation(Required=false)]
            public List<DescribeAddressBookResponseBodyAclsAddresses> Addresses { get; set; }
            public class DescribeAddressBookResponseBodyAclsAddresses : TeaModel {
                /// <summary>
                /// <para>The IP address or CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.1/32</para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The note for the address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Single Address Description</para>
                /// </summary>
                [NameInMap("Note")]
                [Validation(Required=false)]
                public string Note { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether to automatically add the public IPs of tagged ECS instances to the address book. This applies to newly purchased instances and existing instances whose tags are modified to match.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoAddTagEcs")]
            [Validation(Required=false)]
            public int? AutoAddTagEcs { get; set; }

            /// <summary>
            /// <para>The description of the address book.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEMO</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the address book.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo_address_book</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The type of the address book. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// <para>The UUID of the address book.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f04ac7ce-628b-4cb7-be61-310222b7****</para>
            /// </summary>
            [NameInMap("GroupUuid")]
            [Validation(Required=false)]
            public string GroupUuid { get; set; }

            /// <summary>
            /// <para>The number of times the address book is referenced.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ReferenceCount")]
            [Validation(Required=false)]
            public int? ReferenceCount { get; set; }

            /// <summary>
            /// <para>The region where the ACK cluster connector is deployed. This parameter is returned only when the GroupType parameter is &quot;ack&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>A list of ECS tags.</para>
            /// </summary>
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<DescribeAddressBookResponseBodyAclsTagList> TagList { get; set; }
            public class DescribeAddressBookResponseBodyAclsTagList : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>company</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALL VALUE</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The logical relationship among multiple ECS tags. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>and</para>
            /// </summary>
            [NameInMap("TagRelation")]
            [Validation(Required=false)]
            public string TagRelation { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// <para>The number of address books returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B36F150A-1E27-43AA-B72C-D2AC712F09DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of address books.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
