// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class PluginClassInfo : TeaModel {
        /// <summary>
        /// <para>The plugin class alias.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI安全护栏</para>
        /// </summary>
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <para>The configuration example (JSON string).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;checkRequest&quot;:true}</para>
        /// </summary>
        [NameInMap("configExample")]
        [Validation(Required=false)]
        public string ConfigExample { get; set; }

        /// <summary>
        /// <para>The plugin class description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI请求内容安全检测插件</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The execution priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("executePriority")]
        [Validation(Required=false)]
        public int? ExecutePriority { get; set; }

        /// <summary>
        /// <para>The execution stage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUTHN</para>
        /// </summary>
        [NameInMap("executeStage")]
        [Validation(Required=false)]
        public string ExecuteStage { get; set; }

        /// <summary>
        /// <para>The Wasm image name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>higress-registry.tencentcloudcr.com/ai-security-guard</para>
        /// </summary>
        [NameInMap("imageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>Indicates whether the plugin is a built-in plugin.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("innerPlugin")]
        [Validation(Required=false)]
        public bool? InnerPlugin { get; set; }

        /// <summary>
        /// <para>The plugin running mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Wasm</para>
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The plugin class name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ai-security-guard</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The plugin class ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cls-xxx</para>
        /// </summary>
        [NameInMap("pluginClassId")]
        [Validation(Required=false)]
        public string PluginClassId { get; set; }

        /// <summary>
        /// <para>The plugin source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HigressOfficial</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The minimum supported gateway DPI engine version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.1.11</para>
        /// </summary>
        [NameInMap("supportedMinGatewayVersion")]
        [Validation(Required=false)]
        public string SupportedMinGatewayVersion { get; set; }

        /// <summary>
        /// <para>The plugin type category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The plugin version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The version description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>初始版本</para>
        /// </summary>
        [NameInMap("versionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// <para>The Wasm programming language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Rust</para>
        /// </summary>
        [NameInMap("wasmLanguage")]
        [Validation(Required=false)]
        public string WasmLanguage { get; set; }

        /// <summary>
        /// <para>The Wasm file download URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://...</para>
        /// </summary>
        [NameInMap("wasmUrl")]
        [Validation(Required=false)]
        public string WasmUrl { get; set; }

    }

}
