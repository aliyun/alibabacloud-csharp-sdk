// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyPushAllTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the security check task execution.</para>
        /// </summary>
        [NameInMap("PushTaskRsp")]
        [Validation(Required=false)]
        public ModifyPushAllTaskResponseBodyPushTaskRsp PushTaskRsp { get; set; }
        public class ModifyPushAllTaskResponseBodyPushTaskRsp : TeaModel {
            /// <summary>
            /// <para>The information about the servers on which the security check task failed.</para>
            /// </summary>
            [NameInMap("PushTaskResultList")]
            [Validation(Required=false)]
            public List<ModifyPushAllTaskResponseBodyPushTaskRspPushTaskResultList> PushTaskResultList { get; set; }
            public class ModifyPushAllTaskResponseBodyPushTaskRspPushTaskResultList : TeaModel {
                /// <summary>
                /// <para>The ID of the server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>226</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// <para>The ID of the server instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-wz9f7wlklxqnvdk****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestInstance</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The IP address of the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127.136.XX.XX</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The details about the security check task failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>successful</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>Indicates whether the Security Center agent is online. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The agent is online.</description></item>
                /// <item><description><b>false</b>: The agent is offline.</description></item>
                /// </list>
                /// <remarks>
                /// <para>If the agent is offline, Security Center cannot provide security protection for the server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Online")]
                [Validation(Required=false)]
                public bool? Online { get; set; }

                /// <summary>
                /// <para>The operating system version of the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>linux</para>
                /// </summary>
                [NameInMap("OsVersion")]
                [Validation(Required=false)]
                public string OsVersion { get; set; }

                /// <summary>
                /// <para>The region where the server is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>Indicates whether the security check was successful. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The security check was successful.</description></item>
                /// <item><description><b>false</b>: The security check failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

                /// <summary>
                /// <para>The UUID of the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5493fe42-61f5-4627-9aa2-8c449bbe****</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91EB4AC7-7FEF-4C72-BE49-4414E459AEC2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
