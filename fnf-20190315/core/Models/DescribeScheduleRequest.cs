// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class DescribeScheduleRequest : TeaModel {
        /// <summary>
        /// <para>The name of the flow that is associated with the time-based schedule. The name must be unique within the region and cannot be modified after the time-based schedule is created. The name must meet the following conventions:</para>
        /// <list type="bullet">
        /// <item><description>The name can contain letters, digits, underscores (_), and hyphens (-).</description></item>
        /// <item><description>The name must start with a letter or an underscore (_).</description></item>
        /// <item><description>The name is case-sensitive.</description></item>
        /// <item><description>The name must be 1 to 128 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testFlowName</para>
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// <para>The name of the time-based schedule. The name must meet the following conventions:</para>
        /// <list type="bullet">
        /// <item><description>The name can contain letters, digits, underscores (_), and hyphens (-).</description></item>
        /// <item><description>The name must start with a letter or an underscore (_).</description></item>
        /// <item><description>The name is case-sensitive.</description></item>
        /// <item><description>The name must be 1 to 128 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testScheduleName</para>
        /// </summary>
        [NameInMap("ScheduleName")]
        [Validation(Required=false)]
        public string ScheduleName { get; set; }

    }

}
