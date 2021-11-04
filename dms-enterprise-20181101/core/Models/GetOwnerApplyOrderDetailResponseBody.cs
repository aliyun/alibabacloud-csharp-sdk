// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetOwnerApplyOrderDetailResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("OwnerApplyOrderDetail")]
        [Validation(Required=false)]
        public GetOwnerApplyOrderDetailResponseBodyOwnerApplyOrderDetail OwnerApplyOrderDetail { get; set; }
        public class GetOwnerApplyOrderDetailResponseBodyOwnerApplyOrderDetail : TeaModel {
            [NameInMap("ApplyType")]
            [Validation(Required=false)]
            public string ApplyType { get; set; }
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<GetOwnerApplyOrderDetailResponseBodyOwnerApplyOrderDetailResources> Resources { get; set; }
            public class GetOwnerApplyOrderDetailResponseBodyOwnerApplyOrderDetailResources : TeaModel {
                public bool? Logic { get; set; }
                public GetOwnerApplyOrderDetailResponseBodyOwnerApplyOrderDetailResourcesResourceDetail ResourceDetail { get; set; }
                public class GetOwnerApplyOrderDetailResponseBodyOwnerApplyOrderDetailResourcesResourceDetail : TeaModel {
                    [NameInMap("DbType")]
                    [Validation(Required=false)]
                    public string DbType { get; set; }

                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<long?> OwnerIds { get; set; }

                    [NameInMap("OwnerNickNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNickNames { get; set; }

                    [NameInMap("SearchName")]
                    [Validation(Required=false)]
                    public string SearchName { get; set; }

                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }
                public string TargetId { get; set; }
            }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
