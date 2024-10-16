// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListFeatureViewRelationshipsResponseBody : TeaModel {
        [NameInMap("Relationships")]
        [Validation(Required=false)]
        public List<ListFeatureViewRelationshipsResponseBodyRelationships> Relationships { get; set; }
        public class ListFeatureViewRelationshipsResponseBodyRelationships : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>fv1</para>
            /// </summary>
            [NameInMap("FeatureViewName")]
            [Validation(Required=false)]
            public string FeatureViewName { get; set; }

            [NameInMap("Models")]
            [Validation(Required=false)]
            public List<ListFeatureViewRelationshipsResponseBodyRelationshipsModels> Models { get; set; }
            public class ListFeatureViewRelationshipsResponseBodyRelationshipsModels : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public string ModelId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dbmtl</para>
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

            }

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
        /// <para>0FBBE454-9BD1-5D8F-9129-D14DB7FAFE0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
