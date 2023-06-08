// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafScenesRequest : TeaModel {
        /// <summary>
        /// The total number of protection rules that were configured in this type of the policy.
        /// </summary>
        [NameInMap("DefenseScenes")]
        [Validation(Required=false)]
        public string DefenseScenes { get; set; }

    }

}
