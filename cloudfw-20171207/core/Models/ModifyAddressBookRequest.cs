// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyAddressBookRequest : TeaModel {
        /// <summary>
        /// <para>The addresses in the address book. Separate multiple addresses with commas (,). If you set GroupType to <b>ip</b>, <b>port</b>, or <b>domain</b>, you must specify this parameter.</para>
        /// <list type="bullet">
        /// <item><description>If you set GroupType to <b>ip</b>, you must specify IP addresses for the address book. Example: 1.2.XX.XX/32,1.2.XX.XX/24.</description></item>
        /// <item><description>If you set GroupType to <b>port</b>, you must specify port numbers or port ranges for the address book. Example: 80/80,100/200.</description></item>
        /// <item><description>If you set GroupType to <b>domain</b>, you must specify domain names for the address book. Example: demo1.aliyun.com,demo2.aliyun.com.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX/32, 192.0.XX.XX/24</para>
        /// </summary>
        [NameInMap("AddressList")]
        [Validation(Required=false)]
        public string AddressList { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically add public IP addresses of Elastic Compute Service (ECS) instances to the address book if the instances match the specified tags. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b>: no</description></item>
        /// </list>
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
        /// <para>The ID of the address book.</para>
        /// <remarks>
        /// <para> To modify the address book, you must provide the ID of the address book. You can call the <a href="https://help.aliyun.com/document_detail/138869.html">DescribeAddressBook</a> operation to query the ID.</para>
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
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese (default)</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Modification mode with the following values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b>: Use the value of the AddressList parameter to overwrite the original address book.</description></item>
        /// <item><description><b>Append</b>: After the original address book, append addresses using the value of the AddressList parameter.</description></item>
        /// <item><description><b>Delete</b>: Delete addresses using the value of the AddressList parameter from the address book.</description></item>
        /// </list>
        /// <remarks>
        /// <para>When GroupType is <b>ip</b>, <b>ipv6</b>, <b>port</b>, or <b>domain</b>, if this parameter is not configured, the default is to use the <b>Cover</b> method to modify the address book.
        /// Notice: When GroupType is <b>tag</b>, this parameter must be empty.</notice></para>
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
        /// <para>The ECS tags that you want to match.</para>
        /// </summary>
        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<ModifyAddressBookRequestTagList> TagList { get; set; }
        public class ModifyAddressBookRequestTagList : TeaModel {
            /// <summary>
            /// <para>The key of ECS tag N that you want to match.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TXY</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The value of ECS tag N that you want to match.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>The logical relationship among ECS tags. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>and</b>: Only the public IP addresses of ECS instances that match all the specified tags can be added to the address book.</description></item>
        /// <item><description><b>or</b>: The public IP addresses of ECS instances that match one of the specified tags can be added to the address book.</description></item>
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
