// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnSecFuncInfoRequest : TeaModel {
        /// <summary>
        /// The language. Valid values: en and zh. Default value: en.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The type of the drop-down list. Valid values: RobotRuleName and RobotObject.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecFuncType")]
        [Validation(Required=false)]
        public string SecFuncType { get; set; }

    }

}
