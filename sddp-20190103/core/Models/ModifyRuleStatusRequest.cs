// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ModifyRuleStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the sensitive data detection rule.</para>
        /// <remarks>
        /// <para>You can query the ID of the sensitive data detection rule by calling the <b>DescribeRules</b> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12341</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The ID of the sensitive data detection rule. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para>You can query the ID of the sensitive data detection rule by calling the <b>DescribeRules</b> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3,4</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable or disable the sensitive data detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disables the sensitive data detection rule.</description></item>
        /// <item><description><b>1</b>: enables the sensitive data detection rule.</description></item>
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
