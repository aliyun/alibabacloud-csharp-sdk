// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class DissociateDetectConfigRequest : TeaModel {
        /// <summary>
        /// <para>Drift detection configuration ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc-xxxx</para>
        /// </summary>
        [NameInMap("detectConfigId")]
        [Validation(Required=false)]
        public string DetectConfigId { get; set; }

        /// <summary>
        /// <para>ID of the association target. StackId or TaskId</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stack-xxxx</para>
        /// </summary>
        [NameInMap("targetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>Type of the association target</para>
        /// <list type="bullet">
        /// <item><description>Task: Orchestration job  </description></item>
        /// <item><description>Stack: Resource stack</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Stack</para>
        /// </summary>
        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
