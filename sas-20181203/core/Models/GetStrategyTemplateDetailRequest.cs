// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetStrategyTemplateDetailRequest : TeaModel {
        /// <summary>
        /// The ID of the template.
        /// 
        /// >  You can call the [GetOpaStrategyTemplateSummary](~~GetOpaStrategyTemplateSummary~~) operation to query the IDs of templates.
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

    }

}
