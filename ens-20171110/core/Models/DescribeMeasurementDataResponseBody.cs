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
                [NameInMap("BandWidthFeeDatas")]
                [Validation(Required=false)]
                public DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataBandWidthFeeDatas BandWidthFeeDatas { get; set; }
                public class DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataBandWidthFeeDatas : TeaModel {
                    [NameInMap("BandWidthFeeData")]
                    [Validation(Required=false)]
                    public List<DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataBandWidthFeeDatasBandWidthFeeData> BandWidthFeeData { get; set; }
                    public class DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataBandWidthFeeDatasBandWidthFeeData : TeaModel {
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

                [NameInMap("ChargeModel")]
                [Validation(Required=false)]
                public string ChargeModel { get; set; }

                [NameInMap("CostCycle")]
                [Validation(Required=false)]
                public string CostCycle { get; set; }

                [NameInMap("CostEndTime")]
                [Validation(Required=false)]
                public string CostEndTime { get; set; }

                [NameInMap("CostStartTime")]
                [Validation(Required=false)]
                public string CostStartTime { get; set; }

                [NameInMap("ResourceFeeData")]
                [Validation(Required=false)]
                public DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataResourceFeeData ResourceFeeData { get; set; }
                public class DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataResourceFeeData : TeaModel {
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                    [NameInMap("Storage")]
                    [Validation(Required=false)]
                    public int? Storage { get; set; }

                    [NameInMap("Vcpu")]
                    [Validation(Required=false)]
                    public int? Vcpu { get; set; }

                }

                [NameInMap("ResourceFeeDataDetails")]
                [Validation(Required=false)]
                public DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataResourceFeeDataDetails ResourceFeeDataDetails { get; set; }
                public class DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataResourceFeeDataDetails : TeaModel {
                    [NameInMap("ResourceFeeDataDetail")]
                    [Validation(Required=false)]
                    public List<DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataResourceFeeDataDetailsResourceFeeDataDetail> ResourceFeeDataDetail { get; set; }
                    public class DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataResourceFeeDataDetailsResourceFeeDataDetail : TeaModel {
                        [NameInMap("CostCode")]
                        [Validation(Required=false)]
                        public string CostCode { get; set; }

                        [NameInMap("CostName")]
                        [Validation(Required=false)]
                        public string CostName { get; set; }

                        [NameInMap("CostVal")]
                        [Validation(Required=false)]
                        public int? CostVal { get; set; }

                        [NameInMap("ResourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                    }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
