// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliyunAuth20181222.Models
{
    public class QueryInEffectQuthOrderRequest : TeaModel {
        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("OperatorTypeEnum")]
        [Validation(Required=false)]
        public string OperatorTypeEnum { get; set; }

        [NameInMap("RequestFromApp")]
        [Validation(Required=false)]
        public string RequestFromApp { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RequestWay")]
        [Validation(Required=false)]
        public string RequestWay { get; set; }

        [NameInMap("UserNo")]
        [Validation(Required=false)]
        public string UserNo { get; set; }

    }

}
