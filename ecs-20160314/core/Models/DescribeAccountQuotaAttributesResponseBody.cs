// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeAccountQuotaAttributesResponseBody : TeaModel {
        [NameInMap("QuotaAttributes")]
        [Validation(Required=false)]
        public DescribeAccountQuotaAttributesResponseBodyQuotaAttributes QuotaAttributes { get; set; }
        public class DescribeAccountQuotaAttributesResponseBodyQuotaAttributes : TeaModel {
            [NameInMap("EcsElasticQuotaEnable")]
            [Validation(Required=false)]
            public bool? EcsElasticQuotaEnable { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
