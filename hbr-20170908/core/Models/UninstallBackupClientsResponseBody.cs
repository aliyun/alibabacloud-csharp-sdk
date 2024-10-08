// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UninstallBackupClientsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The status of the ECS instance.</para>
        /// </summary>
        [NameInMap("InstanceStatuses")]
        [Validation(Required=false)]
        public List<UninstallBackupClientsResponseBodyInstanceStatuses> InstanceStatuses { get; set; }
        public class UninstallBackupClientsResponseBodyInstanceStatuses : TeaModel {
            /// <summary>
            /// <para>The error code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If the value is empty, the request is successful.</description></item>
            /// <item><description><b>InstanceNotExists</b>: The ECS instance does not exist.</description></item>
            /// <item><description><b>InstanceNotRunning</b>: The ECS instance is not running.</description></item>
            /// <item><description><b>CloudAssistNotRunningOnInstance</b>: Cloud Assistant is unavailable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InstanceNotExists</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The ID of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-0xi5w***v3j3bh2gj5</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Indicates whether a backup client can be installed on the ECS instance.</para>
            /// <list type="bullet">
            /// <item><description>true: A backup client can be installed on the ECS instance.</description></item>
            /// <item><description>false: A backup client cannot be installed on the ECS instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ValidInstance")]
            [Validation(Required=false)]
            public bool? ValidInstance { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned. If the request is successful, a value of successful is returned. If the request fails, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the asynchronous job. You can call the DescribeTask operation to query the execution result of the asynchronous job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-*********************</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
