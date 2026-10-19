// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyActiveOperationMaintenanceConfigRequest : TeaModel {
        /// <summary>
        /// <para>The list of days in the O&amp;M cycle, separated by commas (,).</para>
        /// <list type="bullet">
        /// <item><description>If CycleType is set to Month, each item is an integer from 1 to 28, which represents a day of the month.</description></item>
        /// <item><description>If CycleType is set to Week, each item is an integer from 1 to 7, which represents a day of the week.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
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
        /// <para>The end time of the instance O&amp;M window. The time is in the HH:mmZ format and in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the instance O&amp;M window. The time is in the HH:mmZ format and in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21:00Z</para>
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

        /// <summary>
        /// <para>Specifies whether the configuration takes effect. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>1: Effective. </description></item>
        /// <item><description>2: Invalid.</description></item>
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
