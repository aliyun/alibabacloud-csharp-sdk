// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetDBInstanceConnectivityDiagnosisResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDBInstanceConnectivityDiagnosisResponseBodyData Data { get; set; }
        public class GetDBInstanceConnectivityDiagnosisResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The outlier detection item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SRC_IP_NOT_IN_USER_WHITELIST</b>: The source IP address is not added to the user whitelist.</description></item>
            /// <item><description><b>VIP_NOT_EXISTS</b>: The ALB instance corresponding to the VIP does not exist.</description></item>
            /// <item><description><b>RS_NOT_EXISTS</b>: The RS is not properly mounted.</description></item>
            /// <item><description><b>VIP_TUNNEL_ID_NOT_CONSISTENT</b>: The TUNNEL ID used by the VPC-type VIP is inconsistent with the actual TUNNEL ID of the VPC.</description></item>
            /// <item><description><b>VIP_VPC_CLOUD_INSTANCE_NOT_EXISTS</b>: The VPC-type VIP does not exist.</description></item>
            /// <item><description><b>VIP_IS_NOT_NGLB</b>: The NGLB pattern is shutdown for the VIP.</description></item>
            /// <item><description><b>CUSTINS_NOT_ASSOCIATE_ECS_SECURITY_GROUP</b>: The instance is not associated with a security group.</description></item>
            /// <item><description><b>SRC_IP_NOT_IN_USER_WHITELIST</b>: The source IP address is not added to the user whitelist.</description></item>
            /// <item><description><b>SRC_IP_NOT_IN_ADMIN_WHITELIST</b>: The source IP address is not added to the management machine whitelist.</description></item>
            /// <item><description><b>SRC_IP_NOT_IN_ECS_SECURITY_GROUP</b>: The source IP address is not added to the security group associated with the instance.</description></item>
            /// <item><description><b>VPC_INSTANCE_IP_NOT_WORKING_STATUS</b>: The VPC IP address is in an abnormal state.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SRC_IP_NOT_IN_USER_WHITELIST</para>
            /// </summary>
            [NameInMap("connCheckErrorCode")]
            [Validation(Required=false)]
            public string ConnCheckErrorCode { get; set; }

            /// <summary>
            /// <para>The details of the outlier detection item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Src ip:47.100.XX.XX not in user whitelist</para>
            /// </summary>
            [NameInMap("connCheckErrorMessage")]
            [Validation(Required=false)]
            public string ConnCheckErrorMessage { get; set; }

            /// <summary>
            /// <para>The exception type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The issue can be resolved by the user.</description></item>
            /// <item><description><b>1</b>: The issue requires on-duty personnel to resolve.</description></item>
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
            /// <para>Indicates whether the check is passed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The check is passed.</description></item>
            /// <item><description><b>false</b>: The check is not passed.</description></item>
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
        /// <para>If the request is successful, <b>Successful</b> is returned. If the request fails, an error message is returned, such as an error code.</para>
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
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
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
