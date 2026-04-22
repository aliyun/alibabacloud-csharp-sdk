// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ADBAI20250812.Models
{
    public class DescribeEapDeviceResourceAllocationResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeEapDeviceResourceAllocationResponseBodyItems> Items { get; set; }
        public class DescribeEapDeviceResourceAllocationResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DeviceCount")]
            [Validation(Required=false)]
            public int? DeviceCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("HeadAcu")]
            [Validation(Required=false)]
            public double? HeadAcu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("HeadCpu")]
            [Validation(Required=false)]
            public int? HeadCpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;medium&quot;</para>
            /// </summary>
            [NameInMap("HeadSpecName")]
            [Validation(Required=false)]
            public string HeadSpecName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>26</para>
            /// </summary>
            [NameInMap("TotalAcu")]
            [Validation(Required=false)]
            public double? TotalAcu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>26</para>
            /// </summary>
            [NameInMap("TotalDeployedCpu")]
            [Validation(Required=false)]
            public int? TotalDeployedCpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("TotalTargetCpu")]
            [Validation(Required=false)]
            public int? TotalTargetCpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8.0</para>
            /// </summary>
            [NameInMap("WebserverAcu")]
            [Validation(Required=false)]
            public double? WebserverAcu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("WebserverCpu")]
            [Validation(Required=false)]
            public int? WebserverCpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;xlarge&quot;</para>
            /// </summary>
            [NameInMap("WebserverSpecName")]
            [Validation(Required=false)]
            public string WebserverSpecName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>16.0</para>
            /// </summary>
            [NameInMap("WorkerAcu")]
            [Validation(Required=false)]
            public double? WorkerAcu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("WorkerCount")]
            [Validation(Required=false)]
            public int? WorkerCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("WorkerCpu")]
            [Validation(Required=false)]
            public int? WorkerCpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;xlarge&quot;</para>
            /// </summary>
            [NameInMap("WorkerSpecName")]
            [Validation(Required=false)]
            public string WorkerSpecName { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>19E994DC-A816-56DB-9F90-5F8E403DD19D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
