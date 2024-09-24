// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAddressBookResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the address book.</para>
        /// </summary>
        [NameInMap("Acls")]
        [Validation(Required=false)]
        public List<DescribeAddressBookResponseBodyAcls> Acls { get; set; }
        public class DescribeAddressBookResponseBodyAcls : TeaModel {
            /// <summary>
            /// <para>The addresses in the address book.</para>
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
            /// <para>Indicates whether the public IP addresses of ECS instances are automatically added to the address book if the instances match the specified tags. The setting takes effect on both newly purchased ECS instances whose tag settings are complete and ECS instances whose tag settings are modified. Valid values:</para>
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
            public int? AutoAddTagEcs { get; set; }

            /// <summary>
            /// <para>The description of the address book.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my address book</para>
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
            /// <list type="bullet">
            /// <item><description><b>ip</b>: IP address book</description></item>
            /// <item><description><b>domain</b>: domain address book</description></item>
            /// <item><description><b>port</b>: port address book</description></item>
            /// <item><description><b>tag</b>: ECS tag-based address book</description></item>
            /// <item><description><b>allCloud</b>: cloud service address book</description></item>
            /// <item><description><b>threat</b>: threat intelligence address book</description></item>
            /// </list>
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
            /// <para>The number of times that the address book is referenced.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ReferenceCount")]
            [Validation(Required=false)]
            public int? ReferenceCount { get; set; }

            /// <summary>
            /// <para>The details about the ECS tags that can be automatically added to the address book.</para>
            /// </summary>
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<DescribeAddressBookResponseBodyAclsTagList> TagList { get; set; }
            public class DescribeAddressBookResponseBodyAclsTagList : TeaModel {
                /// <summary>
                /// <para>The key of the ECS tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>company</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The value of the ECS tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The logical relationship among ECS tags. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>and</b>: Only the public IP addresses of ECS instances that match all the specified tags can be added to the address book.</description></item>
            /// <item><description><b>or</b>: The public IP addresses of ECS instances that match any of the specified tags can be added to the address book.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>and</para>
            /// </summary>
            [NameInMap("TagRelation")]
            [Validation(Required=false)]
            public string TagRelation { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>The total number of the returned address books.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
