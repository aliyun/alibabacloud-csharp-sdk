// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListContactsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of contacts.</para>
        /// </summary>
        [NameInMap("contacts")]
        [Validation(Required=false)]
        public List<ListContactsResponseBodyContacts> Contacts { get; set; }
        public class ListContactsResponseBodyContacts : TeaModel {
            /// <summary>
            /// <para>The contact ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("contactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            /// <summary>
            /// <para>The email address of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@aliyun.com">test@aliyun.com</a></para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>Indicates whether the email address is verified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("emailVerify")]
            [Validation(Required=false)]
            public bool? EmailVerify { get; set; }

            /// <summary>
            /// <para>The contact groups to which the contact belongs.</para>
            /// </summary>
            [NameInMap("groupList")]
            [Validation(Required=false)]
            public List<string> GroupList { get; set; }

            /// <summary>
            /// <para>The instant messaging user ID mappings. Multiple instant messaging tools are supported.</para>
            /// </summary>
            [NameInMap("imUserIds")]
            [Validation(Required=false)]
            public Dictionary<string, string> ImUserIds { get; set; }

            /// <summary>
            /// <para>The language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh_CN</para>
            /// </summary>
            [NameInMap("lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// <para>The contact name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The phone number of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>130123456789</para>
            /// </summary>
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>Indicates whether the phone number of the contact is verified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("phoneVerify")]
            [Validation(Required=false)]
            public bool? PhoneVerify { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-22 02:21:51</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The workspace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-cms-5884500827389836-cn-hangzhou</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>56</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
