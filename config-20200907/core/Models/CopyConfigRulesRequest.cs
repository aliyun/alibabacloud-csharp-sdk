// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CopyConfigRulesRequest : TeaModel {
        [NameInMap("DesAggregatorIds")]
        [Validation(Required=false)]
        public string DesAggregatorIds { get; set; }

        [NameInMap("SrcAggregatorId")]
        [Validation(Required=false)]
        public string SrcAggregatorId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SrcConfigRuleIds")]
        [Validation(Required=false)]
        public string SrcConfigRuleIds { get; set; }

    }

}
