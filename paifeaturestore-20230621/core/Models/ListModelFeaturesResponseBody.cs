// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListModelFeaturesResponseBody : TeaModel {
        [NameInMap("ModelFeatures")]
        [Validation(Required=false)]
        public List<ListModelFeaturesResponseBodyModelFeatures> ModelFeatures { get; set; }
        public class ListModelFeaturesResponseBodyModelFeatures : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-07-04T14:46:22.227+08:00</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-07-04T14:46:22.227+08:00</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>label_table_1</para>
            /// </summary>
            [NameInMap("LabelTableName")]
            [Validation(Required=false)]
            public string LabelTableName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ModelFeatureId")]
            [Validation(Required=false)]
            public string ModelFeatureId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>model_feature1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1231243253****</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>project1</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2CA11923-2A3D-5E5A-8314-E699D2DD15DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
