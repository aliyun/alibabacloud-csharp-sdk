// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetJobTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The default version number currently in use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DefaultVersion")]
        [Validation(Required=false)]
        public int? DefaultVersion { get; set; }

        /// <summary>
        /// <para>The description of the task template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job template description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the template was created.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-08T14:17:55Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the template was last modified.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-03-03T05:48:02Z</para>
        /// </summary>
        [NameInMap("GmtModifyTime")]
        [Validation(Required=false)]
        public string GmtModifyTime { get; set; }

        /// <summary>
        /// <para>The most recent time when a task was successfully created by using this template. This parameter is not returned if the template has not been used.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-03T11:30:00Z</para>
        /// </summary>
        [NameInMap("LastUsedTime")]
        [Validation(Required=false)]
        public string LastUsedTime { get; set; }

        /// <summary>
        /// <para>The custom key-value pair metadata defined by the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// <para>The ID of the user who last modified the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20**************26</para>
        /// </summary>
        [NameInMap("ModifiedBy")]
        [Validation(Required=false)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// <para>The ID of the request. This ID is used for diagnostics and troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the task template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tplmceolmf2****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

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
        /// <para>The ID of the tenant to which the template belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>142388383837****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The total number of versions. If a single version is queried, the value 1 is returned. If all versions are queried, the actual total number is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The ID of the user who created the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20**************26</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The list of template version details. If a single version is queried, one element is returned. If all versions are queried, all elements are returned.</para>
        /// </summary>
        [NameInMap("Versions")]
        [Validation(Required=false)]
        public List<GetJobTemplateResponseBodyVersions> Versions { get; set; }
        public class GetJobTemplateResponseBodyVersions : TeaModel {
            /// <summary>
            /// <para>The field constraint rules. The key is a JSONPath expression, and the value is the constraint type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;JobSpecs[0].Image\&quot;:\&quot;locked\&quot;,\&quot;UserCommand\&quot;:\&quot;locked\&quot;,\&quot;JobType\&quot;:\&quot;locked\&quot;}</para>
            /// </summary>
            [NameInMap("Constraints")]
            [Validation(Required=false)]
            public Dictionary<string, object> Constraints { get; set; }

            /// <summary>
            /// <para>The template configuration content of this version in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;WorkspaceId\&quot;:\&quot;15****05\&quot;,\&quot;JobType\&quot;:\&quot;PyTorchJob\&quot;,\&quot;UserCommand\&quot;:\&quot;echo hello\&quot;,\&quot;JobSpecs\&quot;:[{\&quot;Type\&quot;:\&quot;Worker\&quot;,\&quot;PodCount\&quot;:1,\&quot;Image\&quot;:\&quot;dsw-registry-vpc.cn-hangzhou.cr.aliyuncs.com/pai/pytorch:2.8.0-gpu-py313-cu129-ubuntu22.04-3995b779-1764361782\&quot;,\&quot;EcsSpec\&quot;:\&quot;ecs.gn7i-c8g1.2xlarge\&quot;}],\&quot;ResourceType\&quot;:\&quot;ECS\&quot;,\&quot;_ResourcePaymentType\&quot;:\&quot;PostPaid\&quot;,\&quot;CredentialConfig\&quot;:{\&quot;EnableCredentialInject\&quot;:false},\&quot;Accessibility\&quot;:\&quot;PRIVATE\&quot;,\&quot;Settings\&quot;:{\&quot;JobReservedMinutes\&quot;:0,\&quot;Tags\&quot;:{}}}</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public object Content { get; set; }

            /// <summary>
            /// <para>The ID of the user who created the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20**************26</para>
            /// </summary>
            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <para>The time when the version was created.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-08T14:17:55Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        /// <summary>
        /// <para>The ID of the workspace to which the template belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4***9</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
