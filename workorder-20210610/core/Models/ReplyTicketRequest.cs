// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class ReplyTicketRequest : TeaModel {
        /// <summary>
        /// <para>Content of the ticket reply</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Why ECS backup failed?</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Encryption status</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Encrypt")]
        [Validation(Required=false)]
        public bool? Encrypt { get; set; }

        /// <summary>
        /// <para>The list of attachment names, GetAttachmentUploadUrl the ObjectKey field returned by the interface.</para>
        /// </summary>
        [NameInMap("FileNameList")]
        [Validation(Required=false)]
        public List<string> FileNameList { get; set; }

        /// <summary>
        /// <para>The ID of the ticket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0005PYGCW</para>
        /// </summary>
        [NameInMap("TicketId")]
        [Validation(Required=false)]
        public string TicketId { get; set; }

        /// <summary>
        /// <para>Alibaba Cloud UID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1289427240739141</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
