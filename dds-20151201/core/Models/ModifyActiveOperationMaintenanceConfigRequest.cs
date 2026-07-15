// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyActiveOperationMaintenanceConfigRequest : TeaModel {
        /// <summary>
        /// <para>The day of the cycle.</para>
        /// <list type="bullet">
        /// <item><description><para>If CycleType is set to Month, enter a number from 1 to 28 to specify the day of the month. Use a comma (,) to separate multiple days.</para>
        /// </description></item>
        /// <item><description><para>If CycleType is set to Week, enter a number from 1 to 7 to specify the day of the week. Use a comma (,) to separate multiple days.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("CycleTime")]
        [Validation(Required=false)]
        public string CycleTime { get; set; }

        /// <summary>
        /// <para>The cycle type.</para>
        /// <list type="bullet">
        /// <item><description><para>Month: monthly</para>
        /// </description></item>
        /// <item><description><para>Week: weekly</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Week</para>
        /// </summary>
        [NameInMap("CycleType")]
        [Validation(Required=false)]
        public string CycleType { get; set; }

        /// <summary>
        /// <para>The end time of the O\&amp;M window for the instance. The time is in the HH:mmZ format and is in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the O\&amp;M window for the instance. The time is in the HH:mmZ format and is in UTC.</para>
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
        /// <para>Specifies whether the configuration is enabled.</para>
        /// <list type="bullet">
        /// <item><description><para>1: enabled</para>
        /// </description></item>
        /// <item><description><para>2: disabled</para>
        /// </description></item>
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
