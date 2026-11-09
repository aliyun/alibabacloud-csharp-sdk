// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeCreditUsageInfoRequest : TeaModel {
        /// <summary>
        /// <para>The business type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BUSINESS</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The JSON string of the instance ID list. This parameter can be omitted when <c>UsageType</c> is set to <c>User</c>. Set it to the credit package instance ID when <c>UsageType</c> is <c>CreditPackage</c>, and the agent ID when <c>UsageType</c> is <c>Agent</c>.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The operator Scenarios type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Not specified or NaturalMonthlyOwn: Natural monthly exclusive.</description></item>
        /// <item><description>JzYearlyShare: Jz annual shared.</description></item>
        /// <item><description>JzYearlyOwn: Jz annual exclusive.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>JzYearlyShare</para>
        /// </summary>
        [NameInMap("SceneType")]
        [Validation(Required=false)]
        public string SceneType { get; set; }

        /// <summary>
        /// <para>The usage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>User: Returns the used amount, remaining amount, and consumption trend of the currently active credit packages for the user.</description></item>
        /// <item><description>CreditPackage: Requires a credit package ID. Returns the total amount and remaining amount of the specified credit package.</description></item>
        /// <item><description>Agent: Requires an agent ID. Returns the cumulative credit usage, cumulative allocated quota, and the percentage between the two.</description></item>
        /// <item><description>EndUser: Requires a Wuying ID. Returns the shared credit usage, pay-as-you-go credit usage, and total credit usage for the current period of the Wuying user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("UsageType")]
        [Validation(Required=false)]
        public string UsageType { get; set; }

    }

}
