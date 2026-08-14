// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>A short description of struct</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public GetProjectResponseBodyProject Project { get; set; }
        public class GetProjectResponseBodyProject : TeaModel {
            /// <summary>
            /// <para>The number of application assets in the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AppCount")]
            [Validation(Required=false)]
            public int? AppCount { get; set; }

            /// <summary>
            /// <para>The time when the project was created, in seconds (UNIX timestamp format).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1669630029</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            /// <summary>
            /// <para>The number of database instances in the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DatabaseCount")]
            [Validation(Required=false)]
            public int? DatabaseCount { get; set; }

            /// <summary>
            /// <para>The project description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The number of hosts in the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("HostCount")]
            [Validation(Required=false)]
            public int? HostCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the project is the default project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The list of member accounts UIDs associated with the project.</para>
            /// </summary>
            [NameInMap("MemberIds")]
            [Validation(Required=false)]
            public List<string> MemberIds { get; set; }

            /// <summary>
            /// <para>The project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>projectname</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of notification recipients configured for the project.</para>
            /// </summary>
            [NameInMap("NotifyReceivers")]
            [Validation(Required=false)]
            public List<GetProjectResponseBodyProjectNotifyReceivers> NotifyReceivers { get; set; }
            public class GetProjectResponseBodyProjectNotifyReceivers : TeaModel {
                /// <summary>
                /// <para>The email address of the notification recipient configured for the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1099**@qq.com</para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The name of the notification recipient configured for the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The phone number of the notification recipient configured for the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>131****5643</para>
                /// </summary>
                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// <para>The ID of the notification recipient configured for the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReceiverId")]
                [Validation(Required=false)]
                public string ReceiverId { get; set; }

            }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The time when the project was last updated, in seconds (UNIX timestamp format).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1672502400</para>
            /// </summary>
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>The unique request ID generated by Alibaba Cloud for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
