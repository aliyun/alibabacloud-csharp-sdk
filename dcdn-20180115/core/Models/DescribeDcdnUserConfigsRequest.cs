// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserConfigsRequest : TeaModel {
        /// <summary>
        /// The configuration that you want to query. Valid values:
        /// 
        /// *   domain_business_control: user configurations
        /// *   bot_basic: the basic edition of bot traffic management, which supports authorized crawlers and provides threat intelligence
        /// *   bot_Advance: the advanced edition of bot traffic management, which supports authorized crawlers and AI intelligent protection and provides threat intelligence
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

    }

}
