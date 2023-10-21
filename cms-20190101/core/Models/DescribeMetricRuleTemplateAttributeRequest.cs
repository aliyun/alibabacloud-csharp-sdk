// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleTemplateAttributeRequest : TeaModel {
        /// <summary>
        /// The name of the alert template. You must specify at least one of the `Name` and `TemplateId` parameters.
        /// 
        /// For more information about how to query the names of alert templates, see [DescribeMetricRuleTemplateList](~~114982~~).
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the alert template. You must specify at least one of the `Name` and `TemplateId` parameters.
        /// 
        /// For more information about how to query the IDs of alert templates, see [DescribeMetricRuleTemplateList](~~114982~~).
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
