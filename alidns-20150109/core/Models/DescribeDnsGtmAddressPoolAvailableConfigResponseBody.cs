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
        public DescribeDnsGtmAddressPoolAvailableConfigResponseBodyAttributeInfos AttributeInfos { get; set; }
        public class DescribeDnsGtmAddressPoolAvailableConfigResponseBodyAttributeInfos : TeaModel {
            [NameInMap("AttributeInfo")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAddressPoolAvailableConfigResponseBodyAttributeInfosAttributeInfo> AttributeInfo { get; set; }
            public class DescribeDnsGtmAddressPoolAvailableConfigResponseBodyAttributeInfosAttributeInfo : TeaModel {
                public string FatherCode { get; set; }
                public string GroupName { get; set; }
                public string LineCode { get; set; }
                public string LineName { get; set; }
                public string GroupCode { get; set; }
            }
        };

    }

}
