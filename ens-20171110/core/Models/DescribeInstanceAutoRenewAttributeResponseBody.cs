// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstanceAutoRenewAttributeResponseBody : TeaModel {
        /// <summary>
        /// The returned service code. A value of 0 indicates that the operation was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The renewal status of the instance.
        /// </summary>
        [NameInMap("InstanceRenewAttributes")]
        [Validation(Required=false)]
        public DescribeInstanceAutoRenewAttributeResponseBodyInstanceRenewAttributes InstanceRenewAttributes { get; set; }
        public class DescribeInstanceAutoRenewAttributeResponseBodyInstanceRenewAttributes : TeaModel {
            [NameInMap("InstanceRenewAttribute")]
            [Validation(Required=false)]
            public List<DescribeInstanceAutoRenewAttributeResponseBodyInstanceRenewAttributesInstanceRenewAttribute> InstanceRenewAttribute { get; set; }
            public class DescribeInstanceAutoRenewAttributeResponseBodyInstanceRenewAttributesInstanceRenewAttribute : TeaModel {
                /// <summary>
                /// The renewal type of the instance.
                /// 
                /// *   **true**: enables auto-renewal.
                /// *   **false**: disables auto-renewal.
                /// </summary>
                [NameInMap("AutoRenewal")]
                [Validation(Required=false)]
                public bool? AutoRenewal { get; set; }

                /// <summary>
                /// The unit of the auto-renewal period.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
