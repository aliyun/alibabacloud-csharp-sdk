// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class GetProjectModelFeatureResponseBody : TeaModel {
        [NameInMap("Features")]
        [Validation(Required=false)]
        public List<GetProjectModelFeatureResponseBodyFeatures> Features { get; set; }
        public class GetProjectModelFeatureResponseBodyFeatures : TeaModel {
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            [NameInMap("FeatureViewId")]
            [Validation(Required=false)]
            public string FeatureViewId { get; set; }

            [NameInMap("FeatureViewName")]
            [Validation(Required=false)]
            public string FeatureViewName { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("LabelDatasourceId")]
        [Validation(Required=false)]
        public string LabelDatasourceId { get; set; }

        [NameInMap("LabelDatasourceTable")]
        [Validation(Required=false)]
        public string LabelDatasourceTable { get; set; }

        [NameInMap("LabelEventTime")]
        [Validation(Required=false)]
        public string LabelEventTime { get; set; }

        [NameInMap("LabelTableId")]
        [Validation(Required=false)]
        public string LabelTableId { get; set; }

        [NameInMap("ModelFeatureId")]
        [Validation(Required=false)]
        public string ModelFeatureId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrainingSetFGTable")]
        [Validation(Required=false)]
        public string TrainingSetFGTable { get; set; }

        [NameInMap("TrainingSetTable")]
        [Validation(Required=false)]
        public string TrainingSetTable { get; set; }

    }

}
