// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstanceAutoRenewAttributeResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("InstanceRenewAttributes")]
        [Validation(Required=true)]
        public DescribeInstanceAutoRenewAttributeResponseInstanceRenewAttributes InstanceRenewAttributes { get; set; }
        public class DescribeInstanceAutoRenewAttributeResponseInstanceRenewAttributes : TeaModel {
            [NameInMap("InstanceRenewAttribute")]
            [Validation(Required=true)]
            public List<DescribeInstanceAutoRenewAttributeResponseInstanceRenewAttributesInstanceRenewAttribute> InstanceRenewAttribute { get; set; }
            public class DescribeInstanceAutoRenewAttributeResponseInstanceRenewAttributesInstanceRenewAttribute : TeaModel {
                public string InstanceId { get; set; }
                public bool? AutoRenewal { get; set; }
                public string Duration { get; set; }
            }
        };

    }

}
