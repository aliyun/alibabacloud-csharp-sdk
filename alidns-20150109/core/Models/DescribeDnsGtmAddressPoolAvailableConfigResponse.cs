// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAddressPoolAvailableConfigResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("AttributeInfos")]
        [Validation(Required=true)]
        public DescribeDnsGtmAddressPoolAvailableConfigResponseAttributeInfos AttributeInfos { get; set; }
        public class DescribeDnsGtmAddressPoolAvailableConfigResponseAttributeInfos : TeaModel {
            [NameInMap("AttributeInfo")]
            [Validation(Required=true)]
            public List<DescribeDnsGtmAddressPoolAvailableConfigResponseAttributeInfosAttributeInfo> AttributeInfo { get; set; }
            public class DescribeDnsGtmAddressPoolAvailableConfigResponseAttributeInfosAttributeInfo : TeaModel {
                public string LineCode { get; set; }
                public string LineName { get; set; }
                public string GroupCode { get; set; }
                public string GroupName { get; set; }
                public string FatherCode { get; set; }
            }
        };

    }

}
