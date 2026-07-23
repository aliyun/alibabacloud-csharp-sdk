// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetExperimentGroupResponseBody : TeaModel {
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
        /// <para>The ID of the crowd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CrowdId")]
        [Validation(Required=false)]
        public string CrowdId { get; set; }

        /// <summary>
        /// <para>The method for targeting traffic to the experiment group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>All</c>: all traffic</para>
        /// </description></item>
        /// <item><description><para><c>Filter</c>: traffic that matches the filter</para>
        /// </description></item>
        /// <item><description><para><c>CrowdId</c>: traffic from the specified crowd</para>
        /// </description></item>
        /// <item><description><para><c>Random</c>: a random percentage of traffic</para>
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
        /// <para>The ID of the debug crowd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("DebugCrowdId")]
        [Validation(Required=false)]
        public string DebugCrowdId { get; set; }

        /// <summary>
        /// <para>The user IDs for debugging, separated by commas.</para>
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
        /// <para>The distribution duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("DistributionTimeDuration")]
        [Validation(Required=false)]
        public int? DistributionTimeDuration { get; set; }

        /// <summary>
        /// <para>The traffic distribution method.
        /// ● <c>UserId</c>: Distributes traffic by user ID.
        /// ● <c>TimeDuration</c>: Distributes traffic by time period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserId</para>
        /// </summary>
        [NameInMap("DistributionType")]
        [Validation(Required=false)]
        public string DistributionType { get; set; }

        /// <summary>
        /// <para>The filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gender=female</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The bucket IDs that correspond to the <c>RandomFlow</c> percentage. This parameter is returned only when <c>CrowdTargetType</c> is set to <c>Random</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3,4</para>
        /// </summary>
        [NameInMap("HoldingBuckets")]
        [Validation(Required=false)]
        public string HoldingBuckets { get; set; }

        /// <summary>
        /// <para>The ID of the laboratory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LaboratoryId")]
        [Validation(Required=false)]
        public string LaboratoryId { get; set; }

        /// <summary>
        /// <para>The ID of the layer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("LayerId")]
        [Validation(Required=false)]
        public string LayerId { get; set; }

        /// <summary>
        /// <para>The name of the experiment group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>experiment_group1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Indicates whether an A/B test is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedAA")]
        [Validation(Required=false)]
        public bool? NeedAA { get; set; }

        /// <summary>
        /// <para>The owner of the experiment group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1124512470******</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The percentage of traffic from 0 to 100 that is randomly allocated to this experiment group. This parameter is returned only when <c>CrowdTargetType</c> is set to <c>Random</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("RandomFlow")]
        [Validation(Required=false)]
        public long? RandomFlow { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BDB621CB-A81E-5D39-8793-39A365CBCC74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The reserved bucket IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3,4</para>
        /// </summary>
        [NameInMap("ReservedBuckets")]
        [Validation(Required=false)]
        public string ReservedBuckets { get; set; }

        /// <summary>
        /// <para>The ID of the scene.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <para>The status of the experiment group. Valid values:
        /// ● <c>Offline</c>: The experiment group is not launched.
        /// ● <c>Online</c>: The experiment group is launched.
        /// ● <c>Pushed</c>: The experiment group is fully launched.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Offline</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
