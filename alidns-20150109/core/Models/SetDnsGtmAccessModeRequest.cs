// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SetDnsGtmAccessModeRequest : TeaModel {
        /// <summary>
        /// <para>The switchover policy for the address pool collection:</para>
        /// <list type="bullet">
        /// <item><description><para>AUTO: Automatic switchover</para>
        /// </description></item>
        /// <item><description><para>DEFAULT: The primary address pool collection</para>
        /// </description></item>
        /// <item><description><para>FAILOVER: The secondary address pool collection</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO</para>
        /// </summary>
        [NameInMap("AccessMode")]
        [Validation(Required=false)]
        public string AccessMode { get; set; }

        /// <summary>
        /// <para>The language of certain response parameters. Default: en. Valid values: en, zh, and ja.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the access policy. Call <a href="https://help.aliyun.com/document_detail/2357191.html">DescribeDnsGtmAccessStrategies</a> to obtain the policy ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hr**zb</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

    }

}
