// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListExperimentGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of experiment groups.</para>
        /// </summary>
        [NameInMap("ExperimentGroups")]
        [Validation(Required=false)]
        public List<ListExperimentGroupsResponseBodyExperimentGroups> ExperimentGroups { get; set; }
        public class ListExperimentGroupsResponseBodyExperimentGroups : TeaModel {
            /// <summary>
            /// <para>The experiment group configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The crowd ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CrowdId")]
            [Validation(Required=false)]
            public string CrowdId { get; set; }

            /// <summary>
            /// <para>The traffic targeting type of the experiment group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>All: All traffic.</description></item>
            /// <item><description>Filter: Traffic that matches the filter condition.</description></item>
            /// <item><description>CrowdId: Traffic targeted by a specified crowd ID.</description></item>
            /// <item><description>Random: Traffic randomly selected by percentage.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("CrowdTargetType")]
            [Validation(Required=false)]
            public string CrowdTargetType { get; set; }

            /// <summary>
            /// <para>The debug crowd ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("DebugCrowdId")]
            [Validation(Required=false)]
            public string DebugCrowdId { get; set; }

            /// <summary>
            /// <para>The debug users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1124512470******,1124512471******,1124512472******</para>
            /// </summary>
            [NameInMap("DebugUsers")]
            [Validation(Required=false)]
            public string DebugUsers { get; set; }

            /// <summary>
            /// <para>The experiment group description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a test.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The distribution time period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("DistributionTimeDuration")]
            [Validation(Required=false)]
            public int? DistributionTimeDuration { get; set; }

            /// <summary>
            /// <para>The traffic distribution method. Valid values:
            /// ● UserId: User ID.
            /// ● TimeDuration: Time period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UserId</para>
            /// </summary>
            [NameInMap("DistributionType")]
            [Validation(Required=false)]
            public string DistributionType { get; set; }

            /// <summary>
            /// <para>The experiment group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ExperimentGroupId")]
            [Validation(Required=false)]
            public string ExperimentGroupId { get; set; }

            /// <summary>
            /// <para>The filter condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gender=female</para>
            /// </summary>
            [NameInMap("Filter")]
            [Validation(Required=false)]
            public string Filter { get; set; }

            /// <summary>
            /// <para>When the traffic targeting type of the experiment group is Random, this field returns the specific bucket numbers assigned based on the RandomFlow value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1,2,3,4</para>
            /// </summary>
            [NameInMap("HoldingBuckets")]
            [Validation(Required=false)]
            public string HoldingBuckets { get; set; }

            /// <summary>
            /// <para>The laboratory ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("LaboratoryId")]
            [Validation(Required=false)]
            public string LaboratoryId { get; set; }

            /// <summary>
            /// <para>The layer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("LayerId")]
            [Validation(Required=false)]
            public string LayerId { get; set; }

            /// <summary>
            /// <para>The experiment group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>experiment_group1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Specifies whether an AB experiment group is required.</para>
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
            /// <para>When the traffic targeting type of the experiment group is Random, this field specifies the percentage of random traffic matched to the experiment group. Valid values: 0 to 100.</para>
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
            /// <para>1,2,3,4</para>
            /// </summary>
            [NameInMap("ReservedBuckets")]
            [Validation(Required=false)]
            public string ReservedBuckets { get; set; }

            /// <summary>
            /// <para>The scene ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <para>The experiment group status. Valid values:
            /// ● Offline: Not online.
            /// ● Online: Online.
            /// ● Pushed: Fully pushed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Offline</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>59CE7EC6-F268-5D71-9215-32922CC50D72</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of elements in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
