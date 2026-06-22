// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyAddressBookRequest : TeaModel {
        /// <summary>
        /// <para>The list of ACK cluster pod labels.</para>
        /// <remarks>
        /// <para>Maximum of 10 entries.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AckLabels")]
        [Validation(Required=false)]
        public List<ModifyAddressBookRequestAckLabels> AckLabels { get; set; }
        public class ModifyAddressBookRequestAckLabels : TeaModel {
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
        /// <para>Maximum of 10 entries.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AckNamespaces")]
        [Validation(Required=false)]
        public List<string> AckNamespaces { get; set; }

        /// <summary>
        /// <para>The list of addresses in the address book. Multiple addresses are separated by commas, and each address element uses a space to separate the address from its description. You must configure this parameter when GroupType is <b>ip</b>, <b>port</b>, or <b>domain</b>.</para>
        /// <list type="bullet">
        /// <item><description><para>When GroupType is <b>ip</b>, enter IP addresses in the address list. Example: 1.2.XX.XX/32 Development network segment, 10.0.0.X/24,1.2.XX.XX/24 Test network segment.</para>
        /// </description></item>
        /// <item><description><para>When GroupType is <b>port</b>, enter ports or port ranges in the address list. Example: 80/80 HTTP port, 100/200,3306 Database port.</para>
        /// </description></item>
        /// <item><description><para>When GroupType is <b>domain</b>, enter domain names in the address list. Example: demo1.aliyun.com Test domain, demo2.aliyun.com,<a href="http://www.aliyun.com">www.aliyun.com</a> Alibaba Cloud official website.</para>
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
        /// <para>bj-001</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the address book.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bj-001</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The unique ID of the address book.</para>
        /// <remarks>
        /// <para>Value source: <a href="~~DescribeAddressBook~~">Query Address Book List</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0657ab9d-fe8b-4174-b2a6-6baf358e****</para>
        /// </summary>
        [NameInMap("GroupUuid")]
        [Validation(Required=false)]
        public string GroupUuid { get; set; }

        /// <summary>
        /// <para>The language type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The modification method.</para>
        /// <remarks>
        /// <para>When GroupType is <b>ip</b>, <b>ipv6</b>, <b>port</b>, or <b>domain</b>, and this parameter is not configured, the address book is modified using the <b>Cover</b> method by default.
        /// Notice: When GroupType is <b>tag</b>, this parameter must be empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("ModifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

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
        public List<ModifyAddressBookRequestTagList> TagList { get; set; }
        public class ModifyAddressBookRequestTagList : TeaModel {
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
        /// <para>The logical relationship among multiple ECS tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("TagRelation")]
        [Validation(Required=false)]
        public string TagRelation { get; set; }

    }

}
