// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class ListTicketNotesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the permission error. An empty string is returned if you have the required permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;AuthAction\&quot;:\&quot;ram:ListTicketNotes\&quot;,\&quot;AuthPrincipalDisplayName\&quot;:\&quot;2146216584788xxxxx\&quot;,\&quot;AuthPrincipalOwnerId\&quot;:\&quot;1135850448xxxxx\&quot;,\&quot;AuthPrincipalType\&quot;:\&quot;SubUser\&quot;,\&quot;NoPermissionType\&quot;:\&quot;ImplicitDeny\&quot;,\&quot;PolicyType\&quot;:\&quot;AccountLevelIdentityBasedPolicy\&quot;}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The return code for the API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The return value, which is a list of communication records for the specified ticket.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListTicketNotesResponseBodyData> Data { get; set; }
        public class ListTicketNotesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of attachments.</para>
            /// </summary>
            [NameInMap("Attachments")]
            [Validation(Required=false)]
            public List<ListTicketNotesResponseBodyDataAttachments> Attachments { get; set; }
            public class ListTicketNotesResponseBodyDataAttachments : TeaModel {
                /// <summary>
                /// <para>The name of the attachment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>003.jpg</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>A temporary URL to access the attachment.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://gts-workorder.oss-cn-beijing.aliyuncs.com/20221003/cbc00fb0-b612-4d89-a75b-8d535f750f9f/image.png">https://gts-workorder.oss-cn-beijing.aliyuncs.com/20221003/cbc00fb0-b612-4d89-a75b-8d535f750f9f/image.png</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The UNIX timestamp when the communication message was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1623396736000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ticket communication record object.</para>
            /// </summary>
            [NameInMap("Dialog")]
            [Validation(Required=false)]
            public ListTicketNotesResponseBodyDataDialog Dialog { get; set; }
            public class ListTicketNotesResponseBodyDataDialog : TeaModel {
                /// <summary>
                /// <para>The content of the ticket communication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hello, my ECS renewal failed. What is the reason?</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The system card for the ticket communication record. This parameter is reserved for future use. Currently, you can use the \<c>Content\\</c> parameter to retrieve the plain text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

            }

            /// <summary>
            /// <para>The unique ID of the communication record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9999</para>
            /// </summary>
            [NameInMap("DialogId")]
            [Validation(Required=false)]
            public long? DialogId { get; set; }

            /// <summary>
            /// <para>The status of the communication message. Valid values: \<c>1\\</c>: Unread. \<c>2\\</c>: Read.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>This parameter is not in use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Tip")]
            [Validation(Required=false)]
            public string Tip { get; set; }

            /// <summary>
            /// <para>The type of communication. Valid values: \<c>1\\</c>: Card, which corresponds to \<c>Schema\\</c>. \<c>2\\</c>: Text, which corresponds to \<c>Content\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>The user in the communication.</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public ListTicketNotesResponseBodyDataUser User { get; set; }
            public class ListTicketNotesResponseBodyDataUser : TeaModel {
                /// <summary>
                /// <para>The name of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The role of the user in the communication. This parameter distinguishes between customer service agents and customers. Valid values: \<c>2\\</c>: Customer service agent. \<c>3\\</c>: Customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public int? Role { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message. This parameter is returned when \<c>Success\\</c> is \<c>false\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid input parameter</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. Each request has a unique ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AC0AB2EC-AFBC-44BA-AE77-132A5A1EC0AD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. A value of \<c>true\\</c> indicates a successful call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
