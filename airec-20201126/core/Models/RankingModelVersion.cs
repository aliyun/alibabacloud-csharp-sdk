// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class RankingModelVersion : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>模型A_t1638964800000</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RunLog")]
        [Validation(Required=false)]
        public string RunLog { get; set; }

        [NameInMap("RunResult")]
        [Validation(Required=false)]
        public RankingModelVersionRunResult RunResult { get; set; }
        public class RankingModelVersionRunResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("AssessAuc")]
            [Validation(Required=false)]
            public string AssessAuc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("AssessGauc")]
            [Validation(Required=false)]
            public string AssessGauc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("AssessLoss")]
            [Validation(Required=false)]
            public string AssessLoss { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("TrainAuc")]
            [Validation(Required=false)]
            public string TrainAuc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("TrainGauc")]
            [Validation(Required=false)]
            public string TrainGauc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("TrainLoss")]
            [Validation(Required=false)]
            public string TrainLoss { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-12-08T20:00:00.0Z</para>
        /// </summary>
        [NameInMap("RunTime")]
        [Validation(Required=false)]
        public string RunTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TRAINING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a-a-a</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>模型A</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
