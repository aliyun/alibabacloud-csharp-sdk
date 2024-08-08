// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailadvqa20230417.Models
{
    public class CalculateMemberLevelRequest : TeaModel {
        [NameInMap("Body")]
        [Validation(Required=false)]
        public CalculateMemberLevelRequestBody Body { get; set; }
        public class CalculateMemberLevelRequestBody : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("CurrentGrade")]
            [Validation(Required=false)]
            public int? CurrentGrade { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("CurrentGradeName")]
            [Validation(Required=false)]
            public string CurrentGradeName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("OpenMerchantId")]
            [Validation(Required=false)]
            public string OpenMerchantId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("PlatformType")]
            [Validation(Required=false)]
            public string PlatformType { get; set; }

            [NameInMap("Score")]
            [Validation(Required=false)]
            public string Score { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("SerialNo")]
            [Validation(Required=false)]
            public string SerialNo { get; set; }

        }

    }

}
