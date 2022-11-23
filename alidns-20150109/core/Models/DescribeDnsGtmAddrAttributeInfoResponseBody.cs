// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAddrAttributeInfoResponseBody : TeaModel {
        [NameInMap("Addr")]
        [Validation(Required=false)]
        public DescribeDnsGtmAddrAttributeInfoResponseBodyAddr Addr { get; set; }
        public class DescribeDnsGtmAddrAttributeInfoResponseBodyAddr : TeaModel {
            [NameInMap("Addr")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAddrAttributeInfoResponseBodyAddrAddr> Addr { get; set; }
            public class DescribeDnsGtmAddrAttributeInfoResponseBodyAddrAddr : TeaModel {
                [NameInMap("Addr")]
                [Validation(Required=false)]
                public string Addr { get; set; }

                [NameInMap("AttributeInfo")]
                [Validation(Required=false)]
                public DescribeDnsGtmAddrAttributeInfoResponseBodyAddrAddrAttributeInfo AttributeInfo { get; set; }
                public class DescribeDnsGtmAddrAttributeInfoResponseBodyAddrAddrAttributeInfo : TeaModel {
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

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
