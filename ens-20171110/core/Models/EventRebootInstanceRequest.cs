// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class EventRebootInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The system event ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e-9d992570200d86b9126d78aa8c37b54b</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The O&amp;M task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>immediate: Executes the task immediately.</para>
        /// </description></item>
        /// <item><description><para>scheduled: Executes the task at a scheduled time.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immediate</para>
        /// </summary>
        [NameInMap("OpsType")]
        [Validation(Required=false)]
        public string OpsType { get; set; }

        /// <summary>
        /// <para>The scheduled execution time. The value is a timestamp in milliseconds. This parameter is required when OpsType is set to scheduled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1742452232000</para>
        /// </summary>
        [NameInMap("PlanTime")]
        [Validation(Required=false)]
        public long? PlanTime { get; set; }

        [NameInMap("PlanUtcTime")]
        [Validation(Required=false)]
        public string PlanUtcTime { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

    }

}
