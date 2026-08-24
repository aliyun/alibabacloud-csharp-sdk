// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeAutoScalingHistoryRequest : TeaModel {
        /// <summary>
        /// <para>The type of elastic scaling task to query. Currently, only <b>SPEC</b> is supported, which indicates querying the automatic performance scaling history.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SPEC</para>
        /// </summary>
        [NameInMap("AutoScalingTaskType")]
        [Validation(Required=false)]
        public string AutoScalingTaskType { get; set; }

        /// <summary>
        /// <para>The end time of the query task. Specify the value as a UNIX timestamp. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1676605305796</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>Currently, only ApsaraDB RDS for MySQL instances are supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze8g2am97624****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The start time of the query task. Specify the value as a UNIX timestamp. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>The start time cannot be earlier than 45 days before the current time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1675833788056</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
