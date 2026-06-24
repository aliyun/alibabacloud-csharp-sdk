// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ModifyRuleStatusRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the sensitive data detection rule.</para>
        /// <remarks>
        /// <para>To enable or disable the detection feature for a sensitive data detection rule, provide the unique ID of the rule. Call the <b>DescribeRules</b> operation to obtain the ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12341</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The unique IDs of the sensitive data detection rules. Separate multiple IDs with commas.</para>
        /// <remarks>
        /// <para>To enable or disable the detection feature for sensitive data detection rules, provide the unique IDs of the rules. Call the <b>DescribeRules</b> operation to obtain the IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3,4</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable or disable the detection feature for the sensitive data detection rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Disable.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Enable.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
