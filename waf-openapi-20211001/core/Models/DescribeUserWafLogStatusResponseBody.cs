// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeUserWafLogStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the region where logs are stored. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: indicates China East 1 (Hangzhou).</para>
        /// </description></item>
        /// <item><description><para><b>cn-beijing</b>: indicates China North 2 (Beijing).</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong</b>: indicates China (Hong Kong).</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: indicates Singapore.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-3</b>: indicates Malaysia (Kuala Lumpur).</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-5</b>: indicates Indonesia (Jakarta).</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-6</b>: indicates Philippines (Manila).</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-7</b>: indicates Thailand (Bangkok).</para>
        /// </description></item>
        /// <item><description><para><b>me-east-1</b>: indicates UAE (Dubai).</para>
        /// </description></item>
        /// <item><description><para><b>eu-central-1</b>: indicates Germany (Frankfurt).</para>
        /// </description></item>
        /// <item><description><para><b>us-east-1</b>: indicates US (Virginia).</para>
        /// </description></item>
        /// <item><description><para><b>us-west-1</b>: indicates US (Silicon Valley).</para>
        /// </description></item>
        /// <item><description><para><b>ap-northeast-1</b>: indicates Japan (Tokyo).</para>
        /// </description></item>
        /// <item><description><para><b>ap-northeast-2</b>: indicates South Korea (Seoul).</para>
        /// </description></item>
        /// <item><description><para><b>eu-west-1</b>: indicates UK (London).</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou-finance</b>: indicates China East 1 Hangzhou Finance Cloud.</para>
        /// </description></item>
        /// <item><description><para><b>cn-shanghai-finance-1</b>: indicates China East 2 Shanghai Finance Cloud.</para>
        /// </description></item>
        /// <item><description><para><b>cn-shenzhen-finance</b>: indicates China South 1 Shenzhen Finance Cloud.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The Finance Cloud regions are available only to Finance Cloud users, and Finance Cloud users can obtain only these regions.</para>
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
        /// <item><description><para><b>initializing</b>: The logs are being initialized.</para>
        /// </description></item>
        /// <item><description><para><b>initialize_failed</b>: The initialization failed.</para>
        /// </description></item>
        /// <item><description><para><b>normal</b>: The logs are running properly.</para>
        /// </description></item>
        /// <item><description><para><b>releasing</b>: The logs are being released.</para>
        /// </description></item>
        /// <item><description><para><b>release_failed</b>: The release failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("LogStatus")]
        [Validation(Required=false)]
        public string LogStatus { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
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
