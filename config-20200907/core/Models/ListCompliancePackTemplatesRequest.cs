// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListCompliancePackTemplatesRequest : TeaModel {
        /// <summary>
        /// The ID of the compliance package template.
        /// 
        /// For more information about how to obtain the ID of a compliance package template, see [ListCompliancePackTemplates](~~261176~~).
        /// </summary>
        [NameInMap("CompliancePackTemplateId")]
        [Validation(Required=false)]
        public string CompliancePackTemplateId { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// Pages start from page 1. Default value: 1
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Valid values: 1 to 100. Minimum value: 1. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The type of the resource evaluated by the rule.
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public string ResourceTypes { get; set; }

    }

}
