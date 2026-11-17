// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class CustomerNoteCreateRequest : TeaModel {
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
        /// <para>The contact name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhang San</para>
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <para>The customer name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXXX Co., Ltd</para>
        /// </summary>
        [NameInMap("CustomerName")]
        [Validation(Required=false)]
        public string CustomerName { get; set; }

        /// <summary>
        /// <para>The customer UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1647796581073291</para>
        /// </summary>
        [NameInMap("CustomerUid")]
        [Validation(Required=false)]
        public string CustomerUid { get; set; }

        /// <summary>
        /// <para>The note content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Routine customer visit to discuss the agent implementation plan for the customer</para>
        /// </summary>
        [NameInMap("NoteContent")]
        [Validation(Required=false)]
        public string NoteContent { get; set; }

        /// <summary>
        /// <para>The contact time (timestamp, in milliseconds).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1784266662000</para>
        /// </summary>
        [NameInMap("TouchDate")]
        [Validation(Required=false)]
        public long? TouchDate { get; set; }

    }

}
