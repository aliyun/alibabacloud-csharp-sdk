// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class BatchCreateMaliciousNoteRequest : TeaModel {
        /// <summary>
        /// <para>The batches.</para>
        /// </summary>
        [NameInMap("ImageMaliciousFileList")]
        [Validation(Required=false)]
        public List<BatchCreateMaliciousNoteRequestImageMaliciousFileList> ImageMaliciousFileList { get; set; }
        public class BatchCreateMaliciousNoteRequestImageMaliciousFileList : TeaModel {
            /// <summary>
            /// <para>The ID of the alert.</para>
            /// <remarks>
            /// <para> You can call the <a href="~~DescribeSuspEvents~~">DescribeSuspEvents</a> operation to query the alert IDs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public long? EventId { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Malware sample</para>
            /// </summary>
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

        }

    }

}
