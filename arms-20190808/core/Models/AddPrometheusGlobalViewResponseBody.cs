// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class AddPrometheusGlobalViewResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the array object.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddPrometheusGlobalViewResponseBodyData Data { get; set; }
        public class AddPrometheusGlobalViewResponseBodyData : TeaModel {
            /// <summary>
            /// The Info-level information.
            /// </summary>
            [NameInMap("Info")]
            [Validation(Required=false)]
            public AddPrometheusGlobalViewResponseBodyDataInfo Info { get; set; }
            public class AddPrometheusGlobalViewResponseBodyDataInfo : TeaModel {
                /// <summary>
                /// The list of instances that failed to be added.
                /// </summary>
                [NameInMap("FailedInstances")]
                [Validation(Required=false)]
                public string FailedInstances { get; set; }

                /// <summary>
                /// The ID of the global aggregation instance.
                /// </summary>
                [NameInMap("GlobalViewClusterId")]
                [Validation(Required=false)]
                public string GlobalViewClusterId { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// The additional information.
            /// </summary>
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// Indicates whether the request was successful. Valid values:
            /// 
            /// *   `true`
            /// *   `false`
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID. You can use the ID to query logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
