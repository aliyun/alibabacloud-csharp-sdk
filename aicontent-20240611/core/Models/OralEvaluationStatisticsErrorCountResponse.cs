// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class OralEvaluationStatisticsErrorCountResponse : TeaModel {
        [NameInMap("ProjectData")]
        [Validation(Required=false)]
        public OralEvaluationStatisticsErrorCountResponseProjectData ProjectData { get; set; }
        public class OralEvaluationStatisticsErrorCountResponseProjectData : TeaModel {
            [NameInMap("ApplicationData")]
            [Validation(Required=false)]
            public List<OralEvaluationStatisticsErrorCountResponseProjectDataApplicationData> ApplicationData { get; set; }
            public class OralEvaluationStatisticsErrorCountResponseProjectDataApplicationData : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<OralEvaluationStatisticsErrorCountResponseProjectDataApplicationDataData> Data { get; set; }
                public class OralEvaluationStatisticsErrorCountResponseProjectDataApplicationDataData : TeaModel {
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public List<OralEvaluationStatisticsErrorCountResponseProjectDataApplicationDataDataData> Data { get; set; }
                    public class OralEvaluationStatisticsErrorCountResponseProjectDataApplicationDataDataData : TeaModel {
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

                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

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
