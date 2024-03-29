// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddLinkeBahamutAddbasejarmoduleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public AddLinkeBahamutAddbasejarmoduleResponseBodyResult Result { get; set; }
        public class AddLinkeBahamutAddbasejarmoduleResponseBodyResult : TeaModel {
            [NameInMap("ProdVersion")]
            [Validation(Required=false)]
            public string ProdVersion { get; set; }
            [NameInMap("Members")]
            [Validation(Required=false)]
            public List<string> Members { get; set; }
            [NameInMap("Stages")]
            [Validation(Required=false)]
            public List<string> Stages { get; set; }
            [NameInMap("CurrentStage")]
            [Validation(Required=false)]
            public string CurrentStage { get; set; }
            [NameInMap("AppMeta")]
            [Validation(Required=false)]
            public string AppMeta { get; set; }
            [NameInMap("CurrentStageStep")]
            [Validation(Required=false)]
            public string CurrentStageStep { get; set; }
            [NameInMap("SkipReleaseCheck")]
            [Validation(Required=false)]
            public bool? SkipReleaseCheck { get; set; }
            [NameInMap("Compatible")]
            [Validation(Required=false)]
            public bool? Compatible { get; set; }
            [NameInMap("CreateAfterUseLinkQ")]
            [Validation(Required=false)]
            public bool? CreateAfterUseLinkQ { get; set; }
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }
            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public List<string> CreatedBy { get; set; }
            [NameInMap("BeforeSit")]
            [Validation(Required=false)]
            public bool? BeforeSit { get; set; }
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }
            [NameInMap("LastStage")]
            [Validation(Required=false)]
            public string LastStage { get; set; }
            [NameInMap("Jars")]
            [Validation(Required=false)]
            public List<string> Jars { get; set; }
            [NameInMap("CreatorSysName")]
            [Validation(Required=false)]
            public string CreatorSysName { get; set; }
            [NameInMap("From")]
            [Validation(Required=false)]
            public string From { get; set; }
            [NameInMap("ProdCode")]
            [Validation(Required=false)]
            public string ProdCode { get; set; }
            [NameInMap("DeletedByIteration")]
            [Validation(Required=false)]
            public bool? DeletedByIteration { get; set; }
            [NameInMap("Private")]
            [Validation(Required=false)]
            public bool? Private { get; set; }
            [NameInMap("NextStage")]
            [Validation(Required=false)]
            public string NextStage { get; set; }
            [NameInMap("Iteration")]
            [Validation(Required=false)]
            public string Iteration { get; set; }
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public long? LastModified { get; set; }
            [NameInMap("Tenant")]
            [Validation(Required=false)]
            public string Tenant { get; set; }
            [NameInMap("YunyDaily")]
            [Validation(Required=false)]
            public bool? YunyDaily { get; set; }
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }
            [NameInMap("BatchIndex")]
            [Validation(Required=false)]
            public long? BatchIndex { get; set; }
            [NameInMap("FromCommitId")]
            [Validation(Required=false)]
            public string FromCommitId { get; set; }
            [NameInMap("JarHistrories")]
            [Validation(Required=false)]
            public List<string> JarHistrories { get; set; }
            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }
            [NameInMap("Finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
        };

    }

}
