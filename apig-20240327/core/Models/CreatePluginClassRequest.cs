// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreatePluginClassRequest : TeaModel {
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("executePriority")]
        [Validation(Required=false)]
        public int? ExecutePriority { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("executeStage")]
        [Validation(Required=false)]
        public string ExecuteStage { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("supportedMinGatewayVersion")]
        [Validation(Required=false)]
        public string SupportedMinGatewayVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("versionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("wasmLanguage")]
        [Validation(Required=false)]
        public string WasmLanguage { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("wasmUrl")]
        [Validation(Required=false)]
        public string WasmUrl { get; set; }

    }

}
