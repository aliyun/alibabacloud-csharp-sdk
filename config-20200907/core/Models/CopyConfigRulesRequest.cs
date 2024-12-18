// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CopyConfigRulesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the destination account groups into which the rules are replicated. Separate multiple account group IDs with commas (,).</para>
        /// <remarks>
        /// <para>If you leave this parameter empty, the compliance packages are replicated into the same account group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ca-4b4e626622af005d****</para>
        /// </summary>
        [NameInMap("DesAggregatorIds")]
        [Validation(Required=false)]
        public string DesAggregatorIds { get; set; }

        /// <summary>
        /// <para>The ID of the account group to which the rules belong.</para>
        /// <para>For more information about how to obtain the ID of an account group, see <a href="https://help.aliyun.com/document_detail/255797.html">ListAggregators</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-24db626622af0060****</para>
        /// </summary>
        [NameInMap("SrcAggregatorId")]
        [Validation(Required=false)]
        public string SrcAggregatorId { get; set; }

        /// <summary>
        /// <para>The rule IDs. Separate multiple rule IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cr-4b57626622af0065****,cr-47c1626622af0050****</para>
        /// </summary>
        [NameInMap("SrcConfigRuleIds")]
        [Validation(Required=false)]
        public string SrcConfigRuleIds { get; set; }

    }

}
