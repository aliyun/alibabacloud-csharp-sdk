// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class ValuateTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("AreaId")]
        [Validation(Required=false)]
        public string AreaId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The instances to be replaced.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public string InstancesShrink { get; set; }

        /// <summary>
        /// The ID of the resource group to which the application belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The template ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The parameter values that are contained in the template. If the template contains no parameter values, the default values are used.
        /// </summary>
        [NameInMap("Variables")]
        [Validation(Required=false)]
        public string VariablesShrink { get; set; }

    }

}
