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
                        /// 
                        /// <b>Example:</b>
                        /// <para>230</para>
                        /// </summary>
                        [NameInMap("count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2025-02</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>51000</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>start the core unsuccessfull.</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                }

                /// <summary>
                /// <para>appId,appkey</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t000797</para>
                /// </summary>
                [NameInMap("applicationAccessId")]
                [Validation(Required=false)]
                public string ApplicationAccessId { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("applicationInternalId")]
            [Validation(Required=false)]
            public string ApplicationInternalId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
