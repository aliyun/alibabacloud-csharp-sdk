// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateRoutineRelatedRecordRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>CreateRoutineRelatedRecord</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RecordName")]
        [Validation(Required=false)]
        public string RecordName { get; set; }

        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
