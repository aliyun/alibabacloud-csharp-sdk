// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class UpdateJobTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The field constraint rules. The key is a JSONPath expression and the value is the constraint type: locked (cannot be overridden), overridable (can be overridden), or required (mandatory). Must be provided together with Content. You cannot update this field independently.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;JobSpecs[0].Image\&quot;:\&quot;locked\&quot;,\&quot;UserCommand\&quot;:\&quot;locked\&quot;,\&quot;JobType\&quot;:\&quot;locked\&quot;}</para>
        /// </summary>
        [NameInMap("Constraints")]
        [Validation(Required=false)]
        public Dictionary<string, object> Constraints { get; set; }

        /// <summary>
        /// <para>The configuration content of the task template. Supports all parameter fields of the CreateJob operation, passed in JSON format. Providing this field creates a new version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;WorkspaceId\&quot;:\&quot;15****05\&quot;,\&quot;JobType\&quot;:\&quot;PyTorchJob\&quot;,\&quot;UserCommand\&quot;:\&quot;echo hello\&quot;,\&quot;JobSpecs\&quot;:[{\&quot;Type\&quot;:\&quot;Worker\&quot;,\&quot;PodCount\&quot;:1,\&quot;Image\&quot;:\&quot;dsw-registry-vpc.cn-hangzhou.cr.aliyuncs.com/pai/pytorch:2.8.0-gpu-py313-cu129-ubuntu22.04-3995b779-1764361782\&quot;,\&quot;EcsSpec\&quot;:\&quot;ecs.gn7i-c8g1.2xlarge\&quot;}],\&quot;ResourceType\&quot;:\&quot;ECS\&quot;,\&quot;_ResourcePaymentType\&quot;:\&quot;PostPaid\&quot;,\&quot;CredentialConfig\&quot;:{\&quot;EnableCredentialInject\&quot;:false},\&quot;Accessibility\&quot;:\&quot;PRIVATE\&quot;,\&quot;Settings\&quot;:{\&quot;JobReservedMinutes\&quot;:0,\&quot;Tags\&quot;:{}}}</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The description of the task template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Template description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The user-defined key-value pair metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// <para>Specifies whether to set the new version as the default version when a new version is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SetAsDefault")]
        [Validation(Required=false)]
        public bool? SetAsDefault { get; set; }

        /// <summary>
        /// <para>The name of the task template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-template-example-1778047****</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>Invalid field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid field</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

    }

}
