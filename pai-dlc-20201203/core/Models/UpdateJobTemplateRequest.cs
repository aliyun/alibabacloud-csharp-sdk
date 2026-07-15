// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class UpdateJobTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The field constraints. The key is a JSONPath expression and the value is the constraint type. Valid values are <c>locked</c>, <c>overridable</c>, and <c>required</c>. This parameter must be specified with <c>Content</c> and cannot be updated on its own.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;JobSpecs[0].Image\&quot;:\&quot;locked\&quot;,\&quot;UserCommand\&quot;:\&quot;locked\&quot;,\&quot;JobType\&quot;:\&quot;locked\&quot;}</para>
        /// </summary>
        [NameInMap("Constraints")]
        [Validation(Required=false)]
        public Dictionary<string, object> Constraints { get; set; }

        /// <summary>
        /// <para>The configuration content of the job template. This parameter supports all fields from the <c>CreateJob</c> operation and must be in JSON format. Specifying this parameter creates a new version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;WorkspaceId\&quot;:\&quot;15****05\&quot;,\&quot;JobType\&quot;:\&quot;PyTorchJob\&quot;,\&quot;UserCommand\&quot;:\&quot;echo hello\&quot;,\&quot;JobSpecs\&quot;:[{\&quot;Type\&quot;:\&quot;Worker\&quot;,\&quot;PodCount\&quot;:1,\&quot;Image\&quot;:\&quot;dsw-registry-vpc.cn-hangzhou.cr.aliyuncs.com/pai/pytorch:2.8.0-gpu-py313-cu129-ubuntu22.04-3995b779-1764361782\&quot;,\&quot;EcsSpec\&quot;:\&quot;ecs.gn7i-c8g1.2xlarge\&quot;}],\&quot;ResourceType\&quot;:\&quot;ECS\&quot;,\&quot;_ResourcePaymentType\&quot;:\&quot;PostPaid\&quot;,\&quot;CredentialConfig\&quot;:{\&quot;EnableCredentialInject\&quot;:false},\&quot;Accessibility\&quot;:\&quot;PRIVATE\&quot;,\&quot;Settings\&quot;:{\&quot;JobReservedMinutes\&quot;:0,\&quot;Tags\&quot;:{}}}</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The description of the job template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Template description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>User-defined key-value pairs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// <para>If <c>true</c>, the new version becomes the default version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SetAsDefault")]
        [Validation(Required=false)]
        public bool? SetAsDefault { get; set; }

        /// <summary>
        /// <para>The name of the job template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-template-example-1778047****</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>This field is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无效字段</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

    }

}
