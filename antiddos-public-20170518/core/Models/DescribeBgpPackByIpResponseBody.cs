// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeBgpPackByIpResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code of the request.
        /// 
        /// For more information about status codes, see [Common parameters](https://help.aliyun.com/document_detail/118841.html).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The configurations of the instance that is associated with the asset.
        /// </summary>
        [NameInMap("DdosbgpInfo")]
        [Validation(Required=false)]
        public DescribeBgpPackByIpResponseBodyDdosbgpInfo DdosbgpInfo { get; set; }
        public class DescribeBgpPackByIpResponseBodyDdosbgpInfo : TeaModel {
            /// <summary>
            /// The basic protection threshold of the instance. Unit: Gbit/s.
            /// </summary>
            [NameInMap("BaseThreshold")]
            [Validation(Required=false)]
            public int? BaseThreshold { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("DdosbgpInstanceId")]
            [Validation(Required=false)]
            public string DdosbgpInstanceId { get; set; }

            /// <summary>
            /// The burstable protection threshold of the instance. Unit: Gbit/s.
            /// </summary>
            [NameInMap("ElasticThreshold")]
            [Validation(Required=false)]
            public int? ElasticThreshold { get; set; }

            /// <summary>
            /// The expiration time of the instance. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// The IP address of the asset.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
