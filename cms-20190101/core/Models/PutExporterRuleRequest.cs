// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutExporterRuleRequest : TeaModel {
        /// <summary>
        /// The description of the data export rule.
        /// </summary>
        [NameInMap("Describe")]
        [Validation(Required=false)]
        public string Describe { get; set; }

        /// <summary>
        /// The destination to which the data is exported. Valid values of N: 1 to 20.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DstNames")]
        [Validation(Required=false)]
        public List<string> DstNames { get; set; }

        /// <summary>
        /// The name of the metric.
        /// 
        /// > 
        /// 
        /// For more information, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The namespace of the cloud service.
        /// 
        /// > For more information, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the rule.
        /// 
        /// > If the specified rule exists, the existing rule is modified. Otherwise, a rule is created.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The time window of the exported data. Unit: seconds.
        /// 
        /// > 
        /// 
        /// *   Separate multiple time windows with commas (,).
        /// 
        /// *   Data in a time window of less than 60 seconds cannot be exported.
        /// </summary>
        [NameInMap("TargetWindows")]
        [Validation(Required=false)]
        public string TargetWindows { get; set; }

    }

}
