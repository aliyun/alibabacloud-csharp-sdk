// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetPluginsResponseBody : TeaModel {
        /// <summary>
        /// <para>The code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetPluginsResponseBodyData> Data { get; set; }
        public class GetPluginsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The plug-in type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Custom.</description></item>
            /// <item><description>1: Authentication and authorization.</description></item>
            /// <item><description>2: Security protection.</description></item>
            /// <item><description>3: Transport protocol.</description></item>
            /// <item><description>4: Traffic control.</description></item>
            /// <item><description>5: Traffic observability.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            /// <summary>
            /// <para>The configuration validation.</para>
            /// 
            /// <b>Example:</b>
            /// <h1>Validate required fields in the configuration. As shown in the following example, the plug-in configuration must contain the &quot;name&quot;, &quot;age&quot;, and &quot;friends&quot; fields.</h1>
            /// <para>name: John
            /// age: 18
            /// friends:</para>
            /// <list type="bullet">
            /// <item><description>David</description></item>
            /// <item><description>Anne</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ConfigCheck")]
            [Validation(Required=false)]
            public string ConfigCheck { get; set; }

            /// <summary>
            /// <para>The plug-in ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The latest version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("MaxVersion")]
            [Validation(Required=false)]
            public string MaxVersion { get; set; }

            /// <summary>
            /// <para>The plug-in language. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Wasm plug-in.</description></item>
            /// <item><description>2: Lua plug-in.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            /// <summary>
            /// <para>The name of the plug-in.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-auth</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether the latest version is being published.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NewVersionPublishingFlag")]
            [Validation(Required=false)]
            public bool? NewVersionPublishingFlag { get; set; }

            /// <summary>
            /// <para>The plug-in execution phase. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Default phase.</description></item>
            /// <item><description>1: Authentication phase.</description></item>
            /// <item><description>2: Authorization phase.</description></item>
            /// <item><description>3: Statistics phase.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public int? Phase { get; set; }

            /// <summary>
            /// <para>The ID of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("PrimaryUser")]
            [Validation(Required=false)]
            public string PrimaryUser { get; set; }

            /// <summary>
            /// <para>The execution priority of the plug-in. A larger value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The publish status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Successful.</description></item>
            /// <item><description>1: Publishing.</description></item>
            /// <item><description>2: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PublishState")]
            [Validation(Required=false)]
            public int? PublishState { get; set; }

            /// <summary>
            /// <para>The enabling status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Disabled.</description></item>
            /// <item><description>1: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The plug-in summary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a plug-in</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>The English plug-in summary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Authentication based on API Key.</para>
            /// </summary>
            [NameInMap("SummaryEn")]
            [Validation(Required=false)]
            public string SummaryEn { get; set; }

            /// <summary>
            /// <para>The plug-in version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The OSS object of the Wasm plug-in.</para>
            /// </summary>
            [NameInMap("WasmFile")]
            [Validation(Required=false)]
            public string WasmFile { get; set; }

            /// <summary>
            /// <para>The WebAssembly (Wasm) implementation language. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: C++.</description></item>
            /// <item><description>1: TinyGo.</description></item>
            /// <item><description>2: Rust.</description></item>
            /// <item><description>3: AssemblyScript.</description></item>
            /// <item><description>4: Zig.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WasmLang")]
            [Validation(Required=false)]
            public int? WasmLang { get; set; }

        }

        /// <summary>
        /// <para>The placeholder in the dynamic error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>message</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
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
        /// <para>03A3E2F4-6804-5663-9D5D-2EC47A1*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
