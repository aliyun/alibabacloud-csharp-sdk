// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class CreateScheduleRequest : TeaModel {
        /// <summary>
        /// <para>The CRON expression.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 * * * * *</para>
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para>The description of the time-based schedule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the time-based schedule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The name of the workflow that is associated with the time-based schedule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow</para>
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// <para>The trigger message of the time-based schedule. Specify the value in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;: &quot;value&quot;}</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public string Payload { get; set; }

        /// <summary>
        /// <para>The name of the time-based schedule. The name must meet the following conventions:</para>
        /// <list type="bullet">
        /// <item><description>The name can contain letters, digits, underscores (_), and hyphens (-).</description></item>
        /// <item><description>The name must start with a letter or an underscore (_).</description></item>
        /// <item><description>It is case-sensitive.</description></item>
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

        [NameInMap("SignatureVersion")]
        [Validation(Required=false)]
        public string SignatureVersion { get; set; }

    }

}
