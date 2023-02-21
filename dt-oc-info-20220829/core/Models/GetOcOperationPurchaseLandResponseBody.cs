// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcOperationPurchaseLandResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcOperationPurchaseLandResponseBodyData> Data { get; set; }
        public class GetOcOperationPurchaseLandResponseBodyData : TeaModel {
            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            [NameInMap("ElectronicNo")]
            [Validation(Required=false)]
            public string ElectronicNo { get; set; }

            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

            [NameInMap("Industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

            [NameInMap("LandLevel")]
            [Validation(Required=false)]
            public string LandLevel { get; set; }

            [NameInMap("LandSource")]
            [Validation(Required=false)]
            public string LandSource { get; set; }

            [NameInMap("LandUse")]
            [Validation(Required=false)]
            public string LandUse { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("Price")]
            [Validation(Required=false)]
            public string Price { get; set; }

            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("PromiseDeliveryDate")]
            [Validation(Required=false)]
            public string PromiseDeliveryDate { get; set; }

            [NameInMap("PromiseEndDate")]
            [Validation(Required=false)]
            public string PromiseEndDate { get; set; }

            [NameInMap("PromiseStartDate")]
            [Validation(Required=false)]
            public string PromiseStartDate { get; set; }

            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            [NameInMap("ReleaseDate")]
            [Validation(Required=false)]
            public string ReleaseDate { get; set; }

            [NameInMap("SigningMode")]
            [Validation(Required=false)]
            public string SigningMode { get; set; }

            [NameInMap("UseYear")]
            [Validation(Required=false)]
            public string UseYear { get; set; }

            [NameInMap("VolumeFractionLowerBound")]
            [Validation(Required=false)]
            public string VolumeFractionLowerBound { get; set; }

            [NameInMap("VolumeFractionUpperBound")]
            [Validation(Required=false)]
            public string VolumeFractionUpperBound { get; set; }

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
