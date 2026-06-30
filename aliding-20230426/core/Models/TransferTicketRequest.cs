// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class TransferTicketRequest : TeaModel {
        [NameInMap("Notify")]
        [Validation(Required=false)]
        public TransferTicketRequestNotify Notify { get; set; }
        public class TransferTicketRequestNotify : TeaModel {
            [NameInMap("GroupNoticeReceiverUserIds")]
            [Validation(Required=false)]
            public List<string> GroupNoticeReceiverUserIds { get; set; }

            [NameInMap("NoticeAllGroupMember")]
            [Validation(Required=false)]
            public bool? NoticeAllGroupMember { get; set; }

            [NameInMap("WorkNoticeReceiverUserIds")]
            [Validation(Required=false)]
            public List<string> WorkNoticeReceiverUserIds { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OpenTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OpenTicketId")]
        [Validation(Required=false)]
        public string OpenTicketId { get; set; }

        [NameInMap("ProcessorUserIds")]
        [Validation(Required=false)]
        public List<string> ProcessorUserIds { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public TransferTicketRequestTenantContext TenantContext { get; set; }
        public class TransferTicketRequestTenantContext : TeaModel {
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
        public TransferTicketRequestTicketMemo TicketMemo { get; set; }
        public class TransferTicketRequestTicketMemo : TeaModel {
            [NameInMap("Attachments")]
            [Validation(Required=false)]
            public List<TransferTicketRequestTicketMemoAttachments> Attachments { get; set; }
            public class TransferTicketRequestTicketMemoAttachments : TeaModel {
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

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
