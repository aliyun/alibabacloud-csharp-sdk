// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserSecDropRequest : TeaModel {
        /// <summary>
        /// <para>The date or month that you want to query.</para>
        /// <list type="bullet">
        /// <item><description>If data is collected every day, set Data in the format of yyyymmdd, such as 20201203.</description></item>
        /// <item><description>If data is collected every month, set Data in the format of yyyymm, such as 202012.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20201203</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The time interval at which data is collected.</para>
        /// <list type="bullet">
        /// <item><description>If data is collected every day, the number of blocked packets on the specified day is calculated.</description></item>
        /// <item><description>If data is collected every month, the number of blocked packets in the specified month is calculated.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1day</para>
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The security feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>waf: WAF</description></item>
        /// <item><description>tmd: rate limiting</description></item>
        /// <item><description>robot: bot traffic recognition</description></item>
        /// <item><description>l4_dm_drop: domain name blocking at Layer 4</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf</para>
        /// </summary>
        [NameInMap("SecFunc")]
        [Validation(Required=false)]
        public string SecFunc { get; set; }

    }

}
