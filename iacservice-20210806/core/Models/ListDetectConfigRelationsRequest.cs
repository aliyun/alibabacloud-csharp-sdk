// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListDetectConfigRelationsRequest : TeaModel {
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
        /// <para>Target ID to associate. StackId or TaskId</para>
        /// 
        /// <b>Example:</b>
        /// <para>stack-xxxxx</para>
        /// </summary>
        [NameInMap("targetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>Type of the association target</para>
        /// <list type="bullet">
        /// <item><description>Task: orchestration Job  </description></item>
        /// <item><description>Stack: resource stack</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Stack</para>
        /// </summary>
        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
