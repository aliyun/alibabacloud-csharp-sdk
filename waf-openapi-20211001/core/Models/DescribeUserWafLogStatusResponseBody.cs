// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeUserWafLogStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the region where WAF logs are stored. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: China (Hangzhou).</description></item>
        /// <item><description><b>cn-beijing</b>: China (Beijing).</description></item>
        /// <item><description><b>cn-hongkong</b>: China (Hong Kong).</description></item>
        /// <item><description><b>ap-southeast-1</b>: Singapore.</description></item>
        /// <item><description><b>ap-southeast-2</b>: Australia (Sydney).</description></item>
        /// <item><description><b>ap-southeast-3</b>: Malaysia (Kuala Lumpur).</description></item>
        /// <item><description><b>ap-southeast-5</b>: Indonesia (Jakarta).</description></item>
        /// <item><description><b>ap-southeast-6</b>: Philippines (Manila).</description></item>
        /// <item><description><b>ap-southeast-7</b>: Thailand (Bangkok).</description></item>
        /// <item><description><b>me-east-1</b>: UAE (Dubai).</description></item>
        /// <item><description><b>eu-central-1</b>: Germany (Frankfurt).</description></item>
        /// <item><description><b>us-east-1</b>: US (Virginia).</description></item>
        /// <item><description><b>us-west-1</b>: US (Silicon Valley).</description></item>
        /// <item><description><b>ap-northeast-1</b>: Japan (Tokyo).</description></item>
        /// <item><description><b>ap-northeast-2</b>: South Korea (Seoul).</description></item>
        /// <item><description><b>ap-south-1</b>: India (Mumbai) Closing Down.</description></item>
        /// <item><description><b>eu-west-1</b>: UK (London).</description></item>
        /// <item><description><b>cn-hangzhou-finance</b>: China East 1 Finance.</description></item>
        /// <item><description><b>cn-shanghai-finance-1</b>: China East 2 Finance.</description></item>
        /// <item><description><b>cn-shenzhen-finance</b>: China South 1 Finance.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The China East 1 Finance, China East 2 Finance, and China South 1 Finance regions are available only for Alibaba Finance Cloud users. Alibaba Finance Cloud users are also limited to storing logs within these specific regions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("LogRegionId")]
        [Validation(Required=false)]
        public string LogRegionId { get; set; }

        /// <summary>
        /// <para>The status of WAF logs.</para>
        /// <list type="bullet">
        /// <item><description><b>initializing</b></description></item>
        /// <item><description><b>initialize_failed</b></description></item>
        /// <item><description><b>normal</b></description></item>
        /// <item><description><b>releasing</b></description></item>
        /// <item><description><b>release_failed</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("LogStatus")]
        [Validation(Required=false)]
        public string LogStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time when the log status was modified. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1706771796859</para>
        /// </summary>
        [NameInMap("StatusUpdateTime")]
        [Validation(Required=false)]
        public long? StatusUpdateTime { get; set; }

    }

}
