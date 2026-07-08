// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyAddressBookShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of labels for ACK cluster pods.</para>
        /// <remarks>
        /// <para>A maximum of 10 labels are supported.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AckLabels")]
        [Validation(Required=false)]
        public List<ModifyAddressBookShrinkRequestAckLabels> AckLabels { get; set; }
        public class ModifyAddressBookShrinkRequestAckLabels : TeaModel {
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
        /// <para>The list of namespaces for ACK cluster pods.</para>
        /// <remarks>
        /// <para>A maximum of 10 namespaces are supported.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AckNamespaces")]
        [Validation(Required=false)]
        public List<string> AckNamespaces { get; set; }

        /// <summary>
        /// <para>The addresses in the address book. Separate multiple addresses with commas (,). Use a space to separate an address from its description. This parameter is required when GroupType is set to <b>ip</b>, <b>port</b>, or <b>domain</b>.</para>
        /// <list type="bullet">
        /// <item><description><para>When GroupType is set to <b>ip</b>, specify IP addresses. Example: 1.2.XX.XX/32 Development CIDR block,10.0.0.X/24,1.2.XX.XX/24 Test CIDR block.</para>
        /// </description></item>
        /// <item><description><para>When GroupType is set to <b>port</b>, specify ports or port ranges. Example: 80/80 HTTP port,100/200,3306 Database port.</para>
        /// </description></item>
        /// <item><description><para>When GroupType is set to <b>domain</b>, specify domain names. Example: demo1.aliyun.com Test domain name,demo2.aliyun.com,<a href="http://www.aliyun.com">www.aliyun.com</a> Alibaba Cloud official website.</para>
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
        /// <para>The list of member accounts for the asset address book.</para>
        /// </summary>
        [NameInMap("AssetMemberUids")]
        [Validation(Required=false)]
        public string AssetMemberUidsShrink { get; set; }

        /// <summary>
        /// <para>The list of regions and resource types for the asset address book.</para>
        /// </summary>
        [NameInMap("AssetRegionResourceTypes")]
        [Validation(Required=false)]
        public string AssetRegionResourceTypesShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether the public IP addresses of Elastic Compute Service (ECS) instances that match new labels is automatically added to the address book.</para>
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
        /// <para>You can obtain the value by calling the <a href="~~DescribeAddressBook~~">DescribeAddressBook</a> operation.</para>
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
        /// <para>The language type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>en</b>: English.</description></item>
        /// <item><description><b>zh</b>: Chinese (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The modification mode.</para>
        /// <remarks>
        /// <para>When GroupType is set to <b>ip</b>, <b>ipv6</b>, <b>port</b>, or <b>domain</b>, the default value is <b>Cover</b> if this parameter is not specified.
        /// Notice: When GroupType is set to <b>tag</b>, this parameter must be left empty.</notice></para>
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
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The ECS tag list.</para>
        /// </summary>
        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<ModifyAddressBookShrinkRequestTagList> TagList { get; set; }
        public class ModifyAddressBookShrinkRequestTagList : TeaModel {
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
        /// <para>The logical relationship among multiple ECS tags. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>or</b>: The public IP address of an ECS instance is added to the address book if the instance matches any of the specified tags.</description></item>
        /// <item><description><b>and</b>: The public IP address of an ECS instance is added to the address book only if the instance matches all of the specified tags.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("TagRelation")]
        [Validation(Required=false)]
        public string TagRelation { get; set; }

    }

}
