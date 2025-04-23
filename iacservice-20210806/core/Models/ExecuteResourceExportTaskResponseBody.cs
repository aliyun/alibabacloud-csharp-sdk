// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ExecuteResourceExportTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ex-3b6cb9fa4751a6e645ad8365e6</para>
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
        /// <para>0B0A7C19-9077-5975-ACBD-DEE718787992</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
