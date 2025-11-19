// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wuying_personal_pc20251111.Models
{
    public class DescribeCorePackageListRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        [NameInMap("QueryDeductionInstances")]
        [Validation(Required=false)]
        public bool? QueryDeductionInstances { get; set; }

        [NameInMap("QueryScenario")]
        [Validation(Required=false)]
        public string QueryScenario { get; set; }

    }

}
