// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SaveLinkeBahamutAdminiterationtemplateRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("FabricBizType")]
        [Validation(Required=false)]
        public string FabricBizType { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("IndependentComplete")]
        [Validation(Required=false)]
        public bool? IndependentComplete { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NeedProject")]
        [Validation(Required=false)]
        public bool? NeedProject { get; set; }

        [NameInMap("NeedWorkItem")]
        [Validation(Required=false)]
        public bool? NeedWorkItem { get; set; }

        [NameInMap("StagesRepeatList")]
        [Validation(Required=false)]
        public List<string> StagesRepeatList { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("XflushCheckEnable")]
        [Validation(Required=false)]
        public bool? XflushCheckEnable { get; set; }

    }

}
