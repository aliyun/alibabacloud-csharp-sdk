// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class EventRebootInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the system Event.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e-9d992570200d86b9126d78aa8c37b54b</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The type of the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>immediate: Executes the operation immediately.</para>
        /// </description></item>
        /// <item><description><para>scheduled: Executes the operation at the specified time.</para>
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
        /// <para>The scheduled execution time, as a Timestamp in milliseconds. This parameter is required when OpsType is set to scheduled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1742452232000</para>
        /// </summary>
        [NameInMap("PlanTime")]
        [Validation(Required=false)]
        public long? PlanTime { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// </summary>
        [NameInMap("PlanUtcTime")]
        [Validation(Required=false)]
        public string PlanUtcTime { get; set; }

        /// <summary>
        /// <para>The ID of the Resource.</para>
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
