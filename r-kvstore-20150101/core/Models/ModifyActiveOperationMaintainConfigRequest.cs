// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyActiveOperationMaintainConfigRequest : TeaModel {
        /// <summary>
        /// <para>The cycle time.</para>
        /// <list type="bullet">
        /// <item><description>If CycleType is set to Month, the value is a number from 1 to 28, which indicates the day of the month. Multiple values are separated by commas (,). If the configuration does not take effect, the value is 0.</description></item>
        /// <item><description>If CycleType is set to Week, the value is a number from 1 to 7, which indicates the day of the week. Multiple values are separated by commas (,). If the configuration does not take effect, the value is 0.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3,4,5</para>
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
        /// <para>The end time of the O&amp;M time window. The time is in the HH:mm:ssZ format (UTC time).</para>
        /// 
        /// <b>Example:</b>
        /// <para>20:00:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the O&amp;M time window. The time is in the <i>HH:mm:ss</i>Z format (UTC time).</para>
        /// 
        /// <b>Example:</b>
        /// <para>16:00:00Z</para>
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
        /// <item><description>1: Effective.</description></item>
        /// <item><description>2: Ineffective.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
