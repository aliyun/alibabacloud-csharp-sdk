// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class FinishTicketRequest : TeaModel {
        [NameInMap("Notify")]
        [Validation(Required=false)]
        public FinishTicketRequestNotify Notify { get; set; }
        public class FinishTicketRequestNotify : TeaModel {
            [NameInMap("GroupNoticeReceiverUserIds")]
            [Validation(Required=false)]
            public List<string> GroupNoticeReceiverUserIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NoticeAllGroupMember")]
            [Validation(Required=false)]
            public bool? NoticeAllGroupMember { get; set; }

            [NameInMap("WorkNoticeReceiverUserIds")]
            [Validation(Required=false)]
            public List<string> WorkNoticeReceiverUserIds { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eKWh3xxxxiE</para>
        /// </summary>
        [NameInMap("OpenTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dq9hP8Sk2v6vQxxxxiE</para>
        /// </summary>
        [NameInMap("OpenTicketId")]
        [Validation(Required=false)]
        public string OpenTicketId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public FinishTicketRequestTenantContext TenantContext { get; set; }
        public class FinishTicketRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("TicketMemo")]
        [Validation(Required=false)]
        public FinishTicketRequestTicketMemo TicketMemo { get; set; }
        public class FinishTicketRequestTicketMemo : TeaModel {
            [NameInMap("Attachments")]
            [Validation(Required=false)]
            public List<FinishTicketRequestTicketMemoAttachments> Attachments { get; set; }
            public class FinishTicketRequestTicketMemoAttachments : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>wahaha.txt</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ticket/image/44xxxx9/43003/e27xxxx1640499.txt</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            [NameInMap("Memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

        }

    }

}
