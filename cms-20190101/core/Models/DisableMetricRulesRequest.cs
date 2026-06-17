// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DisableMetricRulesRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of the alert rules.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>detect_87****_HTTP_HttpLatency</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public List<string> RuleId { get; set; }

    }

}
