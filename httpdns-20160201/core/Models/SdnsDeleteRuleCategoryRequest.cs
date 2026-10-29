// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Httpdns20160201.Models
{
    public class SdnsDeleteRuleCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The policy ID of the current account. This parameter is required. You can obtain the ID from the Id field in the response of CreateSdnsRuleCategory or the list returned by SdnsListRuleCategories. Use a decimal string to prevent precision loss of large integers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789012345678</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
