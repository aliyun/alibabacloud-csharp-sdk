// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetDBInstanceConnectivityDiagnosisResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The detailed information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDBInstanceConnectivityDiagnosisResponseBodyData Data { get; set; }
        public class GetDBInstanceConnectivityDiagnosisResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The exception detection items:</para>
            /// <list type="bullet">
            /// <item><description><b>SRC_IP_NOT_IN_USER_WHITELIST</b>: The source IP address is not added to the whitelist of the user.</description></item>
            /// <item><description><b>VIP_NOT_EXISTS</b>: The Application Load Balancer (ALB) instance corresponding to the virtual IP address (VIP) does not exist.</description></item>
            /// <item><description><b>RS_NOT_EXISTS</b>: The resource sharing (RS) is not properly mounted.</description></item>
            /// <item><description><b>VIP_TUNNEL_ID_NOT_CONSISTENT</b>: The tunnel ID used by the VIP of the virtual private cloud (VPC) type is different from the tunnel ID of the VPC.</description></item>
            /// <item><description><b>VIP_VPC_CLOUD_INSTANCE_NOT_EXISTS</b>: The VIP of the VPC type does not exist.</description></item>
            /// <item><description><b>VIP_IS_NOT_NGLB</b>: The NGLB mode is disabled for the VIP.</description></item>
            /// <item><description><b>CUSTINS_NOT_ASSOCIATE_ECS_SECURITY_GROUP</b>: No security group is associated with the instance.</description></item>
            /// <item><description><b>SRC_IP_NOT_IN_USER_WHITELIST</b>: The source IP address is not added to the whitelist of the user.</description></item>
            /// <item><description><b>SRC_IP_NOT_IN_ADMIN_WHITELIST</b>: The source IP address is not added to the whitelist of the instance.</description></item>
            /// <item><description><b>SRC_IP_NOT_IN_ECS_SECURITY_GROUP</b>: The source IP address is not added to the security group that is associated with the instance.</description></item>
            /// <item><description><b>VPC_INSTANCE_IP_NOT_WORKING_STATUS</b>: The IP address in the VPC is in an abnormal state.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SRC_IP_NOT_IN_USER_WHITELIST</para>
            /// </summary>
            [NameInMap("connCheckErrorCode")]
            [Validation(Required=false)]
            public string ConnCheckErrorCode { get; set; }

            /// <summary>
            /// <para>The details of the exception detection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Src ip:47.110.180.62 not in user whitelist</para>
            /// </summary>
            [NameInMap("connCheckErrorMessage")]
            [Validation(Required=false)]
            public string ConnCheckErrorMessage { get; set; }

            /// <summary>
            /// <para>The type of the exception:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: an exception that can be handled by the user.</description></item>
            /// <item><description><b>1</b>: an exception that can be handled by a technical engineer.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("failType")]
            [Validation(Required=false)]
            public string FailType { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-2ze8g2am97624****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the connectivity test was passed:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para>If the request was successful, <b>Successful</b> is returned. Otherwise, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
