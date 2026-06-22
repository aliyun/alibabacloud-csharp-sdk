// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAgentInstallStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of server statuses.</para>
        /// </summary>
        [NameInMap("AegisClientInvokeStatusResponseList")]
        [Validation(Required=false)]
        public List<DescribeAgentInstallStatusResponseBodyAegisClientInvokeStatusResponseList> AegisClientInvokeStatusResponseList { get; set; }
        public class DescribeAgentInstallStatusResponseBodyAegisClientInvokeStatusResponseList : TeaModel {
            /// <summary>
            /// <para>The message returned for the request result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uninstalled</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The status code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>-1</b>: Not installed.</description></item>
            /// <item><description><b>0</b>: Installed.</description></item>
            /// <item><description><b>1</b>: Failed to create the client directory.</description></item>
            /// <item><description><b>2</b>: Failed to download the installation package.</description></item>
            /// <item><description><b>3</b>: The installation file does not exist.</description></item>
            /// <item><description><b>4</b>: The installation file verification information does not exist.</description></item>
            /// <item><description><b>5</b>: The installation file failed verification.</description></item>
            /// <item><description><b>6</b>: Failed to execute the installation file.</description></item>
            /// <item><description><b>7</b>: Installation failed due to insufficient permissions.</description></item>
            /// <item><description><b>8</b>: The client process was not detected.</description></item>
            /// <item><description><b>100</b>: Installation failed due to an unknown error.</description></item>
            /// <item><description><b>1001</b>: Installation failed. One-click client installation is not supported in this region.</description></item>
            /// <item><description><b>1002</b>: Installation failed. Non-cloud hosts are not supported. Run the installation script on the server.</description></item>
            /// <item><description><b>1003</b>: Installation failed. The operating system type is not supported.</description></item>
            /// <item><description><b>1004</b>: Internal error. Try again later.</description></item>
            /// <item><description><b>1005</b>: The ECS instance is not running. Start the ECS instance and try again.</description></item>
            /// <item><description><b>1006</b>: One-click client installation is not supported for ECS instances in the classic network.</description></item>
            /// <item><description><b>1007</b>: The command process was manually stopped.</description></item>
            /// <item><description><b>1008</b>: Cloud Assistant is not installed. The client cannot be installed.</description></item>
            /// <item><description><b>1009</b>: Command execution timed out. Try again later.</description></item>
            /// <item><description><b>1010</b>: The server is already online. Client installation is not required.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("ResuleCode")]
            [Validation(Required=false)]
            public string ResuleCode { get; set; }

            /// <summary>
            /// <para>The status result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>-1</b>: not installed</description></item>
            /// <item><description><b>0</b>: installing</description></item>
            /// <item><description><b>1</b>: installed</description></item>
            /// <item><description><b>2</b>: installation failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
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
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4EB8B1C-1DEC-5E18-BCD0-D1BBB3936FA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
