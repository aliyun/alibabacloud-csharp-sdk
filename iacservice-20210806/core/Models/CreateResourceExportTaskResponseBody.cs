// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateResourceExportTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ex-4a1ec8b7003d24528326821be</para>
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
        /// <para>CFD8C2A8-5BE7-56D2-916D-64039B8E06E3</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
