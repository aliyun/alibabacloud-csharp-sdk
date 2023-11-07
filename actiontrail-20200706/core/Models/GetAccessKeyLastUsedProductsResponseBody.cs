// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetAccessKeyLastUsedProductsResponseBody : TeaModel {
        /// <summary>
        /// The list of returned Alibaba Cloud services.
        /// </summary>
        [NameInMap("Products")]
        [Validation(Required=false)]
        public List<GetAccessKeyLastUsedProductsResponseBodyProducts> Products { get; set; }
        public class GetAccessKeyLastUsedProductsResponseBodyProducts : TeaModel {
            /// <summary>
            /// The event details.
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// The Alibaba Cloud service.
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// The Chinese name of the Alibaba Cloud service.
            /// </summary>
            [NameInMap("ServiceNameCn")]
            [Validation(Required=false)]
            public string ServiceNameCn { get; set; }

            /// <summary>
            /// The English name of the Alibaba Cloud service.
            /// </summary>
            [NameInMap("ServiceNameEn")]
            [Validation(Required=false)]
            public string ServiceNameEn { get; set; }

            /// <summary>
            /// The event source.
            /// 
            /// Valid values:
            /// 
            /// *   Internal
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     other events
            /// 
            ///     <!-- -->
            /// 
            /// *   ManagementEvent
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     management events
            /// 
            ///     <!-- -->
            /// 
            /// *   DataEvent
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     data events
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// A pagination token. It can be used in the next request to retrieve a new page of results. Unit: millisecond.
            /// </summary>
            [NameInMap("UsedTimestamp")]
            [Validation(Required=false)]
            public long? UsedTimestamp { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
