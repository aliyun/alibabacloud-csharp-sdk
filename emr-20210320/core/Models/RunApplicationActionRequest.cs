// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class RunApplicationActionRequest : TeaModel {
        /// <summary>
        /// <para>The name of the action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>start</description></item>
        /// <item><description>stop</description></item>
        /// <item><description>config</description></item>
        /// <item><description>restart</description></item>
        /// <item><description>refresh_queues</description></item>
        /// <item><description>refresh_labels</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>start</para>
        /// </summary>
        [NameInMap("ActionName")]
        [Validation(Required=false)]
        public string ActionName { get; set; }

        /// <summary>
        /// <para>The number of applications in each batch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BatchSize")]
        [Validation(Required=false)]
        public int? BatchSize { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C-C95F0A39D8FF****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The operation object.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ComponentInstanceSelector")]
        [Validation(Required=false)]
        public ComponentInstanceSelector ComponentInstanceSelector { get; set; }

        /// <summary>
        /// <para>The description of the execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>运行描述</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The execution policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FAILED_BLOCK: The system stops the execution if the execution fails.</description></item>
        /// <item><description>FAILED_CONTINUE: The system continues the execution if the execution fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FAILED_CONTINUE</para>
        /// </summary>
        [NameInMap("ExecuteStrategy")]
        [Validation(Required=false)]
        public string ExecuteStrategy { get; set; }

        /// <summary>
        /// <para>The interval for rolling execution. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable rolling execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RollingExecute")]
        [Validation(Required=false)]
        public bool? RollingExecute { get; set; }

    }

}
