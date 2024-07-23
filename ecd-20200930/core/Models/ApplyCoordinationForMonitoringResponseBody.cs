// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ApplyCoordinationForMonitoringResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of stream collaboration models.</para>
        /// </summary>
        [NameInMap("CoordinateFlowModels")]
        [Validation(Required=false)]
        public List<ApplyCoordinationForMonitoringResponseBodyCoordinateFlowModels> CoordinateFlowModels { get; set; }
        public class ApplyCoordinationForMonitoringResponseBodyCoordinateFlowModels : TeaModel {
            /// <summary>
            /// <para>The ID of the stream collaboration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>co-0sot77uale3****</para>
            /// </summary>
            [NameInMap("CoId")]
            [Validation(Required=false)]
            public string CoId { get; set; }

            /// <summary>
            /// <para>The current status of the collaboration task.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>COORDINATING: The collaboration task is being executed.</para>
            /// </description></item>
            /// <item><description><para>TERMINATING: The collaboration task is being terminated.</para>
            /// </description></item>
            /// <item><description><para>TERMINATED: The collaboration task is terminated.</para>
            /// </description></item>
            /// <item><description><para>PENDING: The collaboration task is pending to be executed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("CoordinateStatus")]
            [Validation(Required=false)]
            public string CoordinateStatus { get; set; }

            /// <summary>
            /// <para>The ticket that is used to establish the Adaptive Streaming Protocol (ASP)-based connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1VDQ0VTUw0KW0Rlc2t0b3BdDQpHV1Rva2VuPTAwTzgwL3liS25zUEVGdkF6eU1Pc1ExeHZWdmk4VEE3NFJvU1V1d0dPYm1BNkNJWklDMHVNQklWcjU2NS80S0ZQekQ4aGFTR0ZHelZqMTFGbkRpWWgvUFF1Zm1xSXNGdFRFNFRWMExJNit3TkU0L2RMb04wNXBBSE5Tc3M4dWFXY3lwWE****</para>
            /// </summary>
            [NameInMap("CoordinateTicket")]
            [Validation(Required=false)]
            public string CoordinateTicket { get; set; }

            /// <summary>
            /// <para>The type of the initiator.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ADMIN_INITIATE_FORCE: The administrator forcibly initiates the collaboration request.</para>
            /// </description></item>
            /// <item><description><para>ADMIN_INITIATE: The administrator initiates the collaboration request.</para>
            /// </description></item>
            /// <item><description><para>COORDINATOR_INITIATE_FORCE: The coordinator forcibly initiates the collaboration request.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COORDINATOR_INITIATE_FORCE</para>
            /// </summary>
            [NameInMap("InitiatorType")]
            [Validation(Required=false)]
            public string InitiatorType { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account of the end user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// <para>The ID of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-96vi03f9emqnl****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The name of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestDesktop</para>
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
