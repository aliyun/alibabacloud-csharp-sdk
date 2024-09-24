/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class AddAddressBookRequest : TeaModel {
        /// <summary>
        /// The addresses that you want to add to the address book. Separate multiple addresses with commas (,).
        /// 
        /// >  If you set GroupType to `ip`, `port` or `domain`, you must specify AddressList.
        /// 
        /// *   If you set GroupType to `ip`, you must add IP addresses to the address book. Example: 192.0.XX.XX/32,192.0.XX.XX/24.
        /// *   If you set GroupType to `port`, you must add port numbers or port ranges to the address book. Example: 80,100/200.
        /// *   If you set GroupType to `domain`, you must add domain names to the address book. Example: example.com,aliyundoc.com.
        /// </summary>
        [NameInMap("AddressList")]
        [Validation(Required=false)]
        public string AddressList { get; set; }

        /// <summary>
        /// Specifies whether to automatically add public IP addresses of ECS instances to the address book if the instances match the specified tags. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0** (default): no
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
        /// The type of the address book. Valid values:
        /// 
        /// *   **ip**: IP address book
        /// *   **domain**: domain address book
        /// *   **port**: port address book
        /// *   **tag**: ECS tag-based address book
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// The language of the content within the response. Valid values:
        /// 
        /// *   **zh** (default): Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

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
        public List<AddAddressBookRequestTagList> TagList { get; set; }
        public class AddAddressBookRequestTagList : TeaModel {
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
        /// The logical relation among the ECS tags that you want to match. Valid values:
        /// 
        /// *   **and** (default): Only the public IP addresses of ECS instances that match all the specified tags can be added to the address book.
        /// *   **or**: The public IP addresses of ECS instances that match one of the specified tags can be added to the address book.
        /// </summary>
        [NameInMap("TagRelation")]
        [Validation(Required=false)]
        public string TagRelation { get; set; }

    }

}
