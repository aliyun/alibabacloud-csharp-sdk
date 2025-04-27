// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DiagnoseInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The diagnosis status. Valid values: Supported: SUCCESS, FAILED, and RUNNING.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DiagnoseInstanceResponseBodyResult Result { get; set; }
        public class DiagnoseInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The ID of the diagnostic instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1535745731000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>es-cn-n6w1o1x0w001c****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>trigger__2020-08-17T17:09:02</para>
            /// </summary>
            [NameInMap("reportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}
