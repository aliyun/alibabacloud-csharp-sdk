// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SenderStatisticsDetailByParamRequest : TeaModel {
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("Length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        [NameInMap("NextStart")]
        [Validation(Required=false)]
        public string NextStart { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        [NameInMap("ToAddress")]
        [Validation(Required=false)]
        public string ToAddress { get; set; }

    }

}
