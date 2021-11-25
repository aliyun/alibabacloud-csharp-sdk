// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xixikf20200730.Models
{
    public class CreateTicketRequest : TeaModel {
        [NameInMap("CarbonCopy")]
        [Validation(Required=false)]
        public string CarbonCopy { get; set; }

        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public long? CreatorId { get; set; }

        [NameInMap("CreatorName")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        [NameInMap("CreatorType")]
        [Validation(Required=false)]
        public int? CreatorType { get; set; }

        [NameInMap("FormData")]
        [Validation(Required=false)]
        public string FormData { get; set; }

        [NameInMap("FromInfo")]
        [Validation(Required=false)]
        public string FromInfo { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public long? MemberId { get; set; }

        [NameInMap("MemberName")]
        [Validation(Required=false)]
        public string MemberName { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
