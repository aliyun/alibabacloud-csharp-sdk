// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListExperimentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of experiments.</para>
        /// </summary>
        [NameInMap("Experiments")]
        [Validation(Required=false)]
        public List<ListExperimentsResponseBodyExperiments> Experiments { get; set; }
        public class ListExperimentsResponseBodyExperiments : TeaModel {
            /// <summary>
            /// <para>The alias for the experiment ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>L1#EG1#E1</para>
            /// </summary>
            [NameInMap("AliasExperimentId")]
            [Validation(Required=false)]
            public string AliasExperimentId { get; set; }

            /// <summary>
            /// <para>The allocated bucket numbers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1,2,3</para>
            /// </summary>
            [NameInMap("Buckets")]
            [Validation(Required=false)]
            public string Buckets { get; set; }

            /// <summary>
            /// <para>The configuration of the experiment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The ID of the debug crowd.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DebugCrowdId")]
            [Validation(Required=false)]
            public string DebugCrowdId { get; set; }

            /// <summary>
            /// <para>A comma-separated list of user IDs for debugging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uid1,uid2,uid3</para>
            /// </summary>
            [NameInMap("DebugUsers")]
            [Validation(Required=false)]
            public string DebugUsers { get; set; }

            /// <summary>
            /// <para>The description of the experiment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a test.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the experiment group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ExperimentGroupId")]
            [Validation(Required=false)]
            public string ExperimentGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the experiment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ExperimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }

            /// <summary>
            /// <para>The percentage of flow allocated to the experiment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("FlowPercent")]
            [Validation(Required=false)]
            public int? FlowPercent { get; set; }

            /// <summary>
            /// <para>The timestamp indicating when the experiment was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The timestamp indicating when the experiment was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>The ID of the laboratory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
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
            /// <para>The name of the experiment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>experiment_test1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the scene.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <para>The status of the experiment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Offline</c>: The experiment is inactive and does not receive flow.</para>
            /// </description></item>
            /// <item><description><para><c>Online</c>: The experiment is active and can receive flow.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Offline</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the experiment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Baseline</c>: The control experiment.</para>
            /// </description></item>
            /// <item><description><para><c>Normal</c>: A variant experiment.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Baseline</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68075085-1A7D-55C2-B51D-7AD9B02A6DD6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of experiments returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
