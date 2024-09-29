// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListTraceAppsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned for the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>2XX</c>: The request is successful.</description></item>
        /// <item><description><c>3XX</c>: A redirection message is returned.</description></item>
        /// <item><description><c>4XX</c>: The request is invalid.</description></item>
        /// <item><description><c>5XX</c>: A server error occurs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The error message returned if the request parameters are invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internal error. Please try again. Contact the DingTalk service account if the issue persists after multiple retries.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40B10E04-81E8-4643-970D-F1B38F2E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The call was successful.</description></item>
        /// <item><description><c>false</c>: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The list of Application Monitoring tasks.</para>
        /// </summary>
        [NameInMap("TraceApps")]
        [Validation(Required=false)]
        public List<ListTraceAppsResponseBodyTraceApps> TraceApps { get; set; }
        public class ListTraceAppsResponseBodyTraceApps : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-app</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc7a37ee31aea4ed1a059eff8034b****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The time when the monitoring task was created. The value is a timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1529667762000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The labels of the application.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }

            /// <summary>
            /// <para>The language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PHP</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The process identifier (PID) of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a5f9bdeb-2627-4dbe-9247-****</para>
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Resource group</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Indicates whether the application is displayed in the Application Real-Time Monitoring Service (ARMS) console. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: yes</description></item>
            /// <item><description><c>false</c>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Show")]
            [Validation(Required=false)]
            public bool? Show { get; set; }

            /// <summary>
            /// <para>The application source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACK</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTraceAppsResponseBodyTraceAppsTags> Tags { get; set; }
            public class ListTraceAppsResponseBodyTraceAppsTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type of the monitoring task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>TRACE</c>: Application Monitoring</description></item>
            /// <item><description><c>RETCODE</c>: Browser Monitoring</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TRACE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The time when the monitoring task was updated. The value is a timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1529667762000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>113197164949****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The type of the workload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Deployment</para>
            /// </summary>
            [NameInMap("WorkloadKind")]
            [Validation(Required=false)]
            public string WorkloadKind { get; set; }

            /// <summary>
            /// <para>The name of the workload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nginx-deployment</para>
            /// </summary>
            [NameInMap("WorkloadName")]
            [Validation(Required=false)]
            public string WorkloadName { get; set; }

        }

    }

}
