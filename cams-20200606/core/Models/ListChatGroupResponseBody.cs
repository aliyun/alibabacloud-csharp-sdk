// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListChatGroupResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListChatGroupResponseBodyData Data { get; set; }
        public class ListChatGroupResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListChatGroupResponseBodyDataList> List { get; set; }
            public class ListChatGroupResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>8613800**</para>
                /// </summary>
                [NameInMap("BusinessNumber")]
                [Validation(Required=false)]
                public string BusinessNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>EA30d***</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ACTIVE</para>
                /// </summary>
                [NameInMap("GroupStatus")]
                [Validation(Required=false)]
                public string GroupStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://chat.whatsapp.com/">https://chat.whatsapp.com/</a>***</para>
                /// </summary>
                [NameInMap("InviteLink")]
                [Validation(Required=false)]
                public string InviteLink { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://aliyun.com/png.jpg">https://aliyun.com/png.jpg</a></para>
                /// </summary>
                [NameInMap("ProfilePictureFile")]
                [Validation(Required=false)]
                public string ProfilePictureFile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("Subject")]
                [Validation(Required=false)]
                public string Subject { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>51</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
