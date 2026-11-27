// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ModifySandboxTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The number of CPUs for sandboxes created by using this template. Valid values: 1 to 4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DefaultCpu")]
        [Validation(Required=false)]
        public string DefaultCpu { get; set; }

        /// <summary>
        /// <para>The default disk space for sandboxes created by using this template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30Gi</para>
        /// </summary>
        [NameInMap("DefaultDisk")]
        [Validation(Required=false)]
        public string DefaultDisk { get; set; }

        /// <summary>
        /// <para>The memory size for sandboxes created by using this template. Unit: GiB. Valid values: 1 to 8.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1Gi</para>
        /// </summary>
        [NameInMap("DefaultMemory")]
        [Validation(Required=false)]
        public string DefaultMemory { get; set; }

        /// <summary>
        /// <para>The container image used by the sandbox template. Format: <c>[registry/]&lt;repo&gt;[:tag][@sha256:digest]</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.example.com/example/sandbox:1.0</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The ID of the AI application instance.</para>
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
        /// <para>The initial number of instances. Valid values: 1 to 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public long? Replicas { get; set; }

        /// <summary>
        /// <para>The custom tags of the sandbox template. The key is the tag name, and the value is the tag value. You cannot use the system-reserved tags createdBy and hidden.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the sandbox template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desktop-xxx</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
