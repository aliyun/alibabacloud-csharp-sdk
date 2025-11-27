// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCElasticScalingResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>gn8is</para>
        /// </summary>
        [NameInMap("AcuType")]
        [Validation(Required=false)]
        public string AcuType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rc-a0e466b01tif2pk</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1F7B8B09-36F3-1165-BADB-13E376FE9BD7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScalingEnabled")]
        [Validation(Required=false)]
        public bool? ScalingEnabled { get; set; }

        [NameInMap("ScalingSupported")]
        [Validation(Required=false)]
        public bool? ScalingSupported { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;rule&quot;:[{&quot;beginTime&quot;:&quot;09:00&quot;,&quot;endTime&quot;:&quot;17:00&quot;,&quot;acu&quot;:4}]}</para>
        /// </summary>
        [NameInMap("ScheduledRule")]
        [Validation(Required=false)]
        public string ScheduledRule { get; set; }

        [NameInMap("ScheduledRuleTemplates")]
        [Validation(Required=false)]
        public DescribeRCElasticScalingResponseBodyScheduledRuleTemplates ScheduledRuleTemplates { get; set; }
        public class DescribeRCElasticScalingResponseBodyScheduledRuleTemplates : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<string> Items { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mysql.x2.medium.9cm</para>
        /// </summary>
        [NameInMap("TargetInstanceType")]
        [Validation(Required=false)]
        public string TargetInstanceType { get; set; }

    }

}
