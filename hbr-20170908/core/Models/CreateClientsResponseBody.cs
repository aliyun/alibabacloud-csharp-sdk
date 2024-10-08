// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateClientsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The status of the ECS instance. If you specify more than one instance IDs in the request and the status of an ECS instance does not meet the requirements to install an HBR client, an error message is returned based on the value of this parameter.</para>
        /// </summary>
        [NameInMap("InstanceStatuses")]
        [Validation(Required=false)]
        public CreateClientsResponseBodyInstanceStatuses InstanceStatuses { get; set; }
        public class CreateClientsResponseBodyInstanceStatuses : TeaModel {
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public List<CreateClientsResponseBodyInstanceStatusesInstanceStatus> InstanceStatus { get; set; }
            public class CreateClientsResponseBodyInstanceStatusesInstanceStatus : TeaModel {
                /// <summary>
                /// <para>The ID of the ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-2zegp3cdu******uj9i</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Indicates whether an HBR client can be installed on the ECS instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: An HBR client can be installed on the ECS instance.</description></item>
                /// <item><description>false: An HBR client cannot be installed on the ECS instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ValidInstance")]
                [Validation(Required=false)]
                public bool? ValidInstance { get; set; }

            }

        }

        /// <summary>
        /// <para>The message that is returned. If the call is successful, &quot;successful&quot; is returned. If the call fails, an error message is returned.</para>
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
        /// <para>4A8A9AE4-F798-5E6D-853E-10F9F5A1BD4E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the asynchronous job. You can call the DescribeTask operation to query the execution result of an asynchronous job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-000h9x5t02vhyksf1x7k</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
