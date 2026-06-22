// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifySoarStrategySubscribeRequest : TeaModel {
        /// <summary>
        /// <para>The policy ID.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeSoarStrategies~~">DescribeSoarStrategies</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8000</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

        /// <summary>
        /// <para>The add or remove status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: adds the policy template to My Policies</description></item>
        /// <item><description>false: removes the policy template from My Policies.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SubscribeStatus")]
        [Validation(Required=false)]
        public bool? SubscribeStatus { get; set; }

    }

}
