// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class AddTicketMemoRequest : TeaModel {
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
        public AddTicketMemoRequestTenantContext TenantContext { get; set; }
        public class AddTicketMemoRequestTenantContext : TeaModel {
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
        public AddTicketMemoRequestTicketMemo TicketMemo { get; set; }
        public class AddTicketMemoRequestTicketMemo : TeaModel {
            [NameInMap("Attachments")]
            [Validation(Required=false)]
            public List<AddTicketMemoRequestTicketMemoAttachments> Attachments { get; set; }
            public class AddTicketMemoRequestTicketMemoAttachments : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;ticket/image/44xxxx9/43003/e27204b38xxxx1640499.txt</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>wahaha.txt</para>
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
