// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateTaskRequest : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a65451293e64979ba7a4b573950217fe</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("groupInfo")]
        [Validation(Required=false)]
        public CreateTaskRequestGroupInfo GroupInfo { get; set; }
        public class CreateTaskRequestGroupInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>g-5fd38c9b92d541a7083a86432e2</para>
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>project-433aead7560572057e5d9167608</para>
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

        [NameInMap("taskBackend")]
        [Validation(Required=false)]
        public CreateTaskRequestTaskBackend TaskBackend { get; set; }
        public class CreateTaskRequestTaskBackend : TeaModel {
            [NameInMap("bucketEndpoint")]
            [Validation(Required=false)]
            public string BucketEndpoint { get; set; }

            [NameInMap("bucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            [NameInMap("objectPath")]
            [Validation(Required=false)]
            public string ObjectPath { get; set; }

        }

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
        /// <para>Always</para>
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
