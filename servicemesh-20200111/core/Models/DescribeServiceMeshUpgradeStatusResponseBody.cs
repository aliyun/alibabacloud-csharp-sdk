// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshUpgradeStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11fd0027-c27e-41bb-a565-75583054****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The upgrade results.</para>
        /// </summary>
        [NameInMap("UpgradeDetail")]
        [Validation(Required=false)]
        public DescribeServiceMeshUpgradeStatusResponseBodyUpgradeDetail UpgradeDetail { get; set; }
        public class DescribeServiceMeshUpgradeStatusResponseBodyUpgradeDetail : TeaModel {
            /// <summary>
            /// <para>The number of ingress gateways that are upgraded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FinishedGatewaysNum")]
            [Validation(Required=false)]
            public long? FinishedGatewaysNum { get; set; }

            /// <summary>
            /// <para>The information about the status of the ingress gateways.</para>
            /// </summary>
            [NameInMap("GatewayStatusRecord")]
            [Validation(Required=false)]
            public Dictionary<string, UpgradeDetailGatewayStatusRecordValue> GatewayStatusRecord { get; set; }

            /// <summary>
            /// <para>The status of the ASM instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>running: The instance is running.</description></item>
            /// <item><description><c>upgrading</c>: The instance is being upgraded.</description></item>
            /// <item><description><c>upgrading_failed</c>: The upgrade of the instance fails.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("MeshStatus")]
            [Validation(Required=false)]
            public string MeshStatus { get; set; }

            /// <summary>
            /// <para>The total number of ingress gateways in the ASM instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalGatewaysNum")]
            [Validation(Required=false)]
            public long? TotalGatewaysNum { get; set; }

        }

    }

}
