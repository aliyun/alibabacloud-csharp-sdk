// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ProcessorAssociate : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ingest-processor-1</para>
        /// </summary>
        [NameInMap("processorId")]
        [Validation(Required=false)]
        public string ProcessorId { get; set; }

    }

}
