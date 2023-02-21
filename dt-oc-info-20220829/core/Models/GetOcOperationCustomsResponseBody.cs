// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcOperationCustomsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcOperationCustomsResponseBodyData> Data { get; set; }
        public class GetOcOperationCustomsResponseBodyData : TeaModel {
            [NameInMap("AdminRegionName")]
            [Validation(Required=false)]
            public string AdminRegionName { get; set; }

            [NameInMap("AnnualReport")]
            [Validation(Required=false)]
            public string AnnualReport { get; set; }

            [NameInMap("BusinessCate")]
            [Validation(Required=false)]
            public string BusinessCate { get; set; }

            [NameInMap("CancelFlag")]
            [Validation(Required=false)]
            public string CancelFlag { get; set; }

            [NameInMap("CreditLevelsNew")]
            [Validation(Required=false)]
            public string CreditLevelsNew { get; set; }

            [NameInMap("CustomsNum")]
            [Validation(Required=false)]
            public string CustomsNum { get; set; }

            [NameInMap("CustomsReg")]
            [Validation(Required=false)]
            public string CustomsReg { get; set; }

            [NameInMap("EcoRegionName")]
            [Validation(Required=false)]
            public string EcoRegionName { get; set; }

            [NameInMap("ElectType")]
            [Validation(Required=false)]
            public string ElectType { get; set; }

            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

            [NameInMap("IdentCode")]
            [Validation(Required=false)]
            public string IdentCode { get; set; }

            [NameInMap("IdentDate")]
            [Validation(Required=false)]
            public string IdentDate { get; set; }

            [NameInMap("IndustryType")]
            [Validation(Required=false)]
            public string IndustryType { get; set; }

            [NameInMap("RegDate")]
            [Validation(Required=false)]
            public string RegDate { get; set; }

            [NameInMap("SpecialArea")]
            [Validation(Required=false)]
            public string SpecialArea { get; set; }

            [NameInMap("ValidDate")]
            [Validation(Required=false)]
            public string ValidDate { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
