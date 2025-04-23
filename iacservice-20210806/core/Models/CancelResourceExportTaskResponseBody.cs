// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CancelResourceExportTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ex-3b6cb9fa4751a6e5cdc6460282</para>
        /// </summary>
        [NameInMap("exportTaskId")]
        [Validation(Required=false)]
        public string ExportTaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("exportVersion")]
        [Validation(Required=false)]
        public string ExportVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>136B3926-DD90-5DB2-96EC-8BAD6407D1C9</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
