// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class ListTicketNotesResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The return code of the request result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Return value, that is, the dialog record list data of the specified ticket</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListTicketNotesResponseBodyData> Data { get; set; }
        public class ListTicketNotesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Attachment List</para>
            /// </summary>
            [NameInMap("Attachments")]
            [Validation(Required=false)]
            public List<ListTicketNotesResponseBodyDataAttachments> Attachments { get; set; }
            public class ListTicketNotesResponseBodyDataAttachments : TeaModel {
                /// <summary>
                /// <para>Attachment Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>003.jpg</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Temporary Accessible Attachment Address</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://gts-workorder.oss-cn-beijing.aliyuncs.com/20221003/cbc00fb0-b612-4d89-a75b-8d535f750f9f/image.png">https://gts-workorder.oss-cn-beijing.aliyuncs.com/20221003/cbc00fb0-b612-4d89-a75b-8d535f750f9f/image.png</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The timestamp when the communication message was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1623396736000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Work order communication record object</para>
            /// </summary>
            [NameInMap("Dialog")]
            [Validation(Required=false)]
            public ListTicketNotesResponseBodyDataDialog Dialog { get; set; }
            public class ListTicketNotesResponseBodyDataDialog : TeaModel {
                /// <summary>
                /// <para>Work order communication content</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS backup failed</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The ticket communication record system card will be used when the system card docking capability is opened in the future. At present, the content can be used to obtain plain text content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

            }

            /// <summary>
            /// <para>The unique ID of the conversation record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9999</para>
            /// </summary>
            [NameInMap("DialogId")]
            [Validation(Required=false)]
            public long? DialogId { get; set; }

            /// <summary>
            /// <para>Communication message status field, reference value Unread=1, Read=2</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Fields Not Used</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Tip")]
            [Validation(Required=false)]
            public string Tip { get; set; }

            /// <summary>
            /// <para>Conversation Type 1 card, that is, schema 2 Text, that is, content</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>Conversation of users</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public ListTicketNotesResponseBodyDataUser User { get; set; }
            public class ListTicketNotesResponseBodyDataUser : TeaModel {
                /// <summary>
                /// <para>Dialog User Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Dialogue user role, distinguish between agent and user.
                /// 2 represents agent, 3 represents user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public int? Role { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message. If success is set to false, the message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the API request. The requestID is unique for each call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AC0AB2EC-AFBC-44BA-AE77-132A5A1EC0AD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates that the call is normal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
