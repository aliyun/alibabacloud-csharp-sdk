// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstanceMonitorDataResponseBody : TeaModel {
        /// <summary>
        /// The returned service code. A value of 0 indicates that the operation was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The set of InstanceMonitorDataType data.
        /// </summary>
        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public DescribeInstanceMonitorDataResponseBodyMonitorData MonitorData { get; set; }
        public class DescribeInstanceMonitorDataResponseBodyMonitorData : TeaModel {
            [NameInMap("InstanceMonitorData")]
            [Validation(Required=false)]
            public List<DescribeInstanceMonitorDataResponseBodyMonitorDataInstanceMonitorData> InstanceMonitorData { get; set; }
            public class DescribeInstanceMonitorDataResponseBodyMonitorDataInstanceMonitorData : TeaModel {
                /// <summary>
                /// The vCPU usage of the instance, which is raw data. For example, a value of 0.02 indicates that the usage is 2%.
                /// </summary>
                [NameInMap("CPU")]
                [Validation(Required=false)]
                public string CPU { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// This parameter is not yet supported.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
