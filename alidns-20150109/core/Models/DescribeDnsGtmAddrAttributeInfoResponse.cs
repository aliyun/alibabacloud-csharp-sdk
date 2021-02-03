// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAddrAttributeInfoResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Addr")]
        [Validation(Required=true)]
        public DescribeDnsGtmAddrAttributeInfoResponseAddr Addr { get; set; }
        public class DescribeDnsGtmAddrAttributeInfoResponseAddr : TeaModel {
            [NameInMap("Addr")]
            [Validation(Required=true)]
            public List<DescribeDnsGtmAddrAttributeInfoResponseAddrAddr> Addr { get; set; }
            public class DescribeDnsGtmAddrAttributeInfoResponseAddrAddr : TeaModel {
                public string Addr { get; set; }
                public DescribeDnsGtmAddrAttributeInfoResponseAddrAddrAttributeInfo AttributeInfo { get; set; }
                public class DescribeDnsGtmAddrAttributeInfoResponseAddrAddrAttributeInfo : TeaModel {
                    [NameInMap("LineCode")]
                    [Validation(Required=true)]
                    public string LineCode { get; set; }

                    [NameInMap("LineName")]
                    [Validation(Required=true)]
                    public string LineName { get; set; }

                    [NameInMap("GroupCode")]
                    [Validation(Required=true)]
                    public string GroupCode { get; set; }

                    [NameInMap("GroupName")]
                    [Validation(Required=true)]
                    public string GroupName { get; set; }

                    [NameInMap("FatherCode")]
                    [Validation(Required=true)]
                    public string FatherCode { get; set; }

                }
            }
        };

    }

}
