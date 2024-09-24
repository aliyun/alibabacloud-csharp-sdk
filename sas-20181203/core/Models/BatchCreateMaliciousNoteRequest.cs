// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class BatchCreateMaliciousNoteRequest : TeaModel {
        [NameInMap("ImageMaliciousFileList")]
        [Validation(Required=false)]
        public List<BatchCreateMaliciousNoteRequestImageMaliciousFileList> ImageMaliciousFileList { get; set; }
        public class BatchCreateMaliciousNoteRequestImageMaliciousFileList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public long? EventId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Malware sample</para>
            /// </summary>
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

        }

    }

}
