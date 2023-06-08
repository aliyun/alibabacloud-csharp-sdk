// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class UpdateDcdnSLSRealtimeLogDeliveryResponseBody : TeaModel {
        /// <summary>
        /// The configuration results of the domain name.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public UpdateDcdnSLSRealtimeLogDeliveryResponseBodyContent Content { get; set; }
        public class UpdateDcdnSLSRealtimeLogDeliveryResponseBodyContent : TeaModel {
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<UpdateDcdnSLSRealtimeLogDeliveryResponseBodyContentDomains> Domains { get; set; }
            public class UpdateDcdnSLSRealtimeLogDeliveryResponseBodyContentDomains : TeaModel {
                /// <summary>
                /// The description of the returned result.
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// The domain name.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The name of the region.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// Indicates whether the real-time log delivery project was successfully updated. Valid values:
                /// 
                /// *   **success**
                /// *   **fail**
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
