// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DeleteWebFilterRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the web filtering rules to delete. You can specify up to 100 IDs in a single request. The IDs cannot be empty and must be unique.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WebFilterRuleIds")]
        [Validation(Required=false)]
        public string WebFilterRuleIdsShrink { get; set; }

    }

}
