// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class SetHttpDDoSAttackRuleStatusRequest : TeaModel {
        /// <summary>
        /// <para>List of rule IDs to be operated on, separated by English commas (,).</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeHttpDDoSAttackRules~~">DescribeHttpDDoSAttackRules</a> interface to get this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>87570</para>
        /// </summary>
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public string RuleIds { get; set; }

        /// <summary>
        /// <para>Site ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>Rule status</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enable.</description></item>
        /// <item><description><b>off</b>: Disable.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
