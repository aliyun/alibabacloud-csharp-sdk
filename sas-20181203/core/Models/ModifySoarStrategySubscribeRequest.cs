// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifySoarStrategySubscribeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the policy.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeSoarStrategies~~">DescribeSoarStrategies</a> operation to obtain the ID.</para>
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
        /// <para>Specifies whether to create the policy template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: creates the policy template</description></item>
        /// <item><description>false: deletes the policy template</description></item>
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
