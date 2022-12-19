// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The number of container images in your assets. Only Container Registry Enterprise Edition instances are counted.
        /// </summary>
        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of container images that have security risks. Only Container Registry Enterprise Edition instances are counted.
        /// </summary>
        [NameInMap("RiskInstanceCount")]
        [Validation(Required=false)]
        public int? RiskInstanceCount { get; set; }

    }

}
