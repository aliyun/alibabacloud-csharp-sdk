// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class CreateIssueCategoryReportRelationRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RelationModelList")]
        [Validation(Required=false)]
        public List<CreateIssueCategoryReportRelationRequestRelationModelList> RelationModelList { get; set; }
        public class CreateIssueCategoryReportRelationRequestRelationModelList : TeaModel {
            [NameInMap("CustomerInputContent")]
            [Validation(Required=false)]
            public string CustomerInputContent { get; set; }

            [NameInMap("IssueCategoryId")]
            [Validation(Required=false)]
            public long? IssueCategoryId { get; set; }

            [NameInMap("IssueCategoryName")]
            [Validation(Required=false)]
            public string IssueCategoryName { get; set; }

            [NameInMap("MappingTools")]
            [Validation(Required=false)]
            public string MappingTools { get; set; }

            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

        }

    }

}
