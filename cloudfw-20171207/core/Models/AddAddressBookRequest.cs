// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class AddAddressBookRequest : TeaModel {
        /// <summary>
        /// <para>The addresses that you want to add to the address book. Separate multiple addresses with commas (,).</para>
        /// <remarks>
        /// <para> If you set GroupType to <c>ip</c>, <c>port</c> or <c>domain</c>, you must specify AddressList.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you set GroupType to <c>ip</c>, you must add IP addresses to the address book. Example: 192.0.XX.XX/32,192.0.XX.XX/24.</description></item>
        /// <item><description>If you set GroupType to <c>port</c>, you must add port numbers or port ranges to the address book. Example: 80,100/200.</description></item>
        /// <item><description>If you set GroupType to <c>domain</c>, you must add domain names to the address book. Example: example.com,aliyundoc.com.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX/32, 192.0.XX.XX/24</para>
        /// </summary>
        [NameInMap("AddressList")]
        [Validation(Required=false)]
        public string AddressList { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically add public IP addresses of ECS instances to the address book if the instances match the specified tags. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b> (default): no</description></item>
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
        /// <para>The type of the address book. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ip</b>: IP address book</description></item>
        /// <item><description><b>domain</b>: domain address book</description></item>
        /// <item><description><b>port</b>: port address book</description></item>
        /// <item><description><b>tag</b>: ECS tag-based address book</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The language of the content within the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
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
        /// <para>The logical relation among the ECS tags that you want to match. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>and</b> (default): Only the public IP addresses of ECS instances that match all the specified tags can be added to the address book.</description></item>
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
