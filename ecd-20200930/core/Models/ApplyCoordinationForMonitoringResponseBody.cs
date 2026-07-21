// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ApplyCoordinationForMonitoringResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of coordination flow data.</para>
        /// </summary>
        [NameInMap("CoordinateFlowModels")]
        [Validation(Required=false)]
        public List<ApplyCoordinationForMonitoringResponseBodyCoordinateFlowModels> CoordinateFlowModels { get; set; }
        public class ApplyCoordinationForMonitoringResponseBodyCoordinateFlowModels : TeaModel {
            /// <summary>
            /// <para>The coordination flow ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>co-0sot77uale3****</para>
            /// </summary>
            [NameInMap("CoId")]
            [Validation(Required=false)]
            public string CoId { get; set; }

            /// <summary>
            /// <para>The current coordination status.
            /// [_single.resp.200.props.CoordinateFlowModels.items.CoordinateStatus.enum.COORDINATING  ]coordinating
            /// [_single.resp.200.props.CoordinateFlowModels.items.CoordinateStatus.enum.TERMINATING  ] terminating
            /// [_single.resp.200.props.CoordinateFlowModels.items.CoordinateStatus.enum.TERMINATED ]terminated
            /// [_single.resp.200.props.CoordinateFlowModels.items.CoordinateStatus.enum.PENDING ]pending acceptance</para>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("CoordinateStatus")]
            [Validation(Required=false)]
            public string CoordinateStatus { get; set; }

            /// <summary>
            /// <para>The ticket used by ASP to establish a connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1VDQ0VTUw0KW0Rlc2t0b3BdDQpHV1Rva2VuPTAwTzgwL3liS25zUEVGdkF6eU1Pc1ExeHZWdmk4VEE3NFJvU1V1d0dPYm1BNkNJWklDMHVNQklWcjU2NS80S0ZQekQ4aGFTR0ZHelZqMTFGbkRpWWgvUFF1Zm1xSXNGdFRFNFRWMExJNit3TkU0L2RMb04wNXBBSE5Tc3M4dWFXY3lwWE****</para>
            /// </summary>
            [NameInMap("CoordinateTicket")]
            [Validation(Required=false)]
            public string CoordinateTicket { get; set; }

            /// <summary>
            /// <para>The initiator type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COORDINATOR_INITIATE_FORCE</para>
            /// </summary>
            [NameInMap("InitiatorType")]
            [Validation(Required=false)]
            public string InitiatorType { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the user on the user side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// <para>The cloud computer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-96vi03f9emqnl****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The cloud computer name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DemoComputer</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
