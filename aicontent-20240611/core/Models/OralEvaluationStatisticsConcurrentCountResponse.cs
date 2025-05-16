// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class OralEvaluationStatisticsConcurrentCountResponse : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("projectData")]
        [Validation(Required=false)]
        public OralEvaluationStatisticsConcurrentCountResponseProjectData ProjectData { get; set; }
        public class OralEvaluationStatisticsConcurrentCountResponseProjectData : TeaModel {
            [NameInMap("ApplicationData")]
            [Validation(Required=false)]
            public List<OralEvaluationStatisticsConcurrentCountResponseProjectDataApplicationData> ApplicationData { get; set; }
            public class OralEvaluationStatisticsConcurrentCountResponseProjectDataApplicationData : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<OralEvaluationStatisticsConcurrentCountResponseProjectDataApplicationDataData> Data { get; set; }
                public class OralEvaluationStatisticsConcurrentCountResponseProjectDataApplicationDataData : TeaModel {
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
