// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeLinkaMngtasksummaryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ClassesFileId")]
        [Validation(Required=false)]
        public string ClassesFileId { get; set; }

        [NameInMap("CoverageFileId")]
        [Validation(Required=false)]
        public string CoverageFileId { get; set; }

        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("Deleted")]
        [Validation(Required=false)]
        public bool? Deleted { get; set; }

        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("OnlySummary")]
        [Validation(Required=false)]
        public bool? OnlySummary { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

        [NameInMap("SubCoverages")]
        [Validation(Required=false)]
        public List<QueryLinkeLinkaMngtasksummaryResponseBodySubCoverages> SubCoverages { get; set; }
        public class QueryLinkeLinkaMngtasksummaryResponseBodySubCoverages : TeaModel {
            [NameInMap("ClassesFileId")]
            [Validation(Required=false)]
            public string ClassesFileId { get; set; }

            [NameInMap("CoverageFileId")]
            [Validation(Required=false)]
            public string CoverageFileId { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("OnlySummary")]
            [Validation(Required=false)]
            public bool? OnlySummary { get; set; }

            [NameInMap("Reset")]
            [Validation(Required=false)]
            public bool? Reset { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("SourceKind")]
            [Validation(Required=false)]
            public string SourceKind { get; set; }

            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }

        }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public QueryLinkeLinkaMngtasksummaryResponseBodySummary Summary { get; set; }
        public class QueryLinkeLinkaMngtasksummaryResponseBodySummary : TeaModel {
            [NameInMap("BranchCovered")]
            [Validation(Required=false)]
            public long? BranchCovered { get; set; }
            [NameInMap("BranchTotal")]
            [Validation(Required=false)]
            public long? BranchTotal { get; set; }
            [NameInMap("ClassCovered")]
            [Validation(Required=false)]
            public long? ClassCovered { get; set; }
            [NameInMap("ClassTotal")]
            [Validation(Required=false)]
            public long? ClassTotal { get; set; }
            [NameInMap("CoverageId")]
            [Validation(Required=false)]
            public string CoverageId { get; set; }
            [NameInMap("CxtyCovered")]
            [Validation(Required=false)]
            public long? CxtyCovered { get; set; }
            [NameInMap("CxtyTotal")]
            [Validation(Required=false)]
            public long? CxtyTotal { get; set; }
            [NameInMap("Fullname")]
            [Validation(Required=false)]
            public string Fullname { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("InstrCovered")]
            [Validation(Required=false)]
            public long? InstrCovered { get; set; }
            [NameInMap("InstrTotal")]
            [Validation(Required=false)]
            public long? InstrTotal { get; set; }
            [NameInMap("LineCovered")]
            [Validation(Required=false)]
            public long? LineCovered { get; set; }
            [NameInMap("LineTotal")]
            [Validation(Required=false)]
            public long? LineTotal { get; set; }
            [NameInMap("MethodCovered")]
            [Validation(Required=false)]
            public long? MethodCovered { get; set; }
            [NameInMap("MethodTotal")]
            [Validation(Required=false)]
            public long? MethodTotal { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

    }

}
