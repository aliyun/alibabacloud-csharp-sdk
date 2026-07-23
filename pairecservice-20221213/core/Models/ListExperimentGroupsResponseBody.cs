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
            /// <para>The configuration for the experiment group, in JSON format.</para>
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
            /// <para>The traffic targeting method for the experiment group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>All</c>: All traffic.</para>
            /// </description></item>
            /// <item><description><para><c>Filter</c>: Traffic that matches the filter.</para>
            /// </description></item>
            /// <item><description><para><c>CrowdId</c>: Traffic from a specified crowd.</para>
            /// </description></item>
            /// <item><description><para><c>Random</c>: A random percentage of traffic.</para>
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
            /// <para>The debug crowd ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("DebugCrowdId")]
            [Validation(Required=false)]
            public string DebugCrowdId { get; set; }

            /// <summary>
            /// <para>The IDs of debug users, separated by commas.</para>
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
            /// <para>The distribution duration. This parameter is required only when <c>DistributionType</c> is <c>TimeDuration</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("DistributionTimeDuration")]
            [Validation(Required=false)]
            public int? DistributionTimeDuration { get; set; }

            /// <summary>
            /// <para>The traffic distribution method.<br>● <c>UserId</c>: by user ID<br>● <c>TimeDuration</c>: by time duration<br><br></para>
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
            /// <para>If <c>CrowdTargetType</c> is set to <c>Random</c>, this parameter returns the comma-separated IDs of buckets allocated based on the <c>RandomFlow</c> value.</para>
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
            /// <para>Specifies whether to enable A/B testing for the experiment group.</para>
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
            /// <para>If <c>CrowdTargetType</c> is set to <c>Random</c>, this parameter specifies the percentage of traffic (an integer from 0 to 100) randomly allocated to the experiment group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("RandomFlow")]
            [Validation(Required=false)]
            public long? RandomFlow { get; set; }

            /// <summary>
            /// <para>The IDs of reserved buckets, separated by commas.</para>
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
            /// <para>The status of the experiment group. Valid values:<br>● <c>Offline</c>: The experiment group is inactive.<br>● <c>Online</c>: The experiment group is active.<br>● <c>Pushed</c>: The experiment group is fully rolled out.<br><br><br></para>
            /// 
            /// <b>Example:</b>
            /// <para>Offline</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>59CE7EC6-F268-5D71-9215-32922CC50D72</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
