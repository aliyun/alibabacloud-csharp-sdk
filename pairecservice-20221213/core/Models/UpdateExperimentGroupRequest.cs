// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateExperimentGroupRequest : TeaModel {
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
        /// <para>The ID of the crowd for crowd targeting. You can obtain this ID by calling the ListCrowds API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CrowdId")]
        [Validation(Required=false)]
        public string CrowdId { get; set; }

        /// <summary>
        /// <para>The type of crowd targeting for the experiment group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>All: all traffic</para>
        /// </description></item>
        /// <item><description><para>Filter: traffic that matches the filter condition</para>
        /// </description></item>
        /// <item><description><para>CrowdId: traffic from the specified crowd ID</para>
        /// </description></item>
        /// <item><description><para>Random: a random percentage of traffic</para>
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
        /// <para>The ID of the debug crowd. You can obtain this ID by calling the ListCrowds API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DebugCrowdId")]
        [Validation(Required=false)]
        public string DebugCrowdId { get; set; }

        /// <summary>
        /// <para>A comma-separated list of UIDs for debug users. The UIDs can belong to Alibaba Cloud main accounts or sub-accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1,user2,user3</para>
        /// </summary>
        [NameInMap("DebugUsers")]
        [Validation(Required=false)]
        public string DebugUsers { get; set; }

        /// <summary>
        /// <para>The description of the experiment group.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The distribution type. ● UserId: Distributes traffic by user ID. ● TimeDuration: Distributes traffic by time duration.</para>
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
        /// <para>The ID of the instance. You can obtain this ID by calling the ListInstances API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-abcdefg1234</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the layer. You can obtain this ID by calling the ListLayers API.</para>
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
        /// <para>experiment_group1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether an AA experiment group is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedAA")]
        [Validation(Required=false)]
        public bool? NeedAA { get; set; }

        /// <summary>
        /// <para>If CrowdTargetType is set to Random, this parameter specifies the percentage of traffic (from 0 to 100) to route to the experiment group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("RandomFlow")]
        [Validation(Required=false)]
        public long? RandomFlow { get; set; }

        /// <summary>
        /// <para>The reserved buckets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("ReservcedBuckets")]
        [Validation(Required=false)]
        public string ReservcedBuckets { get; set; }

    }

}
