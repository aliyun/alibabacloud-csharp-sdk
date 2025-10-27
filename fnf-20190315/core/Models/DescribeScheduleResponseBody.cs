// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class DescribeScheduleResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the time-based schedule was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-01-01T01:01:01.001Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The CRON expression.</para>
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
        /// <para>Indicates whether the time-based schedule is enabled. Valid values:</para>
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
        /// <para>The time when the time-based schedule was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-01-01T01:01:01.001Z</para>
        /// </summary>
        [NameInMap("LastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        /// <summary>
        /// <para>The trigger message of the time-based schedule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;: &quot;value&quot;}</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public string Payload { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testRequestId</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the time-based schedule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testScheduleId</para>
        /// </summary>
        [NameInMap("ScheduleId")]
        [Validation(Required=false)]
        public string ScheduleId { get; set; }

        /// <summary>
        /// <para>The name of the time-based schedule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testScheduleName</para>
        /// </summary>
        [NameInMap("ScheduleName")]
        [Validation(Required=false)]
        public string ScheduleName { get; set; }

    }

}
