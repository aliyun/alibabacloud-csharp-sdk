// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class GetApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the application.</para>
        /// </summary>
        [NameInMap("Application")]
        [Validation(Required=false)]
        public GetApplicationResponseBodyApplication Application { get; set; }
        public class GetApplicationResponseBodyApplication : TeaModel {
            /// <summary>
            /// <para>The description of the application.</para>
            /// </summary>
            [NameInMap("AppDescription")]
            [Validation(Required=false)]
            public string AppDescription { get; set; }

            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443d638a-ef76-47c4-b707-61197d******</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The ID of the basic application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ee99cce6-1c8e-4bfa-96c3-3e2fa9******</para>
            /// </summary>
            [NameInMap("BaseAppId")]
            [Validation(Required=false)]
            public string BaseAppId { get; set; }

            /// <summary>
            /// <para>The CPU specifications that are required for each instance. Unit: millicores. This parameter cannot be set to 0. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>500</b></description></item>
            /// <item><description><b>1000</b></description></item>
            /// <item><description><b>2000</b></description></item>
            /// <item><description><b>4000</b></description></item>
            /// <item><description><b>8000</b></description></item>
            /// <item><description><b>12000</b></description></item>
            /// <item><description><b>16000</b></description></item>
            /// <item><description><b>32000</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The number of application instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-8ps2o182102o1jv05bys</para>
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public int? Instances { get; set; }

            /// <summary>
            /// <para>The memory size that is required by each instance. Unit: MB. This parameter cannot be set to 0. The values of this parameter correspond to the values of the Cpu parameter:</para>
            /// <list type="bullet">
            /// <item><description>This parameter is set to <b>1024</b> if the Cpu parameter is set to 500 or 1000.</description></item>
            /// <item><description>This parameter is set to <b>2048</b> if the Cpu parameter is set to 500, 1000, or 2000.</description></item>
            /// <item><description>This parameter is set to <b>4096</b> if the Cpu parameter is set to 1000, 2000, or 4000.</description></item>
            /// <item><description>This parameter is set to <b>8192</b> if the Cpu parameter is set to 2000, 4000, or 8000.</description></item>
            /// <item><description>This parameter is set to <b>12288</b> if the Cpu parameter is set to 12000.</description></item>
            /// <item><description>This parameter is set to <b>16384</b> if the Cpu parameter is set to 4000, 8000, or 16000.</description></item>
            /// <item><description>This parameter is set to <b>24576</b> if the Cpu parameter is set to 12000.</description></item>
            /// <item><description>This parameter is set to <b>32768</b> if the Cpu parameter is set to 16000.</description></item>
            /// <item><description>This parameter is set to <b>65536</b> if the Cpu parameter is set to 8000, 16000, or 32000.</description></item>
            /// <item><description>This parameter is set to <b>131072</b> if the Cpu parameter is set to 32000.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4096</para>
            /// </summary>
            [NameInMap("Mem")]
            [Validation(Required=false)]
            public int? Mem { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable WebAssembly Filter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables this parameter.</description></item>
            /// <item><description>false: disables this parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MseEnabled")]
            [Validation(Required=false)]
            public bool? MseEnabled { get; set; }

            /// <summary>
            /// <para>The ID of the namespace to which the MSE instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("MseNamespaceId")]
            [Validation(Required=false)]
            public string MseNamespaceId { get; set; }

            /// <summary>
            /// <para>The namespace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The programming language that is used to create the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>java</b> :Java.</description></item>
            /// <item><description><b>php</b>: PHP.</description></item>
            /// <item><description><b>other</b>: other programming languages, such as Python, C++, Go, .NET, and Node.js</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>java</para>
            /// </summary>
            [NameInMap("ProgrammingLanguage")]
            [Validation(Required=false)]
            public string ProgrammingLanguage { get; set; }

            /// <summary>
            /// <para>The number of application instances that are running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RunningInstances")]
            [Validation(Required=false)]
            public int? RunningInstances { get; set; }

            /// <summary>
            /// <para>Indicates whether the auto scaling policy is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The auto scaling policy is enabled.</description></item>
            /// <item><description><b>false</b>: The auto scaling policy is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ScaleRuleEnabled")]
            [Validation(Required=false)]
            public string ScaleRuleEnabled { get; set; }

            /// <summary>
            /// <para>The type of the auto scaling policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>timing</b>: a scheduled auto scaling policy.</description></item>
            /// <item><description><b>metric</b>: a metric-based auto scaling policy.</description></item>
            /// <item><description><b>mix</b>: a hybrid auto scaling policy.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>timing</para>
            /// </summary>
            [NameInMap("ScaleRuleType")]
            [Validation(Required=false)]
            public string ScaleRuleType { get; set; }

        }

        /// <summary>
        /// <para>The additional information returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>When a request is successful, <b>success</b>is returned.</description></item>
        /// <item><description>An error code is returned when a request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01CF26C7-00A3-4AA6-BA76-7E95F2A3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the trace. The ID is used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac1a0b2215622920113732501e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
