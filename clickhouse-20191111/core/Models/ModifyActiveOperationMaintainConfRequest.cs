// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyActiveOperationMaintainConfRequest : TeaModel {
        /// <summary>
        /// <para>The cycle time. </para>
        /// <list type="bullet">
        /// <item><description>If CycleType is set to Month, the value is one or more numbers from 1 to 28 that indicate the days of the month, separated by commas (,).</description></item>
        /// <item><description>If CycleType is set to Week, the value is one or more numbers from 1 to 7 that indicate the days of the week, separated by commas (,).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CycleTime")]
        [Validation(Required=false)]
        public string CycleTime { get; set; }

        /// <summary>
        /// <para>The cycle type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month: Monthly.</description></item>
        /// <item><description>Week: Weekly.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Week</para>
        /// </summary>
        [NameInMap("CycleType")]
        [Validation(Required=false)]
        public string CycleType { get; set; }

        /// <summary>
        /// <para>The end time of the maintenance window. Format: HH:mmZ-HH:mmZ (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>20:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the task. Format: yyyy-MM-ddTHH:mm:ssZ (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>07:00Z</para>
        /// </summary>
        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>Specifies whether the configuration takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Yes.</description></item>
        /// <item><description><b>2</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
