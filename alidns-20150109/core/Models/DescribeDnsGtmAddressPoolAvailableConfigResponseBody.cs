// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAddressPoolAvailableConfigResponseBody : TeaModel {
        /// <summary>
        /// The supported source regions.
        /// </summary>
        [NameInMap("AttributeInfos")]
        [Validation(Required=false)]
        public DescribeDnsGtmAddressPoolAvailableConfigResponseBodyAttributeInfos AttributeInfos { get; set; }
        public class DescribeDnsGtmAddressPoolAvailableConfigResponseBodyAttributeInfos : TeaModel {
            [NameInMap("AttributeInfo")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAddressPoolAvailableConfigResponseBodyAttributeInfosAttributeInfo> AttributeInfo { get; set; }
            public class DescribeDnsGtmAddressPoolAvailableConfigResponseBodyAttributeInfosAttributeInfo : TeaModel {
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
                /// The name of the request source group.
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

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
