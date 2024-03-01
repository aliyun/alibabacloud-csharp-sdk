// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAddressBookResponseBody : TeaModel {
        /// <summary>
        /// The information about the address book.
        /// </summary>
        [NameInMap("Acls")]
        [Validation(Required=false)]
        public List<DescribeAddressBookResponseBodyAcls> Acls { get; set; }
        public class DescribeAddressBookResponseBodyAcls : TeaModel {
            /// <summary>
            /// The addresses in the address book.
            /// </summary>
            [NameInMap("AddressList")]
            [Validation(Required=false)]
            public List<string> AddressList { get; set; }

            /// <summary>
            /// The number of addresses in the address book.
            /// </summary>
            [NameInMap("AddressListCount")]
            [Validation(Required=false)]
            public int? AddressListCount { get; set; }

            /// <summary>
            /// Indicates whether the public IP addresses of ECS instances are automatically added to the address book if the instances match the specified tags. The setting takes effect on both newly purchased ECS instances whose tag settings are complete and ECS instances whose tag settings are modified. Valid values:
            /// 
            /// *   **1**: yes
            /// *   **0**: no
            /// </summary>
            [NameInMap("AutoAddTagEcs")]
            [Validation(Required=false)]
            public int? AutoAddTagEcs { get; set; }

            /// <summary>
            /// The description of the address book.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the address book.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The type of the address book. Valid values:
            /// 
            /// *   **ip**: IP address book
            /// *   **domain**: domain address book
            /// *   **port**: port address book
            /// *   **tag**: ECS tag-based address book
            /// *   **allCloud**: cloud service address book
            /// *   **threat**: threat intelligence address book
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// The UUID of the address book.
            /// </summary>
            [NameInMap("GroupUuid")]
            [Validation(Required=false)]
            public string GroupUuid { get; set; }

            /// <summary>
            /// The number of times that the address book is referenced.
            /// </summary>
            [NameInMap("ReferenceCount")]
            [Validation(Required=false)]
            public int? ReferenceCount { get; set; }

            /// <summary>
            /// The details about the ECS tags that can be automatically added to the address book.
            /// </summary>
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<DescribeAddressBookResponseBodyAclsTagList> TagList { get; set; }
            public class DescribeAddressBookResponseBodyAclsTagList : TeaModel {
                /// <summary>
                /// The key of the ECS tag.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The value of the ECS tag.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// The logical relationship among ECS tags. Valid values:
            /// 
            /// *   **and**: Only the public IP addresses of ECS instances that match all the specified tags can be added to the address book.
            /// *   **or**: The public IP addresses of ECS instances that match any of the specified tags can be added to the address book.
            /// </summary>
            [NameInMap("TagRelation")]
            [Validation(Required=false)]
            public string TagRelation { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of the returned address books.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
