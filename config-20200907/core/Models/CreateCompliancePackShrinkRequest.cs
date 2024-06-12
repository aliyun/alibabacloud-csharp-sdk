// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateCompliancePackShrinkRequest : TeaModel {
        /// <summary>
        /// The client token that you want to use to ensure the idempotency of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.``
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The name of the compliance package.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CompliancePackName")]
        [Validation(Required=false)]
        public string CompliancePackName { get; set; }

        /// <summary>
        /// The ID of the compliance package template.
        /// 
        /// You can call the [ListCompliancePackTemplates](https://help.aliyun.com/document_detail/261176.html) operation to obtain the ID of the compliance package.
        /// </summary>
        [NameInMap("CompliancePackTemplateId")]
        [Validation(Required=false)]
        public string CompliancePackTemplateId { get; set; }

        /// <summary>
        /// The rules in the compliance package. You must specify either this parameter or TemplateContent.
        /// </summary>
        [NameInMap("ConfigRules")]
        [Validation(Required=false)]
        public string ConfigRulesShrink { get; set; }

        /// <summary>
        /// Specifies whether to enable the rule together with the compliance package. Valid values:
        /// 
        /// *   true: The system enables the rule together with the compliance package.
        /// *   false: The system does not enable the rule together with the compliance package.
        /// </summary>
        [NameInMap("DefaultEnable")]
        [Validation(Required=false)]
        public bool? DefaultEnable { get; set; }

        /// <summary>
        /// The description of the compliance package.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the resource that you do not want to evaluate by using the compliance package. Separate multiple resource IDs with commas (,).
        /// </summary>
        [NameInMap("ExcludeResourceIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceIdsScope { get; set; }

        /// <summary>
        /// The ID of the region whose resources you want to evaluate by using the compliance package. Separate multiple region IDs with commas (,).
        /// </summary>
        [NameInMap("RegionIdsScope")]
        [Validation(Required=false)]
        public string RegionIdsScope { get; set; }

        /// <summary>
        /// The ID of the resource group whose resources you want to evaluate by using the compliance package. Separate multiple resource group IDs with commas (,).
        /// </summary>
        [NameInMap("ResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ResourceGroupIdsScope { get; set; }

        /// <summary>
        /// The risk level of the resources that are not compliant with the rules in the compliance package. Default value: 2. Valid values:
        /// 
        /// *   1: high.
        /// *   2: medium.
        /// *   3: low.
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public int? RiskLevel { get; set; }

        /// <summary>
        /// The tag key of the resource that you want to evaluate by using the compliance package.
        /// </summary>
        [NameInMap("TagKeyScope")]
        [Validation(Required=false)]
        public string TagKeyScope { get; set; }

        /// <summary>
        /// The tag value of the resource that you want to evaluate by using the compliance package.
        /// 
        /// >  You must configure the TagValueScope parameter together with the TagKeyScope parameter.
        /// </summary>
        [NameInMap("TagValueScope")]
        [Validation(Required=false)]
        public string TagValueScope { get; set; }

        /// <summary>
        /// The information about the template that is used to generate the compliance package. You can call an API operation to view the details of an existing compliance package or write a compliance package template. For more information, see [Write a compliance package template in a configuration file](https://help.aliyun.com/document_detail/2659733.html). You must specify one of ConfigRules and TemplateContent.
        /// </summary>
        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public string TemplateContent { get; set; }

    }

}
