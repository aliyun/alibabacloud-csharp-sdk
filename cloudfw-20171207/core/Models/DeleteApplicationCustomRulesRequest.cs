// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DeleteApplicationCustomRulesRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApplicationCustomRuleIds")]
        [Validation(Required=false)]
        public List<string> ApplicationCustomRuleIds { get; set; }

    }

}
