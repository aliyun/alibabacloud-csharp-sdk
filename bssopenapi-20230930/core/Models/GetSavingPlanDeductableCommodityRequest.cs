// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetSavingPlanDeductableCommodityRequest : TeaModel {
        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public List<GetSavingPlanDeductableCommodityRequestEcIdAccountIds> EcIdAccountIds { get; set; }
        public class GetSavingPlanDeductableCommodityRequestEcIdAccountIds : TeaModel {
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<long?> AccountIds { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("EcId")]
            [Validation(Required=false)]
            public string EcId { get; set; }

        }

        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

    }

}
