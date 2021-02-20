// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEpnMeasurementDataResponseBody : TeaModel {
        [NameInMap("MeasurementDatas")]
        [Validation(Required=false)]
        public DescribeEpnMeasurementDataResponseBodyMeasurementDatas MeasurementDatas { get; set; }
        public class DescribeEpnMeasurementDataResponseBodyMeasurementDatas : TeaModel {
            [NameInMap("MeasurementData")]
            [Validation(Required=false)]
            public List<DescribeEpnMeasurementDataResponseBodyMeasurementDatasMeasurementData> MeasurementData { get; set; }
            public class DescribeEpnMeasurementDataResponseBodyMeasurementDatasMeasurementData : TeaModel {
                [NameInMap("BandWidthFeeData")]
                [Validation(Required=false)]
                public List<DescribeEpnMeasurementDataResponseBodyMeasurementDatasMeasurementDataBandWidthFeeData> BandWidthFeeData { get; set; }
                public class DescribeEpnMeasurementDataResponseBodyMeasurementDatasMeasurementDataBandWidthFeeData : TeaModel {
                    [NameInMap("CostCode")]
                    [Validation(Required=false)]
                    public string CostCode { get; set; }

                    [NameInMap("CostName")]
                    [Validation(Required=false)]
                    public string CostName { get; set; }

                    [NameInMap("CostType")]
                    [Validation(Required=false)]
                    public string CostType { get; set; }

                    [NameInMap("CostVal")]
                    [Validation(Required=false)]
                    public int? CostVal { get; set; }

                    [NameInMap("IspLine")]
                    [Validation(Required=false)]
                    public string IspLine { get; set; }

                }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
