// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifySoarStrategySubscribeRequest : TeaModel {
        /// <summary>
        /// <para>The strategy ID.
        /// You can call the <a href="~~DescribeSoarStrategies~~">DescribeSoarStrategies</a> operation to obtain this parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8000</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

        /// <summary>
        /// <para>Specifies whether to add or remove the strategy template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Adds the strategy template to My Strategies.</description></item>
        /// <item><description>false: Removes the strategy template from My Strategies.</description></item>
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
