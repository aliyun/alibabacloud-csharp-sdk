// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateExplorerTaskRequest : TeaModel {
        [NameInMap("InitModuleState")]
        [Validation(Required=false)]
        public bool? InitModuleState { get; set; }

        [NameInMap("TerraformVersion")]
        [Validation(Required=false)]
        public string TerraformVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("autoApply")]
        [Validation(Required=false)]
        public bool? AutoApply { get; set; }

        [NameInMap("autoDestroy")]
        [Validation(Required=false)]
        public bool? AutoDestroy { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("moduleId")]
        [Validation(Required=false)]
        public string ModuleId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("moduleVersion")]
        [Validation(Required=false)]
        public string ModuleVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("skipPropertyValidation")]
        [Validation(Required=false)]
        public bool? SkipPropertyValidation { get; set; }

        [NameInMap("terraformProviderVersion")]
        [Validation(Required=false)]
        public string TerraformProviderVersion { get; set; }

        [NameInMap("triggerValue")]
        [Validation(Required=false)]
        public string TriggerValue { get; set; }

    }

}
