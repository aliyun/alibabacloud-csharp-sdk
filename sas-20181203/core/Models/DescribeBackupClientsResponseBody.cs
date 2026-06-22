// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupClientsResponseBody : TeaModel {
        /// <summary>
        /// <para>The anti-ransomware client information.</para>
        /// </summary>
        [NameInMap("Clients")]
        [Validation(Required=false)]
        public List<DescribeBackupClientsResponseBodyClients> Clients { get; set; }
        public class DescribeBackupClientsResponseBodyClients : TeaModel {
            /// <summary>
            /// <para>The anti-ransomware client ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-000az2f537r73dyh****</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The status of the anti-ransomware client.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>INSTALLING</b>: The client is being installed.</para>
            /// </description></item>
            /// <item><description><para><b>ONLINE</b>: The client is online.</para>
            /// </description></item>
            /// <item><description><para><b>UNINSTALLING</b>: The client is being uninstalled.</para>
            /// </description></item>
            /// <item><description><para><b>NOT_INSTALLED</b>: The client is not installed.</para>
            /// </description></item>
            /// <item><description><para><b>ACTIVATED</b>: The client is activated.</para>
            /// </description></item>
            /// <item><description><para><b>CLIENT_CONNECTION_ERROR</b>: A client connection error occurred.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ONLINE</para>
            /// </summary>
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

            /// <summary>
            /// <para>The version number of the anti-ransomware client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0.0</para>
            /// </summary>
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            /// <summary>
            /// <para>The instance ID of the ECS instance that has the anti-ransomware client installed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp15hyph4aci99dv****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The UUID of the ECS instance that has the anti-ransomware client installed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22f6550d-f294-449b-b6e6-90638fd1****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each API request. You can use the request ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E3ED094C-9EB7-4239-962B-D0FB3D5F23C7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
