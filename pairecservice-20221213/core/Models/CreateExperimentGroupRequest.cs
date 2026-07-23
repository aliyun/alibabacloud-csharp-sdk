// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateExperimentGroupRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the experiment group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RankBy&quot;: &quot;Score&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The ID of the crowd for crowd targeting. You can obtain this ID by calling the ListCrowds operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CrowdId")]
        [Validation(Required=false)]
        public string CrowdId { get; set; }

        /// <summary>
        /// <para>The crowd targeting type for the experiment group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>All</c>: All traffic</para>
        /// </description></item>
        /// <item><description><para><c>Filter</c>: Traffic that matches the filter condition</para>
        /// </description></item>
        /// <item><description><para><c>CrowdId</c>: Traffic from a specific crowd</para>
        /// </description></item>
        /// <item><description><para><c>Random</c>: A random percentage of traffic</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("CrowdTargetType")]
        [Validation(Required=false)]
        public string CrowdTargetType { get; set; }

        /// <summary>
        /// <para>The ID of the debug crowd. You can obtain this ID by calling the ListCrowds operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DebugCrowdId")]
        [Validation(Required=false)]
        public string DebugCrowdId { get; set; }

        /// <summary>
        /// <para>The UIDs of the debug users. The value must be the UID of an Alibaba Cloud account or a RAM user. Separate multiple UIDs with a comma.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1124512470******,1124512471******,1124512472******</para>
        /// </summary>
        [NameInMap("DebugUsers")]
        [Validation(Required=false)]
        public string DebugUsers { get; set; }

        /// <summary>
        /// <para>The description of the experiment group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time duration for traffic distribution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DistributionTimeDuration")]
        [Validation(Required=false)]
        public int? DistributionTimeDuration { get; set; }

        /// <summary>
        /// <para>The distribution type. Valid values: <c>UserId</c> (by user ID) and <c>TimeDuration</c> (by time duration).</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserId</para>
        /// </summary>
        [NameInMap("DistributionType")]
        [Validation(Required=false)]
        public string DistributionType { get; set; }

        /// <summary>
        /// <para>The filter condition for crowd targeting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gender=male</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The instance ID. You can obtain this ID by calling the ListInstances operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-test1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the layer. You can obtain this ID by calling the ListLayers operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("LayerId")]
        [Validation(Required=false)]
        public string LayerId { get; set; }

        /// <summary>
        /// <para>The name of the experiment group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>experiment_group_test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether to create an A/A experiment group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedAA")]
        [Validation(Required=false)]
        public bool? NeedAA { get; set; }

        /// <summary>
        /// <para>The percentage of traffic to randomly allocate to this experiment group. This parameter is used only when <c>CrowdTargetType</c> is set to <c>Random</c>. Valid values: 0 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("RandomFlow")]
        [Validation(Required=false)]
        public long? RandomFlow { get; set; }

        /// <summary>
        /// <para>A comma-separated list of reserved bucket numbers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("ReservedBuckets")]
        [Validation(Required=false)]
        public string ReservedBuckets { get; set; }

    }

}
