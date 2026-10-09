// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The type of the policies to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>common</b>: standard policy</description></item>
        /// <item><description><b>custom</b>: custom policy</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("CustomType")]
        [Validation(Required=false)]
        public string CustomType { get; set; }

        /// <summary>
        /// <para>The language of the request and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.X.X</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The IDs of the policies to query. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>8164248</para>
        /// </summary>
        [NameInMap("StrategyIds")]
        [Validation(Required=false)]
        public string StrategyIds { get; set; }

    }

}
