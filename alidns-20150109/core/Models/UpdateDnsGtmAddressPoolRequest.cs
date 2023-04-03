// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateDnsGtmAddressPoolRequest : TeaModel {
        /// <summary>
        /// The addresses in the address pool.
        /// </summary>
        [NameInMap("Addr")]
        [Validation(Required=false)]
        public List<UpdateDnsGtmAddressPoolRequestAddr> Addr { get; set; }
        public class UpdateDnsGtmAddressPoolRequestAddr : TeaModel {
            /// <summary>
            /// The address.
            /// </summary>
            [NameInMap("Addr")]
            [Validation(Required=false)]
            public string Addr { get; set; }

            /// <summary>
            /// The source region of the address. The value is a JSON string.
            /// 
            /// *   lineCode: the line code of the source region of the address. This parameter is deprecated, and lineCodes prevails.
            /// 
            /// *   lineCodes: the line codes of the source regions of the address.
            /// 
            /// *   lineCodeRectifyType: the rectification type of the line code. Default value: AUTO. Valid values:
            /// 
            ///     *   NO_NEED: no need for rectification
            ///     *   RECTIFIED: rectified
            ///     *   AUTO: automatic rectification
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
            /// The mode of the address. Valid values:
            /// 
            /// *   SMART: smart return
            /// *   ONLINE: always online
            /// *   OFFLINE: always offline
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// The description of the address.
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
        /// The load balancing policy for the address pool. Valid values:
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
