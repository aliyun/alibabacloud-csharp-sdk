// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alicloudproc20240104.Models
{
    public class CreateSourcingProjectShrinkRequest : TeaModel {
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string AddressShrink { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BizNo")]
        [Validation(Required=false)]
        public string BizNo { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("Company")]
        [Validation(Required=false)]
        public string CompanyShrink { get; set; }

        [NameInMap("Contact")]
        [Validation(Required=false)]
        public string ContactShrink { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public string ExtendInfoShrink { get; set; }

        [NameInMap("SourceUrl")]
        [Validation(Required=false)]
        public string SourceUrl { get; set; }

        [NameInMap("SubBizType")]
        [Validation(Required=false)]
        public string SubBizType { get; set; }

        [NameInMap("Subjects")]
        [Validation(Required=false)]
        public string SubjectsShrink { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
