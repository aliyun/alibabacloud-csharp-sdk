// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteSuspEventNodeRequest : TeaModel {
        /// <summary>
        /// The ID of the description.
        /// 
        /// > You can call the [DescribeSuspEvents](~~DescribeSuspEvents~~) operation to obtain the ID of the description by using the EventNotes field.
        /// </summary>
        [NameInMap("NoteId")]
        [Validation(Required=false)]
        public long? NoteId { get; set; }

    }

}
