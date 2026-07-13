// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeInterAuthStatisticsGlobalOverviewRequest : TeaModel {
        /// <summary>
        /// <para>The language of the returned availability zone names. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh-CN</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en-US</b> (default): English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>A unique, client-generated token to ensure the idempotence of the request. The token must be a string of ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23445411234395894586....</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The statistical period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAY</para>
        /// </summary>
        [NameInMap("OverviewPeriod")]
        [Validation(Required=false)]
        public string OverviewPeriod { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("ServerRegion")]
        [Validation(Required=false)]
        public string ServerRegion { get; set; }

    }

}
