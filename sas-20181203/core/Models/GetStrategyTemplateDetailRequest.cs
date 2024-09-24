// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetStrategyTemplateDetailRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the template.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~GetOpaStrategyTemplateSummary~~">GetOpaStrategyTemplateSummary</a> operation to query the IDs of templates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

    }

}
