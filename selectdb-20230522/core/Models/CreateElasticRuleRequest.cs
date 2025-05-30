// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class CreateElasticRuleRequest : TeaModel {
        /// <summary>
        /// <para>The rule for computing resources of the required cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb.2xlarge</para>
        /// </summary>
        [NameInMap("ClusterClass")]
        [Validation(Required=false)]
        public string ClusterClass { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb-xxxb9f2w-be</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb-cn-7213cjv****</para>
        /// </summary>
        [NameInMap("DbInstanceId")]
        [Validation(Required=false)]
        public string DbInstanceId { get; set; }

        /// <summary>
        /// <para>The time when you want to execute the scheduled scaling rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00</para>
        /// </summary>
        [NameInMap("ElasticRuleStartTime")]
        [Validation(Required=false)]
        public string ElasticRuleStartTime { get; set; }

        /// <summary>
        /// <para>The execution cycle.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>Day</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Day</para>
        /// </summary>
        [NameInMap("ExecutionPeriod")]
        [Validation(Required=false)]
        public string ExecutionPeriod { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
