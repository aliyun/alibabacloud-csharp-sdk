// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeImageInstanceForIsvRequest : TeaModel {
        [NameInMap("CustomerPk")]
        [Validation(Required=false)]
        public long? CustomerPk { get; set; }

        [NameInMap("EcsInstanceId")]
        [Validation(Required=false)]
        public string EcsInstanceId { get; set; }

    }

}
