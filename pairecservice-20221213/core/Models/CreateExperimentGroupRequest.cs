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
        /// <para>The ID of the specified crowd for crowd targeting. You can call the ListCrowds operation to obtain the crowd ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CrowdId")]
        [Validation(Required=false)]
        public string CrowdId { get; set; }

        /// <summary>
        /// <para>The type of traffic targeting for the experiment group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>All: All traffic.</description></item>
        /// <item><description>Filter: Traffic that uses filter conditions.</description></item>
        /// <item><description>CrowdId: Traffic specified by a crowd ID.</description></item>
        /// <item><description>Random: Random traffic based on a percentage.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("CrowdTargetType")]
        [Validation(Required=false)]
        public string CrowdTargetType { get; set; }

        /// <summary>
        /// <para>The ID of the debug crowd. You can call the ListCrowds operation to obtain the crowd ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DebugCrowdId")]
        [Validation(Required=false)]
        public string DebugCrowdId { get; set; }

        /// <summary>
        /// <para>The debug users. The users must be the UIDs of Alibaba Cloud accounts or RAM users. Separate multiple UIDs with commas.</para>
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
        /// <para>The time period for traffic distribution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DistributionTimeDuration")]
        [Validation(Required=false)]
        public int? DistributionTimeDuration { get; set; }

        /// <summary>
        /// <para>The traffic distribution method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>UserId: User ID.</description></item>
        /// <item><description>TimeDuration: Time period.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UserId</para>
        /// </summary>
        [NameInMap("DistributionType")]
        [Validation(Required=false)]
        public string DistributionType { get; set; }

        /// <summary>
        /// <para>The filter conditions for crowd targeting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gender=male</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The ID of the instance. You can call the ListInstances operation to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-test1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the layer. You can call the ListLayers operation to obtain the layer ID.</para>
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
        /// <para>Specifies whether an AA experiment group is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedAA")]
        [Validation(Required=false)]
        public bool? NeedAA { get; set; }

        /// <summary>
        /// <para>The percentage of random traffic used to match the experiment group when the traffic targeting type is Random. Valid values: 0 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("RandomFlow")]
        [Validation(Required=false)]
        public long? RandomFlow { get; set; }

        /// <summary>
        /// <para>The reserved bucket numbers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("ReservedBuckets")]
        [Validation(Required=false)]
        public string ReservedBuckets { get; set; }

    }

}
