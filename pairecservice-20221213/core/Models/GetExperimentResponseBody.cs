// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetExperimentResponseBody : TeaModel {
        /// <summary>
        /// <para>The alias of the experiment ID.</para>
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
        /// <para>{&quot;RankBy&quot;: &quot;Score&quot;}</para>
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
        /// <para>The debug users. The value must be the UIDs of Alibaba Cloud accounts or RAM users. Separate multiple UIDs with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1124512470******,1124512471******,1124512472******</para>
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
        /// <para>The traffic allocation percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("FlowPercent")]
        [Validation(Required=false)]
        public int? FlowPercent { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The update time.</para>
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>74D958EF-3598-56FA-8296-FF1575CE43DF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// <para>The status filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Offline: offline</description></item>
        /// <item><description>Online: online</description></item>
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
        /// <item><description>Baseline: baseline experiment</description></item>
        /// <item><description>Normal: normal experiment</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Baseline</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
