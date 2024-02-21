// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetDBInstanceConnectivityDiagnosisResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The detailed information.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDBInstanceConnectivityDiagnosisResponseBodyData Data { get; set; }
        public class GetDBInstanceConnectivityDiagnosisResponseBodyData : TeaModel {
            /// <summary>
            /// The exception detection items:
            /// 
            /// *   **SRC_IP_NOT_IN_USER_WHITELIST**: The source IP address is not added to the whitelist of the user.
            /// *   **VIP_NOT_EXISTS**: The Application Load Balancer (ALB) instance corresponding to the virtual IP address (VIP) does not exist.
            /// *   **RS_NOT_EXISTS**: The resource sharing (RS) is not properly mounted.
            /// *   **VIP_TUNNEL_ID_NOT_CONSISTENT**: The tunnel ID used by the VIP of the virtual private cloud (VPC) type is different from the tunnel ID of the VPC.
            /// *   **VIP_VPC_CLOUD_INSTANCE_NOT_EXISTS**: The VIP of the VPC type does not exist.
            /// *   **VIP_IS_NOT_NGLB**: The NGLB mode is disabled for the VIP.
            /// *   **CUSTINS_NOT_ASSOCIATE_ECS_SECURITY_GROUP**: No security group is associated with the instance.
            /// *   **SRC_IP_NOT_IN_USER_WHITELIST**: The source IP address is not added to the whitelist of the user.
            /// *   **SRC_IP_NOT_IN_ADMIN_WHITELIST**: The source IP address is not added to the whitelist of the instance.
            /// *   **SRC_IP_NOT_IN_ECS_SECURITY_GROUP**: The source IP address is not added to the security group that is associated with the instance.
            /// *   **VPC_INSTANCE_IP_NOT_WORKING_STATUS**: The IP address in the VPC is in an abnormal state.
            /// </summary>
            [NameInMap("connCheckErrorCode")]
            [Validation(Required=false)]
            public string ConnCheckErrorCode { get; set; }

            /// <summary>
            /// The details of the exception detection.
            /// </summary>
            [NameInMap("connCheckErrorMessage")]
            [Validation(Required=false)]
            public string ConnCheckErrorMessage { get; set; }

            /// <summary>
            /// The type of the exception:
            /// 
            /// *   **0**: an exception that can be handled by the user.
            /// *   **1**: an exception that can be handled by a technical engineer.
            /// </summary>
            [NameInMap("failType")]
            [Validation(Required=false)]
            public string FailType { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// Indicates whether the connectivity test was passed:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// > If the request was successful, **Successful** is returned. Otherwise, an error message such as an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
