// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupClientsResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the information about the anti-ransomware agent.</para>
        /// </summary>
        [NameInMap("Clients")]
        [Validation(Required=false)]
        public List<DescribeBackupClientsResponseBodyClients> Clients { get; set; }
        public class DescribeBackupClientsResponseBodyClients : TeaModel {
            /// <summary>
            /// <para>The ID of the anti-ransomware agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-000az2f537r73dyh****</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The status of the anti-ransomware agent.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INSTALLING</b>: The agent is being installed.</description></item>
            /// <item><description><b>ONLINE</b>: The agent is online.</description></item>
            /// <item><description><b>UNINSTALLING</b>: The agent is being uninstalled.</description></item>
            /// <item><description><b>NOT_INSTALLED</b>: The agent is not installed.</description></item>
            /// <item><description><b>ACTIVATED</b>: The agent is enabled.</description></item>
            /// <item><description><b>CLIENT_CONNECTION_ERROR</b>: A connection error occurs on the agent.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ONLINE</para>
            /// </summary>
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

            /// <summary>
            /// <para>The version of the anti-ransomware agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0.0</para>
            /// </summary>
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            /// <summary>
            /// <para>The ID of the ECS instance on which the anti-ransomware agent is installed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp15hyph4aci99dv****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The UUID of the Elastic Compute Service (ECS) instance on which the anti-ransomware agent is installed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22f6550d-f294-449b-b6e6-90638fd1****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E3ED094C-9EB7-4239-962B-D0FB3D5F23C7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
