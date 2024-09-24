// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteMaliciousNoteRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the remarks.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListAgentlessMaliciousFiles~~">ListAgentlessMaliciousFiles</a> operation to obtain the ID from the NoteId parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NoteId")]
        [Validation(Required=false)]
        public long? NoteId { get; set; }

    }

}
