// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateDnsGtmAddressPoolRequest : TeaModel {
        /// <summary>
        /// The address pools.
        /// </summary>
        [NameInMap("Addr")]
        [Validation(Required=false)]
        public List<UpdateDnsGtmAddressPoolRequestAddr> Addr { get; set; }
        public class UpdateDnsGtmAddressPoolRequestAddr : TeaModel {
            /// <summary>
            /// The address in the address pool.
            /// </summary>
            [NameInMap("Addr")]
            [Validation(Required=false)]
            public string Addr { get; set; }

            /// <summary>
            /// The source region of the address, in JSON-formatted string.
            /// 
            /// *   LineCode: the line code of the source region of the address. The LineCode field is deprecated, and the lineCodes field is used as a substitute.
            /// 
            /// *   LineCodes: the line code list of the source regions of addresses.
            /// 
            /// *   lineCodeRectifyType: the rectification type of the line codes. Default value: AUTO. Valid values:
            /// 
            ///     *   NO_NEED: no need for rectification.
            ///     *   RECTIFIED: rectified.
            ///     *   AUTO: automatic rectification.
            /// </summary>
            [NameInMap("AttributeInfo")]
            [Validation(Required=false)]
            public string AttributeInfo { get; set; }

            /// <summary>
            /// The weight of the address.
            /// </summary>
            [NameInMap("LbaWeight")]
            [Validation(Required=false)]
            public int? LbaWeight { get; set; }

            /// <summary>
            /// The response mode: Valid values:
            /// 
            /// *   SMART: smart return.
            /// *   ONLINE: always online.
            /// *   OFFLINE: always offline.
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// The additional information about the address.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// The ID of the address pool.
        /// </summary>
        [NameInMap("AddrPoolId")]
        [Validation(Required=false)]
        public string AddrPoolId { get; set; }

        /// <summary>
        /// The language of the values of specific response parameters. Default value: en. Valid values: en, zh, and ja.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The load balancing policy of the address pool. Valid values:
        /// 
        /// *   ALL_RR: returns all addresses.
        /// *   RATIO: returns addresses by weight.
        /// </summary>
        [NameInMap("LbaStrategy")]
        [Validation(Required=false)]
        public string LbaStrategy { get; set; }

        /// <summary>
        /// The name of the address pool.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
