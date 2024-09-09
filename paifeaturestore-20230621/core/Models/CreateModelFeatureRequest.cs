// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class CreateModelFeatureRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public List<CreateModelFeatureRequestFeatures> Features { get; set; }
        public class CreateModelFeatureRequestFeatures : TeaModel {
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("FeatureViewId")]
            [Validation(Required=false)]
            public string FeatureViewId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("LabelPriorityLevel")]
        [Validation(Required=false)]
        public long? LabelPriorityLevel { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("LabelTableId")]
        [Validation(Required=false)]
        public string LabelTableId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("SequenceFeatureViewIds")]
        [Validation(Required=false)]
        public List<string> SequenceFeatureViewIds { get; set; }

    }

}
