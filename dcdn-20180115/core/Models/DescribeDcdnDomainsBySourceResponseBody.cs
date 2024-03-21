// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainsBySourceResponseBody : TeaModel {
        /// <summary>
        /// The information about each origin server and the corresponding domain names.
        /// </summary>
        [NameInMap("DomainInfo")]
        [Validation(Required=false)]
        public List<DescribeDcdnDomainsBySourceResponseBodyDomainInfo> DomainInfo { get; set; }
        public class DescribeDcdnDomainsBySourceResponseBodyDomainInfo : TeaModel {
            /// <summary>
            /// The information about the domain names.
            /// </summary>
            [NameInMap("DomainList")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainsBySourceResponseBodyDomainInfoDomainList> DomainList { get; set; }
            public class DescribeDcdnDomainsBySourceResponseBodyDomainInfoDomainList : TeaModel {
                /// <summary>
                /// The creation time.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The CNAME record assigned to the domain name.
                /// </summary>
                [NameInMap("DomainCname")]
                [Validation(Required=false)]
                public string DomainCname { get; set; }

                /// <summary>
                /// The accelerated domain name.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The workload type of the accelerated domain name. Valid value:
                /// 
                /// *   **ipa**: layer 4 acceleration
                /// *   **dynamic**: layer 7 acceleration
                /// </summary>
                [NameInMap("DomainType")]
                [Validation(Required=false)]
                public string DomainType { get; set; }

                /// <summary>
                /// The status of the domain name. Valid value:
                /// 
                /// *   **applying**: The domain name is under review.
                /// *   **configuring**: The domain name is being configured.
                /// *   **online**: The domain name is working as expected.
                /// *   **stopping**: The domain name is being stopped.
                /// *   **offline**: The domain name is disabled.
                /// *   **disabling**: The domain name is being removed.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The time when the domain name was updated.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// The origin server.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
