/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Advisor20180120.Models
{
    public class DescribeAdvicesRequest : TeaModel {
        [NameInMap("AdviceId")]
        [Validation(Required=false)]
        public long? AdviceId { get; set; }

        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public string CheckId { get; set; }

        [NameInMap("ClientUid")]
        [Validation(Required=false)]
        public long? ClientUid { get; set; }

        [NameInMap("ExcludeAdviceId")]
        [Validation(Required=false)]
        public long? ExcludeAdviceId { get; set; }

        [NameInMap("FilterType")]
        [Validation(Required=false)]
        public string FilterType { get; set; }

        [NameInMap("FilterValue")]
        [Validation(Required=false)]
        public string FilterValue { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
