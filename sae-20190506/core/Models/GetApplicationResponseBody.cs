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
            /// <para>The application description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
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
            /// <para>The base application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ee99cce6-1c8e-4bfa-96c3-3e2fa9******</para>
            /// </summary>
            [NameInMap("BaseAppId")]
            [Validation(Required=false)]
            public string BaseAppId { get; set; }

            /// <summary>
            /// <para>The CPU required for each instance, in millicores. This value cannot be 0. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>500</b></para>
            /// </description></item>
            /// <item><description><para><b>1000</b></para>
            /// </description></item>
            /// <item><description><para><b>2000</b></para>
            /// </description></item>
            /// <item><description><para><b>4000</b></para>
            /// </description></item>
            /// <item><description><para><b>8000</b></para>
            /// </description></item>
            /// <item><description><para><b>12000</b></para>
            /// </description></item>
            /// <item><description><para><b>16000</b></para>
            /// </description></item>
            /// <item><description><para><b>32000</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The total number of application instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public int? Instances { get; set; }

            /// <summary>
            /// <para>Indicates whether the application is stateful.</para>
            /// </summary>
            [NameInMap("IsStateful")]
            [Validation(Required=false)]
            public bool? IsStateful { get; set; }

            /// <summary>
            /// <para>The memory required for each instance, in MB. This value cannot be 0. The memory specification is coupled with the CPU specification. The following configurations are supported:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1024</b>: corresponds to 500 or 1,000 millicores of CPU.</para>
            /// </description></item>
            /// <item><description><para><b>2048</b>: corresponds to 500, 1,000, or 2,000 millicores of CPU.</para>
            /// </description></item>
            /// <item><description><para><b>4096</b>: corresponds to 1,000, 2,000, or 4,000 millicores of CPU.</para>
            /// </description></item>
            /// <item><description><para><b>8192</b>: corresponds to 2,000, 4,000, or 8,000 millicores of CPU.</para>
            /// </description></item>
            /// <item><description><para><b>12288</b>: corresponds to 12,000 millicores of CPU.</para>
            /// </description></item>
            /// <item><description><para><b>16384</b>: corresponds to 4,000, 8,000, or 16,000 millicores of CPU.</para>
            /// </description></item>
            /// <item><description><para><b>24576</b>: corresponds to 12,000 millicores of CPU.</para>
            /// </description></item>
            /// <item><description><para><b>32768</b>: corresponds to 16,000 millicores of CPU.</para>
            /// </description></item>
            /// <item><description><para><b>65536</b>: corresponds to 8,000, 16,000, or 32,000 millicores of CPU.</para>
            /// </description></item>
            /// <item><description><para><b>131072</b>: corresponds to 32,000 millicores of CPU.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4096</para>
            /// </summary>
            [NameInMap("Mem")]
            [Validation(Required=false)]
            public int? Mem { get; set; }

            /// <summary>
            /// <para>Indicates whether WebAssemblyFilter is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MseEnabled")]
            [Validation(Required=false)]
            public bool? MseEnabled { get; set; }

            /// <summary>
            /// <para>The namespace ID of the MSE instance.</para>
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
            /// <para>The programming language of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>java</b>: Java.</para>
            /// </description></item>
            /// <item><description><para><b>php</b>: PHP.</para>
            /// </description></item>
            /// <item><description><para><b>other</b>: other languages, such as Python, C++, Go, .NET, and Node.js.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>java</para>
            /// </summary>
            [NameInMap("ProgrammingLanguage")]
            [Validation(Required=false)]
            public string ProgrammingLanguage { get; set; }

            /// <summary>
            /// <para>The number of running instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("RunningInstances")]
            [Validation(Required=false)]
            public int? RunningInstances { get; set; }

            /// <summary>
            /// <para>Indicates whether the auto scaling policy is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The policy is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The policy is disabled.</para>
            /// </description></item>
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
            /// <item><description><para><b>timing</b>: scheduled auto scaling.</para>
            /// </description></item>
            /// <item><description><para><b>metric</b>: metric-based auto scaling.</para>
            /// </description></item>
            /// <item><description><para><b>mix</b>: hybrid auto scaling.</para>
            /// </description></item>
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
        /// <para>The response message.</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, the value is <b>success</b>.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, the value is a specific error code.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01CF26C7-00A3-4AA6-BA76-7E95F2A3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The trace ID used to query the details of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac1a0b2215622920113732501e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
