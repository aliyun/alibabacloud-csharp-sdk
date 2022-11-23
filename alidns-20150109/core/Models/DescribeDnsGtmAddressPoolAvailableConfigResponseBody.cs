// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAddressPoolAvailableConfigResponseBody : TeaModel {
        [NameInMap("AttributeInfos")]
        [Validation(Required=false)]
        public DescribeDnsGtmAddressPoolAvailableConfigResponseBodyAttributeInfos AttributeInfos { get; set; }
        public class DescribeDnsGtmAddressPoolAvailableConfigResponseBodyAttributeInfos : TeaModel {
            [NameInMap("AttributeInfo")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAddressPoolAvailableConfigResponseBodyAttributeInfosAttributeInfo> AttributeInfo { get; set; }
            public class DescribeDnsGtmAddressPoolAvailableConfigResponseBodyAttributeInfosAttributeInfo : TeaModel {
                [NameInMap("FatherCode")]
                [Validation(Required=false)]
                public string FatherCode { get; set; }

                [NameInMap("GroupCode")]
                [Validation(Required=false)]
                public string GroupCode { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("LineCode")]
                [Validation(Required=false)]
                public string LineCode { get; set; }

                [NameInMap("LineName")]
                [Validation(Required=false)]
                public string LineName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
