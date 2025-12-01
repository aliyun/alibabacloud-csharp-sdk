// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CompareRuleRequest : TeaModel {
        /// <summary>
        /// <para>Sets the language type for requests and received messages, with a default value of <b>zh</b>. Values:</para>
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
        /// <para>Primary key ID of the previous policy version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11518</para>
        /// </summary>
        [NameInMap("previousRuleVersionId")]
        [Validation(Required=false)]
        public long? PreviousRuleVersionId { get; set; }

        /// <summary>
        /// <para>Region code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Primary key ID of the policy version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11519</para>
        /// </summary>
        [NameInMap("ruleVersionId")]
        [Validation(Required=false)]
        public long? RuleVersionId { get; set; }

    }

}
