// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class AddAddressBookRequest : TeaModel {
        /// <summary>
        /// <para>The ACK cluster connector ID. You can obtain the value from:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~DescribeAckClusterConnectors~~">DescribeAckClusterConnectors</a>: queries a list of ACK cluster connectors.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ac-7c1bad6c3cc84c33baab1</para>
        /// </summary>
        [NameInMap("AckClusterConnectorId")]
        [Validation(Required=false)]
        public string AckClusterConnectorId { get; set; }

        /// <summary>
        /// <para>The list of ACK cluster pod labels.</para>
        /// <remarks>
        /// <para>A maximum of 10 labels are supported.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AckLabels")]
        [Validation(Required=false)]
        public List<AddAddressBookRequestAckLabels> AckLabels { get; set; }
        public class AddAddressBookRequestAckLabels : TeaModel {
            /// <summary>
            /// <para>The key of the ACK cluster pod label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the ACK cluster pod label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>storage-operator</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The list of ACK cluster pod namespaces.</para>
        /// <remarks>
        /// <para>A maximum of 10 namespaces are supported.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AckNamespaces")]
        [Validation(Required=false)]
        public List<string> AckNamespaces { get; set; }

        /// <summary>
        /// <para>The address list of the address book. Multiple addresses are separated by commas, and within each address element, the address and its description are separated by a space.</para>
        /// <remarks>
        /// <para>This parameter is required when GroupType is set to <c>ip</c>, <c>port</c>, or <c>domain</c>.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>When GroupType is set to <c>ip</c>, enter IP addresses in the address list. Example: 192.0.XX.XX/32 development network segment, 10.0.0.X/24,192.0.XX.XX/24 test network segment.</para>
        /// </description></item>
        /// <item><description><para>When GroupType is set to <c>port</c>, enter ports or port ranges in the address list. Example: 80 HTTP port, 100/200,3306 database port.</para>
        /// </description></item>
        /// <item><description><para>When GroupType is set to <c>domain</c>, enter domain names in the address list. Example: example.com test domain, aliyundoc.com,<a href="http://www.aliyun.com">www.aliyun.com</a> Alibaba Cloud official website.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX/32 ,192.0.XX.XX/24</para>
        /// </summary>
        [NameInMap("AddressList")]
        [Validation(Required=false)]
        public string AddressList { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically add the public IP addresses of ECS instances that match new tags to the address book.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoAddTagEcs")]
        [Validation(Required=false)]
        public string AutoAddTagEcs { get; set; }

        /// <summary>
        /// <para>The description of the address book.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sz-001</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the address book.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sz-001</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The type of the address book.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The language type of the address book description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The source IP address of the requester.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The list of ECS tags.</para>
        /// </summary>
        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<AddAddressBookRequestTagList> TagList { get; set; }
        public class AddAddressBookRequestTagList : TeaModel {
            /// <summary>
            /// <para>The key of the ECS tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TXY</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The value of the ECS tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>The logical relationship among multiple ECS tags to be matched.</para>
        /// 
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("TagRelation")]
        [Validation(Required=false)]
        public string TagRelation { get; set; }

    }

}
