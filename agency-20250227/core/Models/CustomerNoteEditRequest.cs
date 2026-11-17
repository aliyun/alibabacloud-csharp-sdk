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
        /// <para>John Smith</para>
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <para>The content of the note.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Routine customer visit to discuss the agent development plan for the customer</para>
        /// </summary>
        [NameInMap("NoteContent")]
        [Validation(Required=false)]
        public string NoteContent { get; set; }

        /// <summary>
        /// <para>The ID of the note. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1629862</para>
        /// </summary>
        [NameInMap("NoteId")]
        [Validation(Required=false)]
        public long? NoteId { get; set; }

        /// <summary>
        /// <para>The time when the contact was made. The value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1784266662000</para>
        /// </summary>
        [NameInMap("TouchDate")]
        [Validation(Required=false)]
        public long? TouchDate { get; set; }

    }

}
