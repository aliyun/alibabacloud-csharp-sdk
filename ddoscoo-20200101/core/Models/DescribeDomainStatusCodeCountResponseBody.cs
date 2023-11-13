// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainStatusCodeCountResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of 200 status codes within the specified period of time.
        /// </summary>
        [NameInMap("Status200")]
        [Validation(Required=false)]
        public long? Status200 { get; set; }

        /// <summary>
        /// The number of 2xx status codes within the specified period of time.
        /// </summary>
        [NameInMap("Status2XX")]
        [Validation(Required=false)]
        public long? Status2XX { get; set; }

        /// <summary>
        /// The number of 3xx status codes within the specified period of time.
        /// </summary>
        [NameInMap("Status3XX")]
        [Validation(Required=false)]
        public long? Status3XX { get; set; }

        /// <summary>
        /// The number of 403 status codes within the specified period of time.
        /// </summary>
        [NameInMap("Status403")]
        [Validation(Required=false)]
        public long? Status403 { get; set; }

        /// <summary>
        /// The number of 404 status codes within the specified period of time.
        /// </summary>
        [NameInMap("Status404")]
        [Validation(Required=false)]
        public long? Status404 { get; set; }

        /// <summary>
        /// The number of 405 status codes within the specified period of time.
        /// </summary>
        [NameInMap("Status405")]
        [Validation(Required=false)]
        public long? Status405 { get; set; }

        /// <summary>
        /// The number of 4xx status codes within the specified period of time.
        /// </summary>
        [NameInMap("Status4XX")]
        [Validation(Required=false)]
        public long? Status4XX { get; set; }

        /// <summary>
        /// The number of 501 status codes within the specified period of time.
        /// </summary>
        [NameInMap("Status501")]
        [Validation(Required=false)]
        public long? Status501 { get; set; }

        /// <summary>
        /// The number of 502 status codes within the specified period of time.
        /// </summary>
        [NameInMap("Status502")]
        [Validation(Required=false)]
        public long? Status502 { get; set; }

        /// <summary>
        /// The number of 503 status codes within the specified period of time.
        /// </summary>
        [NameInMap("Status503")]
        [Validation(Required=false)]
        public long? Status503 { get; set; }

        /// <summary>
        /// The number of 504 status codes within the specified period of time.
        /// </summary>
        [NameInMap("Status504")]
        [Validation(Required=false)]
        public long? Status504 { get; set; }

        /// <summary>
        /// The number of 5xx status codes within the specified period of time.
        /// </summary>
        [NameInMap("Status5XX")]
        [Validation(Required=false)]
        public long? Status5XX { get; set; }

    }

}
