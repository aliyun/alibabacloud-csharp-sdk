// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutReleasebyexternalidResponseBody : TeaModel {
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
        public GetLinkeBahamutReleasebyexternalidResponseBodyResult Result { get; set; }
        public class GetLinkeBahamutReleasebyexternalidResponseBodyResult : TeaModel {
            [NameInMap("AfterFastDevDate")]
            [Validation(Required=false)]
            public bool? AfterFastDevDate { get; set; }
            [NameInMap("AoneReleaseId")]
            [Validation(Required=false)]
            public string AoneReleaseId { get; set; }
            [NameInMap("AppGroup")]
            [Validation(Required=false)]
            public string AppGroup { get; set; }
            [NameInMap("Attachable")]
            [Validation(Required=false)]
            public bool? Attachable { get; set; }
            [NameInMap("BetaRelease")]
            [Validation(Required=false)]
            public bool? BetaRelease { get; set; }
            [NameInMap("ContainPreInMultiEnv")]
            [Validation(Required=false)]
            public bool? ContainPreInMultiEnv { get; set; }
            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }
            [NameInMap("DailyRelease")]
            [Validation(Required=false)]
            public bool? DailyRelease { get; set; }
            [NameInMap("Deadlines")]
            [Validation(Required=false)]
            public string Deadlines { get; set; }
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }
            [NameInMap("Dependencies")]
            [Validation(Required=false)]
            public string Dependencies { get; set; }
            [NameInMap("ExternalId")]
            [Validation(Required=false)]
            public string ExternalId { get; set; }
            [NameInMap("GreenChannelId")]
            [Validation(Required=false)]
            public string GreenChannelId { get; set; }
            [NameInMap("GreenChannelName")]
            [Validation(Required=false)]
            public string GreenChannelName { get; set; }
            [NameInMap("GreenChannelPortalUrl")]
            [Validation(Required=false)]
            public string GreenChannelPortalUrl { get; set; }
            [NameInMap("HasCreatedAppReleaseDetail")]
            [Validation(Required=false)]
            public bool? HasCreatedAppReleaseDetail { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("IterationType")]
            [Validation(Required=false)]
            public string IterationType { get; set; }
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public long? LastModified { get; set; }
            [NameInMap("MergeStartTime")]
            [Validation(Required=false)]
            public long? MergeStartTime { get; set; }
            [NameInMap("MultiEnvProd")]
            [Validation(Required=false)]
            public bool? MultiEnvProd { get; set; }
            [NameInMap("MultiEnvRelease")]
            [Validation(Required=false)]
            public bool? MultiEnvRelease { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("ReleaseDate")]
            [Validation(Required=false)]
            public long? ReleaseDate { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("TagAndMergeMasterWhenEmergency")]
            [Validation(Required=false)]
            public bool? TagAndMergeMasterWhenEmergency { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }
            [NameInMap("Ticket")]
            [Validation(Required=false)]
            public string Ticket { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("WindowRelease")]
            [Validation(Required=false)]
            public bool? WindowRelease { get; set; }
            [NameInMap("Apps")]
            [Validation(Required=false)]
            public List<string> Apps { get; set; }
            [NameInMap("DelAppMetaIds")]
            [Validation(Required=false)]
            public List<string> DelAppMetaIds { get; set; }
            [NameInMap("Iterations")]
            [Validation(Required=false)]
            public List<string> Iterations { get; set; }
            [NameInMap("Managers")]
            [Validation(Required=false)]
            public List<string> Managers { get; set; }
            [NameInMap("MultiEnvConfigs")]
            [Validation(Required=false)]
            public List<string> MultiEnvConfigs { get; set; }
            [NameInMap("Stages")]
            [Validation(Required=false)]
            public List<string> Stages { get; set; }
            [NameInMap("TenantReleaseInfos")]
            [Validation(Required=false)]
            public List<string> TenantReleaseInfos { get; set; }
        };

    }

}
