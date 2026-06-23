// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class SaveOrderRelationInfoToMsenceRequest : TeaModel {
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("BizOrderId")]
        [Validation(Required=false)]
        public string BizOrderId { get; set; }

        [NameInMap("BizOrderStatus")]
        [Validation(Required=false)]
        public int? BizOrderStatus { get; set; }

        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public string ClientType { get; set; }

        [NameInMap("CpExtra")]
        [Validation(Required=false)]
        public string CpExtra { get; set; }

        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        [NameInMap("ItemId")]
        [Validation(Required=false)]
        public string ItemId { get; set; }

        [NameInMap("ItemTitle")]
        [Validation(Required=false)]
        public string ItemTitle { get; set; }

        [NameInMap("MiniProgramId")]
        [Validation(Required=false)]
        public string MiniProgramId { get; set; }

        [NameInMap("OpenUid")]
        [Validation(Required=false)]
        public string OpenUid { get; set; }

        [NameInMap("PlatformId")]
        [Validation(Required=false)]
        public string PlatformId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
