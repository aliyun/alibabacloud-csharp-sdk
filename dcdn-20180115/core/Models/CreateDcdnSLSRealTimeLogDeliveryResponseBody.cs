// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateDcdnSLSRealTimeLogDeliveryResponseBody : TeaModel {
        /// <summary>
        /// The configuration results of the domain name.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public CreateDcdnSLSRealTimeLogDeliveryResponseBodyContent Content { get; set; }
        public class CreateDcdnSLSRealTimeLogDeliveryResponseBodyContent : TeaModel {
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<CreateDcdnSLSRealTimeLogDeliveryResponseBodyContentDomains> Domains { get; set; }
            public class CreateDcdnSLSRealTimeLogDeliveryResponseBodyContentDomains : TeaModel {
                /// <summary>
                /// The description of the returned result.
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// The domain name from which real-time logs were collected.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The region to which real-time logs were delivered.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The status of real-time logs.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
