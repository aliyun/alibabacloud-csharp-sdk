// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeUserQuotaResponseBody : TeaModel {
        /// <summary>
        /// The available elastic AnalyticDB compute units (ACUs).
        /// </summary>
        [NameInMap("ElasticACU")]
        [Validation(Required=false)]
        public string ElasticACU { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The available reserved computing resources.
        /// </summary>
        [NameInMap("ReserverdCompteACU")]
        [Validation(Required=false)]
        public string ReserverdCompteACU { get; set; }

        /// <summary>
        /// The available reserved storage resources.
        /// </summary>
        [NameInMap("ReserverdStorageACU")]
        [Validation(Required=false)]
        public string ReserverdStorageACU { get; set; }

        /// <summary>
        /// The number of available resource groups.
        /// </summary>
        [NameInMap("ResourceGroupCount")]
        [Validation(Required=false)]
        public string ResourceGroupCount { get; set; }

    }

}
