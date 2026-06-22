// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateSuspEventNoteRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the security alert event to which you want to add a note. Call <a href="https://help.aliyun.com/document_detail/251497.html">DescribeSuspEvents</a> to obtain the ID of the alert event.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>668931</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public long? EventId { get; set; }

        /// <summary>
        /// <para>The note to add.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ignore</para>
        /// </summary>
        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

    }

}
