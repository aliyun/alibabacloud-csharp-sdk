// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySendStatisticsRequest : TeaModel {
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("IsGlobe")]
        [Validation(Required=false)]
        public int? IsGlobe { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public int? TemplateType { get; set; }

    }

}
