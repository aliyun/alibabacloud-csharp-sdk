// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class DescribeSandboxInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Param.NotFound</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// <list type="bullet">
        /// <item><description><b>connectionString</b>: the connection string of the sandbox instance, in the format of IP address:Port number. This parameter indicates the endpoint of the sandbox instance if the value of the SandboxType parameter is <b>Sandbox</b>. This parameter indicates the Network File System (NFS) mount address if the value of the SandboxType parameter is <b>NFS</b>.</description></item>
        /// <item><description><b>restoreSeconds</b>: the time required to create the sandbox instance. Unit: seconds.</description></item>
        /// <item><description><b>restoreTime</b>: the point in time to which the sandbox instance is restored. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.</description></item>
        /// <item><description><b>instanceId</b>: the ID of the sandbox instance.</description></item>
        /// <item><description><b>backupSetId</b>: the ID of the backup set.</description></item>
        /// <item><description><b>createTime</b>: the point in time when the sandbox instance was created. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.</description></item>
        /// <item><description><b>backupPlanId</b>: the ID of the backup schedule.</description></item>
        /// <item><description><b>vpcId</b>: the ID of the virtual private cloud (VPC).</description></item>
        /// <item><description><b>vpcSwitchId</b>: the ID of the VSwitch.</description></item>
        /// <item><description><b>sandboxSpecification</b>: the specifications of the sandbox instance.</description></item>
        /// <item><description><b>status</b>: the status of the sandbox instance. Valid values: <b>running</b>, <b>check_pass</b>, and <b>stop</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;number&quot;: 1,     &quot;size&quot;: 1,     &quot;content&quot;: [       {         &quot;connectionString&quot;: &quot;172.26.178.229:3306&quot;,         &quot;restoreSeconds&quot;: 15,         &quot;restoreTime&quot;: &quot;2021-08-11T07:26:24Z&quot;,         &quot;instanceId&quot;: &quot;1jxxxxx9xxxms&quot;,         &quot;backupSetId&quot;: &quot;1hxxxx8xxxxxa_20210811152624&quot;,         &quot;createTime&quot;: &quot;2021-08-12T07:40:29Z&quot;,         &quot;backupPlanId&quot;: &quot;1hxxxx8xxxxxa&quot;,         &quot;vpcId&quot;: &quot;vpc-bp1dxxxxxjy0xxxxx1xxp&quot;,         &quot;sandboxSpecification&quot;: &quot;MYSQL_1C_1M_SD&quot;,         &quot;status&quot;: &quot;running&quot;,         &quot;vpcSwitchId&quot;: &quot;vsw-bp1bxxxxxumxxxxxwxx2w&quot;       }     ],     &quot;totalElements&quot;: 1   }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Param.NotFound</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter %s value is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter %s value is not valid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F1888AC-1138-4995-B9FE-D2734F61C058</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
