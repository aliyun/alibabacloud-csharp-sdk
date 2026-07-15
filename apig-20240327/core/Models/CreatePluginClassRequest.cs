// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreatePluginClassRequest : TeaModel {
        /// <summary>
        /// <para>The alias of the plugin.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My Wasm Plugin</para>
        /// </summary>
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <para>The description of the plugin.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom authentication plugin for validating tokens in request headers</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The execution priority of the plugin.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("executePriority")]
        [Validation(Required=false)]
        public int? ExecutePriority { get; set; }

        /// <summary>
        /// <para>The execution stage of the plugin.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUTHN</para>
        /// </summary>
        [NameInMap("executeStage")]
        [Validation(Required=false)]
        public string ExecuteStage { get; set; }

        /// <summary>
        /// <para>The name of the plugin class.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-wasm-plugin</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The minimum gateway version that the plugin is compatible with.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.0</para>
        /// </summary>
        [NameInMap("supportedMinGatewayVersion")]
        [Validation(Required=false)]
        public string SupportedMinGatewayVersion { get; set; }

        /// <summary>
        /// <para>The version number of the plugin.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The description of the current version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Initial version with basic token validation</para>
        /// </summary>
        [NameInMap("versionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// <para>The programming language used to develop the WASM plugin.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Rust</para>
        /// </summary>
        [NameInMap("wasmLanguage")]
        [Validation(Required=false)]
        public string WasmLanguage { get; set; }

        /// <summary>
        /// <para>The download URL of the WASM plugin binary file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/plugins/my-plugin.wasm">https://example.com/plugins/my-plugin.wasm</a></para>
        /// </summary>
        [NameInMap("wasmUrl")]
        [Validation(Required=false)]
        public string WasmUrl { get; set; }

    }

}
