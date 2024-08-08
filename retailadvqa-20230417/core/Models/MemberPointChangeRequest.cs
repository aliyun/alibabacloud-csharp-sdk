// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailadvqa20230417.Models
{
    public class MemberPointChangeRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public MemberPointChangeRequestBody Body { get; set; }
        public class MemberPointChangeRequestBody : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            [NameInMap("ChannelCode")]
            [Validation(Required=false)]
            public string ChannelCode { get; set; }

            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("OpenMerchantId")]
            [Validation(Required=false)]
            public string OpenMerchantId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("OperateType")]
            [Validation(Required=false)]
            public string OperateType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("OuterMemberId")]
            [Validation(Required=false)]
            public string OuterMemberId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("PlatFormType")]
            [Validation(Required=false)]
            public string PlatFormType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public string Quantity { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("SerialNo")]
            [Validation(Required=false)]
            public string SerialNo { get; set; }

        }

    }

}
