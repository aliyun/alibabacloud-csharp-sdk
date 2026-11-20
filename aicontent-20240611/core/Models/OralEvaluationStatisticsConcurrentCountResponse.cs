// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class OralEvaluationStatisticsConcurrentCountResponse : TeaModel {
        /// <summary>
        /// <para>The project statistics data.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("projectData")]
        [Validation(Required=false)]
        public OralEvaluationStatisticsConcurrentCountResponseProjectData ProjectData { get; set; }
        public class OralEvaluationStatisticsConcurrentCountResponseProjectData : TeaModel {
            /// <summary>
            /// <para>The data list.</para>
            /// </summary>
            [NameInMap("ApplicationData")]
            [Validation(Required=false)]
            public List<OralEvaluationStatisticsConcurrentCountResponseProjectDataApplicationData> ApplicationData { get; set; }
            public class OralEvaluationStatisticsConcurrentCountResponseProjectDataApplicationData : TeaModel {
                /// <summary>
                /// <para>The data list.</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<OralEvaluationStatisticsConcurrentCountResponseProjectDataApplicationDataData> Data { get; set; }
                public class OralEvaluationStatisticsConcurrentCountResponseProjectDataApplicationDataData : TeaModel {
                    /// <summary>
                    /// <para>The statistics item count.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// <para>The statistics item name.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-01</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>appkey</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a0007g7</para>
                /// </summary>
                [NameInMap("applicationAccessId")]
                [Validation(Required=false)]
                public string ApplicationAccessId { get; set; }

            }

            /// <summary>
            /// <para>The internal application ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("applicationInternalId")]
            [Validation(Required=false)]
            public string ApplicationInternalId { get; set; }

        }

        /// <summary>
        /// <para>The project ID.</para>
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
