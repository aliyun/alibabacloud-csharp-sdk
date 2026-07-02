// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliyunAuth20181222.Models
{
    public class AuthenticateRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("OperateCode")]
        [Validation(Required=false)]
        public string OperateCode { get; set; }

        [NameInMap("OperatorTypeEnum")]
        [Validation(Required=false)]
        public string OperatorTypeEnum { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("RequestFromApp")]
        [Validation(Required=false)]
        public string RequestFromApp { get; set; }

        [NameInMap("RequestWay")]
        [Validation(Required=false)]
        public string RequestWay { get; set; }

        [NameInMap("UserNo")]
        [Validation(Required=false)]
        public string UserNo { get; set; }

    }

}
