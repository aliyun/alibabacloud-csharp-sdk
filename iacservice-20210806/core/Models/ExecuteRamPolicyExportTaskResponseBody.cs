// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ExecuteRamPolicyExportTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("exportVersion")]
        [Validation(Required=false)]
        public string ExportVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7FA0FF4A-ABD4-54F6-BEAC-B4273EBA10A2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
