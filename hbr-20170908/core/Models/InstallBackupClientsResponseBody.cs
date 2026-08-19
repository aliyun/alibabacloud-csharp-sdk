// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class InstallBackupClientsResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates that the operation is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The status of the ECS instances.</para>
        /// </summary>
        [NameInMap("InstanceStatuses")]
        [Validation(Required=false)]
        public List<InstallBackupClientsResponseBodyInstanceStatuses> InstanceStatuses { get; set; }
        public class InstallBackupClientsResponseBodyInstanceStatuses : TeaModel {
            /// <summary>
            /// <para>The error code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>An empty value indicates that the operation is successful.</para>
            /// </description></item>
            /// <item><description><para><b>InstanceNotExists</b>: The ECS instance does not exist.</para>
            /// </description></item>
            /// <item><description><para><b>InstanceNotRunning</b>: The ECS instance is not in the Running state.</para>
            /// </description></item>
            /// <item><description><para><b>CloudAssistNotRunningOnInstance</b>: Cloud Assistant is not available.</para>
            /// </description></item>
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
            /// <item><description><para>true: The backup client can be installed.</para>
            /// </description></item>
            /// <item><description><para>false: The backup client cannot be installed.</para>
            /// </description></item>
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
        /// <para>The message that is returned. If the request is successful, successful is returned. If the request fails, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
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
        /// <item><description><para>true: The request is successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the asynchronous task. Call the DescribeTask operation to query the task result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-*********************</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
