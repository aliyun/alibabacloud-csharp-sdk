// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class UpdateResourceExportTaskAttributeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ex-kw161ol8te1n701e1igt8q8</para>
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
        /// <para>B43F08A7-F2A3-54D3-BDA4-69C9F32A7B9F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
