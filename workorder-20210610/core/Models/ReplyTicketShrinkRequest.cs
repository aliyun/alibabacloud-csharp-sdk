// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class ReplyTicketShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The content of the reply to the ticket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK, the renewal was successful on my end.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Specifies whether to encrypt the content.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Encrypt")]
        [Validation(Required=false)]
        public bool? Encrypt { get; set; }

        /// <summary>
        /// <para>A list of attachment names. This is the ObjectKey field returned by the GetAttachmentUploadUrl operation.</para>
        /// </summary>
        [NameInMap("FileNameList")]
        [Validation(Required=false)]
        public string FileNameListShrink { get; set; }

        /// <summary>
        /// <para>The ticket ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0005PYGCW</para>
        /// </summary>
        [NameInMap("TicketId")]
        [Validation(Required=false)]
        public string TicketId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID (UID).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1289427240739141</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
