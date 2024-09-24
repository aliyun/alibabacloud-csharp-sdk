// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyClientConfSetupRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of the Security Center agent.</para>
        /// <list type="bullet">
        /// <item><description>cpu: the maximum CPU utilization that can be occupied by the Security Center agent on the server</description></item>
        /// <item><description>mem: the maximum memory usage that can be occupied by the Security Center agent on the server</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;cpu&quot;: &quot;20&quot;
        /// }</para>
        /// </summary>
        [NameInMap("StrategyConfig")]
        [Validation(Required=false)]
        public string StrategyConfig { get; set; }

        /// <summary>
        /// <para>The type of the tag.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>machineResource</para>
        /// </summary>
        [NameInMap("StrategyTag")]
        [Validation(Required=false)]
        public string StrategyTag { get; set; }

        /// <summary>
        /// <para>The value of the tag. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>major</description></item>
        /// <item><description>advanced</description></item>
        /// <item><description>basic</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>major</para>
        /// </summary>
        [NameInMap("StrategyTagValue")]
        [Validation(Required=false)]
        public string StrategyTagValue { get; set; }

    }

}
