// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateSandboxTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The number of CPUs for sandboxes created by using this template. Valid values: 1 to 4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DefaultCpu")]
        [Validation(Required=false)]
        public string DefaultCpu { get; set; }

        [NameInMap("DefaultDisk")]
        [Validation(Required=false)]
        public string DefaultDisk { get; set; }

        /// <summary>
        /// <para>The memory size of sandboxes created by using this template. Unit: GiB. Valid values: 1 to 8.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1Gi</para>
        /// </summary>
        [NameInMap("DefaultMemory")]
        [Validation(Required=false)]
        public string DefaultMemory { get; set; }

        /// <summary>
        /// <para>The description of the sandbox template. It must be unique within the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code-interpreter</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The container image used for the sandbox template. Format: <c>[registry/]&lt;repo&gt;[:tag][@sha256:digest]</c>. This parameter is required when you use a non-generic template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.example.com/example/sandbox:1.0</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The instance ID of the AI application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ra-supabase-8moov5lxba****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of pre-warmed sandboxes. Valid values: 1 to 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public long? Replicas { get; set; }

        /// <summary>
        /// <para>The custom tags of the sandbox template. The key is the tag name and the value is the tag value. You cannot use the system-reserved tag createdBy. You cannot use the system-reserved tag hidden.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// <para>The name of the sandbox template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code-interpreter</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
