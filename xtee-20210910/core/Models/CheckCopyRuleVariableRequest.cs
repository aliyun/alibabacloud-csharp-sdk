// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CheckCopyRuleVariableRequest : TeaModel {
        /// <summary>
        /// <para>Creation type</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("CreateType")]
        [Validation(Required=false)]
        public string CreateType { get; set; }

        /// <summary>
        /// <para>Sets the language type for requests and received messages, with a default value of <b>zh</b>. Values: </para>
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
        /// <para>Region code</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Source policy ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>102125</para>
        /// </summary>
        [NameInMap("SourceRuleId")]
        [Validation(Required=false)]
        public string SourceRuleId { get; set; }

        /// <summary>
        /// <para>Source policy IDs</para>
        /// 
        /// <b>Example:</b>
        /// <para>02125,102129</para>
        /// </summary>
        [NameInMap("SourceRuleIds")]
        [Validation(Required=false)]
        public string SourceRuleIds { get; set; }

        /// <summary>
        /// <para>Target event</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_ajtshf1581</para>
        /// </summary>
        [NameInMap("TargetEventCode")]
        [Validation(Required=false)]
        public string TargetEventCode { get; set; }

    }

}
