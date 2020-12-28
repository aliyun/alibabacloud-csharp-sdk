// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class QueryExperimentSimpleInfoForMkResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Check")]
        [Validation(Required=false)]
        public List<QueryExperimentSimpleInfoForMkResponseBodyCheck> Check { get; set; }
        public class QueryExperimentSimpleInfoForMkResponseBodyCheck : TeaModel {
            [NameInMap("AppCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("Prepare")]
        [Validation(Required=false)]
        public List<QueryExperimentSimpleInfoForMkResponseBodyPrepare> Prepare { get; set; }
        public class QueryExperimentSimpleInfoForMkResponseBodyPrepare : TeaModel {
            [NameInMap("AppCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("BasicInfo")]
        [Validation(Required=false)]
        public QueryExperimentSimpleInfoForMkResponseBodyBasicInfo BasicInfo { get; set; }
        public class QueryExperimentSimpleInfoForMkResponseBodyBasicInfo : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("ExperimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
        };

        [NameInMap("Attack")]
        [Validation(Required=false)]
        public List<QueryExperimentSimpleInfoForMkResponseBodyAttack> Attack { get; set; }
        public class QueryExperimentSimpleInfoForMkResponseBodyAttack : TeaModel {
            [NameInMap("AppCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("Recover")]
        [Validation(Required=false)]
        public List<QueryExperimentSimpleInfoForMkResponseBodyRecover> Recover { get; set; }
        public class QueryExperimentSimpleInfoForMkResponseBodyRecover : TeaModel {
            [NameInMap("AppCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
