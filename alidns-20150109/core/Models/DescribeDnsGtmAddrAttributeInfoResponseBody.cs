// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAddrAttributeInfoResponseBody : TeaModel {
        /// <summary>
        /// The addresses that were queried.
        /// </summary>
        [NameInMap("Addr")]
        [Validation(Required=false)]
        public DescribeDnsGtmAddrAttributeInfoResponseBodyAddr Addr { get; set; }
        public class DescribeDnsGtmAddrAttributeInfoResponseBodyAddr : TeaModel {
            [NameInMap("Addr")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAddrAttributeInfoResponseBodyAddrAddr> Addr { get; set; }
            public class DescribeDnsGtmAddrAttributeInfoResponseBodyAddrAddr : TeaModel {
                /// <summary>
                /// The address that was queried.
                /// </summary>
                [NameInMap("Addr")]
                [Validation(Required=false)]
                public string Addr { get; set; }

                /// <summary>
                /// The source region of the address.
                /// </summary>
                [NameInMap("AttributeInfo")]
                [Validation(Required=false)]
                public DescribeDnsGtmAddrAttributeInfoResponseBodyAddrAddrAttributeInfo AttributeInfo { get; set; }
                public class DescribeDnsGtmAddrAttributeInfoResponseBodyAddrAddrAttributeInfo : TeaModel {
                    /// <summary>
                    /// The parent line code of the source region.
                    /// </summary>
                    [NameInMap("FatherCode")]
                    [Validation(Required=false)]
                    public string FatherCode { get; set; }

                    /// <summary>
                    /// The code of the source region group.
                    /// </summary>
                    [NameInMap("GroupCode")]
                    [Validation(Required=false)]
                    public string GroupCode { get; set; }

                    /// <summary>
                    /// The name of the source region group.
                    /// </summary>
                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// The line code of the source region.
                    /// </summary>
                    [NameInMap("LineCode")]
                    [Validation(Required=false)]
                    public string LineCode { get; set; }

                    /// <summary>
                    /// The line name of the source region.
                    /// </summary>
                    [NameInMap("LineName")]
                    [Validation(Required=false)]
                    public string LineName { get; set; }

                }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
