// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyActiveOperationMaintainConfigRequest : TeaModel {
        /// <summary>
        /// <para>The days of the cycle.</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>CycleType</c> is <c>Month</c>, specify the days of the month (1 to 28). Separate multiple days with a comma (,).</para>
        /// </description></item>
        /// <item><description><para>If <c>CycleType</c> is <c>Week</c>, specify the days of the week (1 to 7). Separate multiple days with a comma (,).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3,4,5</para>
        /// </summary>
        [NameInMap("CycleTime")]
        [Validation(Required=false)]
        public string CycleTime { get; set; }

        /// <summary>
        /// <para>The cycle type of the maintenance window. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Month</c></para>
        /// </description></item>
        /// <item><description><para><c>Week</c></para>
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
        /// <para>The end time of the maintenance window, specified in <em>HH:mm:ss</em>Z format (UTC time).</para>
        /// 
        /// <b>Example:</b>
        /// <para>20:00:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the maintenance window, specified in <em>HH:mm:ss</em>Z format (UTC time).</para>
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
        /// <para>Specifies whether the configuration is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: enabled</para>
        /// </description></item>
        /// <item><description><para>2: disabled</para>
        /// </description></item>
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
