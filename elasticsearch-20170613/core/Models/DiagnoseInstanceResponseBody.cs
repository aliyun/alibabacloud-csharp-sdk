// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DiagnoseInstanceResponseBody : TeaModel {
        /// <summary>
        /// The ID of the report.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The diagnosis status. Valid values: Supported: SUCCESS, FAILED, and RUNNING.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DiagnoseInstanceResponseBodyResult Result { get; set; }
        public class DiagnoseInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// The ID of the diagnostic instance.
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("reportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}
