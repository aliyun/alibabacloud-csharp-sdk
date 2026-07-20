// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class CustomerNoteEditRequest : TeaModel {
        /// <summary>
        /// <para>The contact information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13833333333</para>
        /// </summary>
        [NameInMap("ContactInformation")]
        [Validation(Required=false)]
        public string ContactInformation { get; set; }

        /// <summary>
        /// <para>The name of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <para>The content of the note.</para>
        /// 
        /// <b>Example:</b>
        /// <para>日常拜访客户，讨论客户agent建设方案</para>
        /// </summary>
        [NameInMap("NoteContent")]
        [Validation(Required=false)]
        public string NoteContent { get; set; }

        /// <summary>
        /// <para>The note ID. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1629862</para>
        /// </summary>
        [NameInMap("NoteId")]
        [Validation(Required=false)]
        public long? NoteId { get; set; }

        /// <summary>
        /// <para>The touch date. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1784266662000</para>
        /// </summary>
        [NameInMap("TouchDate")]
        [Validation(Required=false)]
        public long? TouchDate { get; set; }

    }

}
