// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyAddressBookRequest : TeaModel {
        /// <summary>
        /// The addresses in the address book. Separate multiple addresses with commas (,). If you set GroupType to **ip**, **port**, or **domain**, you must specify this parameter.
        /// 
        /// *   If you set GroupType to **ip**, you must specify IP addresses for the address book. Example: 1.2.XX.XX/32,1.2.XX.XX/24.
        /// *   If you set GroupType to **port**, you must specify port numbers or port ranges for the address book. Example: 80/80,100/200.
        /// *   If you set GroupType to **domain**, you must specify domain names for the address book. Example: demo1.aliyun.com,demo2.aliyun.com.
        /// </summary>
        [NameInMap("AddressList")]
        [Validation(Required=false)]
        public string AddressList { get; set; }

        /// <summary>
        /// Specifies whether to automatically add public IP addresses of Elastic Compute Service (ECS) instances to the address book if the instances match the specified tags. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// </summary>
        [NameInMap("AutoAddTagEcs")]
        [Validation(Required=false)]
        public string AutoAddTagEcs { get; set; }

        /// <summary>
        /// The description of the address book.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the address book.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The ID of the address book.
        /// 
        /// >  To modify the address book, you must provide the ID of the address book. You can call the [DescribeAddressBook](https://help.aliyun.com/document_detail/138869.html) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupUuid")]
        [Validation(Required=false)]
        public string GroupUuid { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh**: Chinese (default)
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// Modification mode with the following values:
        /// 
        /// - **Cover**: Use the value of the AddressList parameter to overwrite the original address book.
        /// - **Append**: After the original address book, append addresses using the value of the AddressList parameter.
        /// - **Delete**: Delete addresses using the value of the AddressList parameter from the address book.
        /// 
        /// >When GroupType is **ip**, **ipv6**, **port**, or **domain**, if this parameter is not configured, the default is to use the **Cover** method to modify the address book.
        /// >Notice: When GroupType is **tag**, this parameter must be empty.</notice>
        /// </summary>
        [NameInMap("ModifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceIp { get; set; }

        /// <summary>
        /// The ECS tags that you want to match.
        /// </summary>
        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<ModifyAddressBookRequestTagList> TagList { get; set; }
        public class ModifyAddressBookRequestTagList : TeaModel {
            /// <summary>
            /// The key of ECS tag N that you want to match.
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// The value of ECS tag N that you want to match.
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// The logical relationship among ECS tags. Valid values:
        /// 
        /// *   **and**: Only the public IP addresses of ECS instances that match all the specified tags can be added to the address book.
        /// *   **or**: The public IP addresses of ECS instances that match one of the specified tags can be added to the address book.
        /// </summary>
        [NameInMap("TagRelation")]
        [Validation(Required=false)]
        public string TagRelation { get; set; }

    }

}
