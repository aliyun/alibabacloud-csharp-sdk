// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteCustomMetricRequest : TeaModel {
        /// <summary>
        /// The ID of the application group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The MD5 value of the HTTP request body. The MD5 value is a 128-bit hash value used to verify the uniqueness of the reported monitoring data.
        /// 
        /// >  `Md5` is returned when you query the reported monitoring data of a metric.
        /// </summary>
        [NameInMap("Md5")]
        [Validation(Required=false)]
        public string Md5 { get; set; }

        /// <summary>
        /// The name of the metric.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request for reporting monitoring data.
        /// 
        /// >  `UUID` is returned when you query the reported monitoring data of a metric. We recommend that you specify the `Md5` parameter.
        /// </summary>
        [NameInMap("UUID")]
        [Validation(Required=false)]
        public string UUID { get; set; }

    }

}
