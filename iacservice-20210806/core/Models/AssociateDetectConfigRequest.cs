// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class AssociateDetectConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the drift detection configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc-xxxx</para>
        /// </summary>
        [NameInMap("detectConfigId")]
        [Validation(Required=false)]
        public string DetectConfigId { get; set; }

        /// <summary>
        /// <para>The ID of the association target. The value is a StackId or TaskId.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stack-xxxxx</para>
        /// </summary>
        [NameInMap("targetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The type of the association target. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Task: orchestration task.</description></item>
        /// <item><description>Stack: resource stack.</description></item>
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
