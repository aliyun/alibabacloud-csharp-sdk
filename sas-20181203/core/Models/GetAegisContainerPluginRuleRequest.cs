// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAegisContainerPluginRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the container escape prevention rule.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListAegisContainerPluginRule~~">ListAegisContainerPluginRule</a> operation to query this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1141****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The language type for requests and responses. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: user-defined</description></item>
        /// <item><description><b>1</b>: system built-in</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

    }

}
