// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class UpdateTaskAttributeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoApply")]
        [Validation(Required=false)]
        public bool? AutoApply { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoDestroy")]
        [Validation(Required=false)]
        public bool? AutoDestroy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("groupInfo")]
        [Validation(Required=false)]
        public UpdateTaskAttributeRequestGroupInfo GroupInfo { get; set; }
        public class UpdateTaskAttributeRequestGroupInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>g-433aead7560571e66e31274ffd3</para>
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>p-433aead75605713865c386cb9d</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

        }

        [NameInMap("initModuleState")]
        [Validation(Required=false)]
        public bool? InitModuleState { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mod-148e7853433574fff6b316f4eb737e</para>
        /// </summary>
        [NameInMap("moduleId")]
        [Validation(Required=false)]
        public string ModuleId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("moduleVersion")]
        [Validation(Required=false)]
        public string ModuleVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Parameters { get; set; }

        [NameInMap("protectionStrategy")]
        [Validation(Required=false)]
        public List<string> ProtectionStrategy { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ramRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        [NameInMap("skipPropertyValidation")]
        [Validation(Required=false)]
        public bool? SkipPropertyValidation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.2.6</para>
        /// </summary>
        [NameInMap("terraformVersion")]
        [Validation(Required=false)]
        public string TerraformVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("triggerStrategy")]
        [Validation(Required=false)]
        public string TriggerStrategy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("triggerValue")]
        [Validation(Required=false)]
        public string TriggerValue { get; set; }

    }

}
