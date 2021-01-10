// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutIterationsupdateiterationpersonsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryLinkeBahamutIterationsupdateiterationpersonsResponseBodyResult Result { get; set; }
        public class QueryLinkeBahamutIterationsupdateiterationpersonsResponseBodyResult : TeaModel {
            [NameInMap("AoneCodeChangeId")]
            [Validation(Required=false)]
            public string AoneCodeChangeId { get; set; }
            [NameInMap("BranchRelease")]
            [Validation(Required=false)]
            public bool? BranchRelease { get; set; }
            [NameInMap("Compatible")]
            [Validation(Required=false)]
            public bool? Compatible { get; set; }
            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }
            [NameInMap("CreatorSysName")]
            [Validation(Required=false)]
            public string CreatorSysName { get; set; }
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }
            [NameInMap("Emergency")]
            [Validation(Required=false)]
            public bool? Emergency { get; set; }
            [NameInMap("ExternalId")]
            [Validation(Required=false)]
            public string ExternalId { get; set; }
            [NameInMap("FabricBizType")]
            [Validation(Required=false)]
            public string FabricBizType { get; set; }
            [NameInMap("Finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }
            [NameInMap("GreyRelease")]
            [Validation(Required=false)]
            public string GreyRelease { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("IndependentComplete")]
            [Validation(Required=false)]
            public bool? IndependentComplete { get; set; }
            [NameInMap("IterationManager")]
            [Validation(Required=false)]
            public string IterationManager { get; set; }
            [NameInMap("IterationTemplate")]
            [Validation(Required=false)]
            public string IterationTemplate { get; set; }
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public long? LastModified { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("OriginalRelease")]
            [Validation(Required=false)]
            public string OriginalRelease { get; set; }
            [NameInMap("OverdueApplyModifyReleaseId")]
            [Validation(Required=false)]
            public string OverdueApplyModifyReleaseId { get; set; }
            [NameInMap("PrePubOwner")]
            [Validation(Required=false)]
            public string PrePubOwner { get; set; }
            [NameInMap("PrivateAppGroup")]
            [Validation(Required=false)]
            public string PrivateAppGroup { get; set; }
            [NameInMap("ProdCode")]
            [Validation(Required=false)]
            public string ProdCode { get; set; }
            [NameInMap("ProdVersion")]
            [Validation(Required=false)]
            public string ProdVersion { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }
            [NameInMap("Release")]
            [Validation(Required=false)]
            public string Release { get; set; }
            [NameInMap("StageStep")]
            [Validation(Required=false)]
            public string StageStep { get; set; }
            [NameInMap("TagAndMergeMasterWhenEmergency")]
            [Validation(Required=false)]
            public bool? TagAndMergeMasterWhenEmergency { get; set; }
            [NameInMap("TecRiskOwner")]
            [Validation(Required=false)]
            public string TecRiskOwner { get; set; }
            [NameInMap("Tenant")]
            [Validation(Required=false)]
            public string Tenant { get; set; }
            [NameInMap("TestOwner")]
            [Validation(Required=false)]
            public string TestOwner { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("UseBaselineToRelease")]
            [Validation(Required=false)]
            public bool? UseBaselineToRelease { get; set; }
            [NameInMap("XflushCheckEnable")]
            [Validation(Required=false)]
            public bool? XflushCheckEnable { get; set; }
            [NameInMap("AppMetaIds")]
            [Validation(Required=false)]
            public List<string> AppMetaIds { get; set; }
            [NameInMap("AppMetaNames")]
            [Validation(Required=false)]
            public List<string> AppMetaNames { get; set; }
            [NameInMap("AuditProds")]
            [Validation(Required=false)]
            public List<string> AuditProds { get; set; }
            [NameInMap("Defects")]
            [Validation(Required=false)]
            public List<string> Defects { get; set; }
            [NameInMap("Members")]
            [Validation(Required=false)]
            public List<string> Members { get; set; }
            [NameInMap("PaasApplyIds")]
            [Validation(Required=false)]
            public List<string> PaasApplyIds { get; set; }
            [NameInMap("Requirements")]
            [Validation(Required=false)]
            public List<string> Requirements { get; set; }
            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<string> Tasks { get; set; }
        };

    }

}
