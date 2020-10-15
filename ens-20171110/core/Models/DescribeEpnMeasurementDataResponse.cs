// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEpnMeasurementDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("MeasurementDatas")]
        [Validation(Required=true)]
        public DescribeEpnMeasurementDataResponseMeasurementDatas MeasurementDatas { get; set; }
        public class DescribeEpnMeasurementDataResponseMeasurementDatas : TeaModel {
            [NameInMap("MeasurementData")]
            [Validation(Required=true)]
            public List<DescribeEpnMeasurementDataResponseMeasurementDatasMeasurementData> MeasurementData { get; set; }
            public class DescribeEpnMeasurementDataResponseMeasurementDatasMeasurementData : TeaModel {
                public string ChargeModel { get; set; }
                public string CostCycle { get; set; }
                public string CostStartTime { get; set; }
                public string CostEndTime { get; set; }
                public DescribeEpnMeasurementDataResponseMeasurementDatasMeasurementDataBandWidthFeeDatas BandWidthFeeDatas { get; set; }
                public class DescribeEpnMeasurementDataResponseMeasurementDatasMeasurementDataBandWidthFeeDatas : TeaModel {
                    [NameInMap("BandWidthFeeData")]
                    [Validation(Required=true)]
                    public List<DescribeEpnMeasurementDataResponseMeasurementDatasMeasurementDataBandWidthFeeDatasBandWidthFeeData> BandWidthFeeData { get; set; }
                    public class DescribeEpnMeasurementDataResponseMeasurementDatasMeasurementDataBandWidthFeeDatasBandWidthFeeData : TeaModel {
                        [NameInMap("CostVal")]
                        [Validation(Required=true)]
                        public int? CostVal { get; set; }

                        [NameInMap("CostCode")]
                        [Validation(Required=true)]
                        public string CostCode { get; set; }

                        [NameInMap("CostName")]
                        [Validation(Required=true)]
                        public string CostName { get; set; }

                        [NameInMap("CostType")]
                        [Validation(Required=true)]
                        public string CostType { get; set; }

                        [NameInMap("IspLine")]
                        [Validation(Required=true)]
                        public string IspLine { get; set; }

                    }

                }
            }
        };

    }

}
