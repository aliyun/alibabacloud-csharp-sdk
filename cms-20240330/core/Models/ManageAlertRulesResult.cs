// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ManageAlertRulesResult : TeaModel {
        [NameInMap("alertRule")]
        [Validation(Required=false)]
        public AlertRuleV2 AlertRule { get; set; }

        /// <summary>
        /// <para>成功删除的规则数量</para>
        /// </summary>
        [NameInMap("deletedCount")]
        [Validation(Required=false)]
        public int? DeletedCount { get; set; }

        /// <summary>
        /// <para>成功删除的规则 UUID 列表</para>
        /// </summary>
        [NameInMap("deletedUuidList")]
        [Validation(Required=false)]
        public List<string> DeletedUuidList { get; set; }

    }

}
