// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DeleteRoutineRelatedRecordRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DeleteRoutineRelatedRecord</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public long? RecordId { get; set; }

        [NameInMap("RecordName")]
        [Validation(Required=false)]
        public string RecordName { get; set; }

        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
