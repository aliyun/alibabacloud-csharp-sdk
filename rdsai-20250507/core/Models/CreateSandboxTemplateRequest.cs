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

        /// <summary>
        /// <para>The memory size for sandboxes created by using this template. Unit: Gi. Valid values: 1Gi to 8Gi.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1Gi</para>
        /// </summary>
        [NameInMap("DefaultMemory")]
        [Validation(Required=false)]
        public string DefaultMemory { get; set; }

        /// <summary>
        /// <para>The description of the sandbox template. The description must be unique within the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code-interpreter</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        /// <para>The number of prewarmed sandboxes. Valid values: 1 to 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public long? Replicas { get; set; }

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
