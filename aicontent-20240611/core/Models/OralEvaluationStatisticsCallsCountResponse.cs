// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class OralEvaluationStatisticsCallsCountResponse : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("projectData")]
        [Validation(Required=false)]
        public OralEvaluationStatisticsCallsCountResponseProjectData ProjectData { get; set; }
        public class OralEvaluationStatisticsCallsCountResponseProjectData : TeaModel {
            [NameInMap("ApplicationData")]
            [Validation(Required=false)]
            public List<OralEvaluationStatisticsCallsCountResponseProjectDataApplicationData> ApplicationData { get; set; }
            public class OralEvaluationStatisticsCallsCountResponseProjectDataApplicationData : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<OralEvaluationStatisticsCallsCountResponseProjectDataApplicationDataData> Data { get; set; }
                public class OralEvaluationStatisticsCallsCountResponseProjectDataApplicationDataData : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("applicationAccessId")]
                [Validation(Required=false)]
                public string ApplicationAccessId { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("applicationInternalId")]
            [Validation(Required=false)]
            public string ApplicationInternalId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
