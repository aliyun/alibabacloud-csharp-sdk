// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailadvqa20230417.Models
{
    public class QueryMemberBasicInfoRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public QueryMemberBasicInfoRequestBody Body { get; set; }
        public class QueryMemberBasicInfoRequestBody : TeaModel {
            [NameInMap("ChannelCode")]
            [Validation(Required=false)]
            public string ChannelCode { get; set; }

            [NameInMap("ChannelOpenId")]
            [Validation(Required=false)]
            public string ChannelOpenId { get; set; }

            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("OpenMerchantId")]
            [Validation(Required=false)]
            public string OpenMerchantId { get; set; }

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
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
