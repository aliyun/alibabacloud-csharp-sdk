// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAgentInstallStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of servers.</para>
        /// </summary>
        [NameInMap("AegisClientInvokeStatusResponseList")]
        [Validation(Required=false)]
        public List<DescribeAgentInstallStatusResponseBodyAegisClientInvokeStatusResponseList> AegisClientInvokeStatusResponseList { get; set; }
        public class DescribeAgentInstallStatusResponseBodyAegisClientInvokeStatusResponseList : TeaModel {
            /// <summary>
            /// <para>The returned message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Installed</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The installation status. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><b>-1</b>: The agent is not installed.</description></item>
            /// <item><description><b>0</b>: The agent is installed.</description></item>
            /// <item><description><b>1</b>: Failed to create a directory in the client.</description></item>
            /// <item><description><b>2</b>: Failed to download the installation package.</description></item>
            /// <item><description><b>3</b>: The installation file does not exist.</description></item>
            /// <item><description><b>4</b>: The verification information of the installation file does not exist.</description></item>
            /// <item><description><b>5</b>: Failed to verify the installation file.</description></item>
            /// <item><description><b>6</b>: Failed to execute the installation file.</description></item>
            /// <item><description><b>7</b>: You do not have the required permissions. The installation failed.</description></item>
            /// <item><description><b>8</b>: No client process is detected.</description></item>
            /// <item><description><b>100</b>: The installation failed due to an unknown error.</description></item>
            /// <item><description><b>1001</b>: The installation failed. One-click installation is not supported in this region.</description></item>
            /// <item><description><b>1002</b>: The installation failed. Servers that are not provided by Alibaba Cloud are not supported. Install the agent by executing a script on the server.</description></item>
            /// <item><description><b>1003</b>: The installation failed. The operating system is not supported.</description></item>
            /// <item><description><b>1004</b>: An internal error occurred. Try again later.</description></item>
            /// <item><description><b>1005</b>: The Elastic Compute Service (ECS) instance is not started. Start the ECS instance and try again.</description></item>
            /// <item><description><b>1006</b>: One-click installation is not supported for ECS instances of the classic network type.</description></item>
            /// <item><description><b>1007</b>: The running command is manually stopped.</description></item>
            /// <item><description><b>1008</b>: Cloud Assistant is not installed. You cannot install the client.</description></item>
            /// <item><description><b>1009</b>: The command execution timed out. Try again later.</description></item>
            /// <item><description><b>1010</b>: The machine is already online. You do not need to install a client.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResuleCode")]
            [Validation(Required=false)]
            public string ResuleCode { get; set; }

            /// <summary>
            /// <para>The installation result. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><b>-1</b>: The agent is not installed.</description></item>
            /// <item><description><b>0</b>: The agent is being installed.</description></item>
            /// <item><description><b>1</b>: The agent is installed.</description></item>
            /// <item><description><b>2</b>: The installation failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public int? Result { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d123f6ae-9749-4338-8c7f-3c2c1ead****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4EB8B1C-1DEC-5E18-BCD0-D1BBB3936FA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
