// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetAppJVMConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Valid values: 2XX: The request is successful. 3XX: A redirection message is returned. 4XX: The request is invalid. 5XX: A server error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The list of JVM information.</para>
        /// </summary>
        [NameInMap("JvmInfoList")]
        [Validation(Required=false)]
        public List<GetAppJVMConfigResponseBodyJvmInfoList> JvmInfoList { get; set; }
        public class GetAppJVMConfigResponseBodyJvmInfoList : TeaModel {
            /// <summary>
            /// <para>The version of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.7.0-SNAPSHOT_3.0.3_3756244</para>
            /// </summary>
            [NameInMap("AgentVersion")]
            [Validation(Required=false)]
            public string AgentVersion { get; set; }

            /// <summary>
            /// <para>The hostname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>host_name</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.91.59.244</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dsv9zcel92@1455182510c5369</para>
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// <para>The process ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProcId")]
            [Validation(Required=false)]
            public string ProcId { get; set; }

            /// <summary>
            /// <para>The VM parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[-javaagent:/home/admin/.opt/ArmsAgent/arms-bootstrap-1.7.0-SNAPSHOT.jar, -Doneagent.plugin.arms-agent.enabled=true, -Darms.licenseKey=[******], -Darms.agent.env=K8s, -Darms.agent.podinfo.path=/etc/podinfo, -Darms.appName=productservice, -Doneagent.region=cn-hangzhou, -Dproject.name=Product]</para>
            /// </summary>
            [NameInMap("VmArgs")]
            [Validation(Required=false)]
            public string VmArgs { get; set; }

        }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>message</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A9C645C-C83F-4C9D-8CCB-29BEC9E1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
