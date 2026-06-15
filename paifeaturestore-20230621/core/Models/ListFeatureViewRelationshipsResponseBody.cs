// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListFeatureViewRelationshipsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of relationships to models that use this feature view.</para>
        /// </summary>
        [NameInMap("Relationships")]
        [Validation(Required=false)]
        public List<ListFeatureViewRelationshipsResponseBodyRelationships> Relationships { get; set; }
        public class ListFeatureViewRelationshipsResponseBodyRelationships : TeaModel {
            /// <summary>
            /// <para>The name of the feature view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fv1</para>
            /// </summary>
            [NameInMap("FeatureViewName")]
            [Validation(Required=false)]
            public string FeatureViewName { get; set; }

            /// <summary>
            /// <para>A list of models.</para>
            /// </summary>
            [NameInMap("Models")]
            [Validation(Required=false)]
            public List<ListFeatureViewRelationshipsResponseBodyRelationshipsModels> Models { get; set; }
            public class ListFeatureViewRelationshipsResponseBodyRelationshipsModels : TeaModel {
                /// <summary>
                /// <para>The ID of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public string ModelId { get; set; }

                /// <summary>
                /// <para>The name of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dbmtl</para>
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

            }

            /// <summary>
            /// <para>The name of the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project1</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FBBE454-9BD1-5D8F-9129-D14DB7FAFE0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
