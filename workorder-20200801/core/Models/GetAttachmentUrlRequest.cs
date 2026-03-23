// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20200801.Models
{
    public class GetAttachmentUrlRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AttachName")]
        [Validation(Required=false)]
        public string AttachName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NoteId")]
        [Validation(Required=false)]
        public string NoteId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TicketId")]
        [Validation(Required=false)]
        public string TicketId { get; set; }

    }

}
