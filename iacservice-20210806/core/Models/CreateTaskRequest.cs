// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateTaskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically execute the node. Default value: false.</para>
        /// <list type="bullet">
        /// <item><description>true: After the preview is complete (terraform plan), the execution (terraform apply) is automatically performed without manual confirmation.</description></item>
        /// <item><description>false: After the preview is complete (terraform plan), manual confirmation is required before the execution (terraform apply) starts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("autoApply")]
        [Validation(Required=false)]
        public bool? AutoApply { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically destroy resources after creation. Default value: false.</para>
        /// <list type="bullet">
        /// <item><description>true: After the execution is complete (terraform apply), the destroy operation (terraform destroy) is automatically performed without manual confirmation.</description></item>
        /// <item><description>false: After the execution is complete (terraform apply), no further action is taken.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoDestroy")]
        [Validation(Required=false)]
        public bool? AutoDestroy { get; set; }

        /// <summary>
        /// <para>The idempotency token. Format: [0-9a-zA-Z-]{1,64}. We recommend that you use a UUID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a65451293e64979ba7a4b573950217fe</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The project group information.</para>
        /// </summary>
        [NameInMap("groupInfo")]
        [Validation(Required=false)]
        public CreateTaskRequestGroupInfo GroupInfo { get; set; }
        public class CreateTaskRequestGroupInfo : TeaModel {
            /// <summary>
            /// <para>The group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>g-5fd38c9b83a86432e2</para>
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p-433aeade5d9167608</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to use a state file. Default value: false. This parameter is applicable when the template originates from resource export. Only one node can use this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("initModuleState")]
        [Validation(Required=false)]
        public bool? InitModuleState { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mod-144fff6b316f4eb737e</para>
        /// </summary>
        [NameInMap("moduleId")]
        [Validation(Required=false)]
        public string ModuleId { get; set; }

        /// <summary>
        /// <para>The template version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("moduleVersion")]
        [Validation(Required=false)]
        public string ModuleVersion { get; set; }

        /// <summary>
        /// <para>The node name. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 128 characters in length.</description></item>
        /// <item><description>The name can contain letters, digits, Chinese characters, hyphens (-), underscores (_), and periods (.). The name cannot start or end with a hyphen, underscore, or period.</description></item>
        /// <item><description>The name must be unique among all node resources within the current account.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TaskName</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The collection of associated parameter set IDs.</para>
        /// </summary>
        [NameInMap("parameterSetIds")]
        [Validation(Required=false)]
        public List<string> ParameterSetIds { get; set; }

        /// <summary>
        /// <para>The list of resource protection strategies.</para>
        /// </summary>
        [NameInMap("protectionStrategy")]
        [Validation(Required=false)]
        public List<string> ProtectionStrategy { get; set; }

        /// <summary>
        /// <para>The RAM role. The system assumes this role to execute the template when a new job is triggered. This parameter is required when the job trigger method is not manual.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RoleName</para>
        /// </summary>
        [NameInMap("ramRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip enumeration value validation. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("skipPropertyValidation")]
        [Validation(Required=false)]
        public bool? SkipPropertyValidation { get; set; }

        [NameInMap("skipRegionValidation")]
        [Validation(Required=false)]
        public bool? SkipRegionValidation { get; set; }

        /// <summary>
        /// <para>The list of tags for the node.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CreateTaskRequestTags> Tags { get; set; }
        public class CreateTaskRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("tagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("tagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>The node backend configuration. After this parameter is configured, runtime log information is saved to the specified OSS bucket.</para>
        /// </summary>
        [NameInMap("taskBackend")]
        [Validation(Required=false)]
        public CreateTaskRequestTaskBackend TaskBackend { get; set; }
        public class CreateTaskRequestTaskBackend : TeaModel {
            /// <summary>
            /// <para>The endpoint information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ss-cn-beijing.aliyuncs.com</para>
            /// </summary>
            [NameInMap("bucketEndpoint")]
            [Validation(Required=false)]
            public string BucketEndpoint { get; set; }

            /// <summary>
            /// <para>The bucket name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iac-runtime-test</para>
            /// </summary>
            [NameInMap("bucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The object path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/log</para>
            /// </summary>
            [NameInMap("objectPath")]
            [Validation(Required=false)]
            public string ObjectPath { get; set; }

        }

        [NameInMap("terraformProviderVersion")]
        [Validation(Required=false)]
        public string TerraformProviderVersion { get; set; }

        /// <summary>
        /// <para>The Terraform version. Call the <b>ListAvailableTerraformVersions</b> operation to obtain the list of supported versions. Default value: 1.5.7.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.5.7</para>
        /// </summary>
        [NameInMap("terraformVersion")]
        [Validation(Required=false)]
        public string TerraformVersion { get; set; }

        /// <summary>
        /// <para>The job trigger method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Manual: manual trigger (default).</description></item>
        /// <item><description>NewVersion: triggered when a new template version is published.</description></item>
        /// <item><description>ParameterSetUpdated: triggered when the parameter set content changes or the parameter set attach relationship changes.</description></item>
        /// <item><description>Auto: automatically triggered when the node properties change, such as node creation, execution version change, or job trigger policy change (when changed from another value to Auto).</description></item>
        /// </list>
        /// <para>The <b>ramRole</b> parameter is required when the trigger method is not manual.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("triggerStrategy")]
        [Validation(Required=false)]
        public string TriggerStrategy { get; set; }

    }

}
