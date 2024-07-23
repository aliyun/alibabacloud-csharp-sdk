// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListExperimentsResponseBody : TeaModel {
        [NameInMap("Experiments")]
        [Validation(Required=false)]
        public List<ListExperimentsResponseBodyExperiments> Experiments { get; set; }
        public class ListExperimentsResponseBodyExperiments : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>L1#EG1#E1</para>
            /// </summary>
            [NameInMap("AliasExperimentId")]
            [Validation(Required=false)]
            public string AliasExperimentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1,2,3</para>
            /// </summary>
            [NameInMap("Buckets")]
            [Validation(Required=false)]
            public string Buckets { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DebugCrowdId")]
            [Validation(Required=false)]
            public string DebugCrowdId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>uid1,uid2,uid3</para>
            /// </summary>
            [NameInMap("DebugUsers")]
            [Validation(Required=false)]
            public string DebugUsers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>This is a test.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ExperimentGroupId")]
            [Validation(Required=false)]
            public string ExperimentGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ExperimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("FlowPercent")]
            [Validation(Required=false)]
            public int? FlowPercent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("LaboratoryId")]
            [Validation(Required=false)]
            public string LaboratoryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("LayerId")]
            [Validation(Required=false)]
            public string LayerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>experiment_test1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Offline</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Baseline</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>68075085-1A7D-55C2-B51D-7AD9B02A6DD6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
