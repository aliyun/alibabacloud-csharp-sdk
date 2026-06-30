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
        /// <para>The JSON string of instance IDs. This parameter can be omitted when <c>UsageType=User</c>. Set this parameter to the credit package instance ID when <c>UsageType=CreditPackage</c>, or to the <c>AgentId</c> when <c>UsageType=Agent</c>.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The usage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>User: Returns the usage, remaining credits, and consumption trends of the active credit packages for the current user.</description></item>
        /// <item><description>CreditPackage: Requires a CreditPackageId. Returns the total and remaining credits of the specified credit package.</description></item>
        /// <item><description>Agent: Requires an AgentId. Returns the cumulative credit usage, cumulative allocated quota, and the percentages of both.</description></item>
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
