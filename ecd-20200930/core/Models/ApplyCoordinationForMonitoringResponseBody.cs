// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ApplyCoordinationForMonitoringResponseBody : TeaModel {
        /// <summary>
        /// The list of stream collaboration models.
        /// </summary>
        [NameInMap("CoordinateFlowModels")]
        [Validation(Required=false)]
        public List<ApplyCoordinationForMonitoringResponseBodyCoordinateFlowModels> CoordinateFlowModels { get; set; }
        public class ApplyCoordinationForMonitoringResponseBodyCoordinateFlowModels : TeaModel {
            /// <summary>
            /// The ID of the stream collaboration.
            /// </summary>
            [NameInMap("CoId")]
            [Validation(Required=false)]
            public string CoId { get; set; }

            /// <summary>
            /// The current status of the collaboration task.
            /// 
            /// Valid values:
            /// 
            /// *   COORDINATING
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     The collaboration task is being executed
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   TERMINATING
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     The collaboration task is being terminated
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   TERMINATED
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     The collaboration task is terminated
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   PENDING
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     The collaboration task is pending to be executed
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// </summary>
            [NameInMap("CoordinateStatus")]
            [Validation(Required=false)]
            public string CoordinateStatus { get; set; }

            /// <summary>
            /// The ticket that is used to establish the Adaptive Streaming Protocol (ASP)-based connection.
            /// </summary>
            [NameInMap("CoordinateTicket")]
            [Validation(Required=false)]
            public string CoordinateTicket { get; set; }

            /// <summary>
            /// The type of the initiator.
            /// 
            /// Valid values:
            /// 
            /// *   ADMIN_INITIATE_FORCE
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     The administrator forcibly initiates the collaboration request
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   ADMIN_INITIATE
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     The administrator initiates the collaboration request
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   COORDINATOR_INITIATE_FORCE
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     The coordinator forcibly initiates the collaboration request
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// </summary>
            [NameInMap("InitiatorType")]
            [Validation(Required=false)]
            public string InitiatorType { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account of the end user.
            /// </summary>
            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// The ID of the cloud desktop.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The name of the cloud desktop.
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
