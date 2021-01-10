// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeBahamutIterationsdocreateRequest : TeaModel {
        [NameInMap("AoneCodeChangeId")]
        [Validation(Required=false)]
        public string AoneCodeChangeId { get; set; }

        [NameInMap("AppMembers")]
        [Validation(Required=false)]
        public string AppMembers { get; set; }

        [NameInMap("BranchMap")]
        [Validation(Required=false)]
        public string BranchMap { get; set; }

        [NameInMap("BranchPostfixMap")]
        [Validation(Required=false)]
        public string BranchPostfixMap { get; set; }

        [NameInMap("Compatible")]
        [Validation(Required=false)]
        public bool? Compatible { get; set; }

        [NameInMap("CreatorSysName")]
        [Validation(Required=false)]
        public string CreatorSysName { get; set; }

        [NameInMap("DeliverId")]
        [Validation(Required=false)]
        public string DeliverId { get; set; }

        [NameInMap("GreenChannel")]
        [Validation(Required=false)]
        public string GreenChannel { get; set; }

        [NameInMap("IsBranchRelease")]
        [Validation(Required=false)]
        public bool? IsBranchRelease { get; set; }

        [NameInMap("IterationId")]
        [Validation(Required=false)]
        public string IterationId { get; set; }

        [NameInMap("IterationManager")]
        [Validation(Required=false)]
        public string IterationManager { get; set; }

        [NameInMap("IterationTemplateId")]
        [Validation(Required=false)]
        public string IterationTemplateId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PrePubOwner")]
        [Validation(Required=false)]
        public string PrePubOwner { get; set; }

        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        [NameInMap("ProdVersion")]
        [Validation(Required=false)]
        public string ProdVersion { get; set; }

        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("TagAndMergeMasterWhenEmergency")]
        [Validation(Required=false)]
        public bool? TagAndMergeMasterWhenEmergency { get; set; }

        [NameInMap("TagMap")]
        [Validation(Required=false)]
        public string TagMap { get; set; }

        [NameInMap("TecRiskOwner")]
        [Validation(Required=false)]
        public string TecRiskOwner { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("TestOwner")]
        [Validation(Required=false)]
        public string TestOwner { get; set; }

        [NameInMap("UserAccount")]
        [Validation(Required=false)]
        public string UserAccount { get; set; }

        [NameInMap("AppNamesRepeatList")]
        [Validation(Required=false)]
        public List<string> AppNamesRepeatList { get; set; }

        [NameInMap("AuditProdsRepeatList")]
        [Validation(Required=false)]
        public List<string> AuditProdsRepeatList { get; set; }

        [NameInMap("IterationMembersRepeatList")]
        [Validation(Required=false)]
        public List<string> IterationMembersRepeatList { get; set; }

        [NameInMap("PubOwnersRepeatList")]
        [Validation(Required=false)]
        public List<string> PubOwnersRepeatList { get; set; }

        [NameInMap("VersionsRepeatList")]
        [Validation(Required=false)]
        public List<string> VersionsRepeatList { get; set; }

        [NameInMap("WorkItemsRepeatList")]
        [Validation(Required=false)]
        public List<string> WorkItemsRepeatList { get; set; }

    }

}
