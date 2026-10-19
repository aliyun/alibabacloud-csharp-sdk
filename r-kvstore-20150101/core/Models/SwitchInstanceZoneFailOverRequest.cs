// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class SwitchInstanceZoneFailOverRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The duration of the simulated failure. Unit: minutes.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5</description></item>
        /// <item><description>10</description></item>
        /// <item><description>30</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SiteFaultTime")]
        [Validation(Required=false)]
        public string SiteFaultTime { get; set; }

        /// <summary>
        /// <para>The target zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("TargetZoneId")]
        [Validation(Required=false)]
        public string TargetZoneId { get; set; }

    }

}
