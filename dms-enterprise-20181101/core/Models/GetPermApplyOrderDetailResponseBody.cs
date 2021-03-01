// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetPermApplyOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("PermApplyOrderDetail")]
        [Validation(Required=false)]
        public GetPermApplyOrderDetailResponseBodyPermApplyOrderDetail PermApplyOrderDetail { get; set; }
        public class GetPermApplyOrderDetailResponseBodyPermApplyOrderDetail : TeaModel {
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResources> Resources { get; set; }
            public class GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResources : TeaModel {
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

                [NameInMap("OwnerIds")]
                [Validation(Required=false)]
                public List<long?> OwnerIds { get; set; }

                [NameInMap("OwnerNickNames")]
                [Validation(Required=false)]
                public List<string> OwnerNickNames { get; set; }

                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

            }
            [NameInMap("PermType")]
            [Validation(Required=false)]
            public long? PermType { get; set; }
            [NameInMap("Seconds")]
            [Validation(Required=false)]
            public long? Seconds { get; set; }
            [NameInMap("ApplyType")]
            [Validation(Required=false)]
            public string ApplyType { get; set; }
        };

    }

}
