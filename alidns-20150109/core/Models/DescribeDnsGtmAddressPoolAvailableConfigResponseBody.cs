// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAddressPoolAvailableConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AttributeInfos")]
        [Validation(Required=false)]
        public List<DescribeDnsGtmAddressPoolAvailableConfigResponseBodyAttributeInfos> AttributeInfos { get; set; }
        public class DescribeDnsGtmAddressPoolAvailableConfigResponseBodyAttributeInfos : TeaModel {
            [NameInMap("FatherCode")]
            [Validation(Required=false)]
            public string FatherCode { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("LineCode")]
            [Validation(Required=false)]
            public string LineCode { get; set; }

            [NameInMap("LineName")]
            [Validation(Required=false)]
            public string LineName { get; set; }

            [NameInMap("GroupCode")]
            [Validation(Required=false)]
            public string GroupCode { get; set; }

        }

    }

}
