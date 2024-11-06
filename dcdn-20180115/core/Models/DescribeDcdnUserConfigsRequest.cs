// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The configuration that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>domain_business_control: user configurations</description></item>
        /// <item><description>bot_basic: the basic edition of bot traffic management, which supports authorized crawlers and provides threat intelligence</description></item>
        /// <item><description>bot_Advance: the advanced edition of bot traffic management, which supports authorized crawlers and AI intelligent protection and provides threat intelligence</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>domain_business_control</para>
        /// </summary>
        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

    }

}
