// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class GetModelFeatureResponseBody : TeaModel {
        [NameInMap("ExportTrainingSetTableScript")]
        [Validation(Required=false)]
        public string ExportTrainingSetTableScript { get; set; }

        [NameInMap("Features")]
        [Validation(Required=false)]
        public List<GetModelFeatureResponseBodyFeatures> Features { get; set; }
        public class GetModelFeatureResponseBodyFeatures : TeaModel {
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

        [NameInMap("LabelPriorityLevel")]
        [Validation(Required=false)]
        public long? LabelPriorityLevel { get; set; }

        [NameInMap("LabelTableId")]
        [Validation(Required=false)]
        public string LabelTableId { get; set; }

        [NameInMap("LabelTableName")]
        [Validation(Required=false)]
        public string LabelTableName { get; set; }

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

        [NameInMap("Relations")]
        [Validation(Required=false)]
        public GetModelFeatureResponseBodyRelations Relations { get; set; }
        public class GetModelFeatureResponseBodyRelations : TeaModel {
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<GetModelFeatureResponseBodyRelationsDomains> Domains { get; set; }
            public class GetModelFeatureResponseBodyRelationsDomains : TeaModel {
                [NameInMap("DomainType")]
                [Validation(Required=false)]
                public string DomainType { get; set; }

                /// <summary>
                /// Domain ID。
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Links")]
            [Validation(Required=false)]
            public List<GetModelFeatureResponseBodyRelationsLinks> Links { get; set; }
            public class GetModelFeatureResponseBodyRelationsLinks : TeaModel {
                [NameInMap("From")]
                [Validation(Required=false)]
                public string From { get; set; }

                [NameInMap("Link")]
                [Validation(Required=false)]
                public string Link { get; set; }

                [NameInMap("To")]
                [Validation(Required=false)]
                public string To { get; set; }

            }

        }

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
