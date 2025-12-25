// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyRCElasticScalingRequest : TeaModel {
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rc-3ndh4shwes*</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mysql.x2.medium.9cm</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hanghzou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ScalingEnabled")]
        [Validation(Required=false)]
        public bool? ScalingEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;rule&quot;:[{&quot;beginTime&quot;:&quot;09:00&quot;,&quot;endTime&quot;:&quot;17:00&quot;,&quot;acu&quot;:4}]}</para>
        /// </summary>
        [NameInMap("ScheduledRule")]
        [Validation(Required=false)]
        public string ScheduledRule { get; set; }

    }

}
