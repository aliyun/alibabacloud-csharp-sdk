// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeMeasurementDataResponseBody : TeaModel {
        [NameInMap("MeasurementDatas")]
        [Validation(Required=false)]
        public DescribeMeasurementDataResponseBodyMeasurementDatas MeasurementDatas { get; set; }
        public class DescribeMeasurementDataResponseBodyMeasurementDatas : TeaModel {
            [NameInMap("MeasurementData")]
            [Validation(Required=false)]
            public List<DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementData> MeasurementData { get; set; }
            public class DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementData : TeaModel {
                [NameInMap("BandWidthFeeData")]
                [Validation(Required=false)]
                public List<DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataBandWidthFeeData> BandWidthFeeData { get; set; }
                public class DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataBandWidthFeeData : TeaModel {
                    [NameInMap("CostCode")]
                    [Validation(Required=false)]
                    public string CostCode { get; set; }

                    [NameInMap("CostName")]
                    [Validation(Required=false)]
                    public string CostName { get; set; }

                    [NameInMap("CostVal")]
                    [Validation(Required=false)]
                    public int? CostVal { get; set; }

                }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
