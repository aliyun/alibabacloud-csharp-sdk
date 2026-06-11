// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleAction : TeaModel {
        /// <summary>
        /// <para>A list of action integration IDs.</para>
        /// </summary>
        [NameInMap("actions")]
        [Validation(Required=false)]
        public List<string> Actions { get; set; }

    }

}
