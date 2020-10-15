// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeMeasurementDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("MeasurementDatas")]
        [Validation(Required=true)]
        public DescribeMeasurementDataResponseMeasurementDatas MeasurementDatas { get; set; }
        public class DescribeMeasurementDataResponseMeasurementDatas : TeaModel {
            [NameInMap("MeasurementData")]
            [Validation(Required=true)]
            public List<DescribeMeasurementDataResponseMeasurementDatasMeasurementData> MeasurementData { get; set; }
            public class DescribeMeasurementDataResponseMeasurementDatasMeasurementData : TeaModel {
                public string ChargeModel { get; set; }
                public string CostCycle { get; set; }
                public string CostStartTime { get; set; }
                public string CostEndTime { get; set; }
                public DescribeMeasurementDataResponseMeasurementDatasMeasurementDataBandWidthFeeDatas BandWidthFeeDatas { get; set; }
                public class DescribeMeasurementDataResponseMeasurementDatasMeasurementDataBandWidthFeeDatas : TeaModel {
                    [NameInMap("BandWidthFeeData")]
                    [Validation(Required=true)]
                    public List<DescribeMeasurementDataResponseMeasurementDatasMeasurementDataBandWidthFeeDatasBandWidthFeeData> BandWidthFeeData { get; set; }
                    public class DescribeMeasurementDataResponseMeasurementDatasMeasurementDataBandWidthFeeDatasBandWidthFeeData : TeaModel {
                        [NameInMap("CostVal")]
                        [Validation(Required=true)]
                        public int? CostVal { get; set; }

                        [NameInMap("CostCode")]
                        [Validation(Required=true)]
                        public string CostCode { get; set; }

                        [NameInMap("CostName")]
                        [Validation(Required=true)]
                        public string CostName { get; set; }

                    }

                }
                public DescribeMeasurementDataResponseMeasurementDatasMeasurementDataResourceFeeDataDetails ResourceFeeDataDetails { get; set; }
                public class DescribeMeasurementDataResponseMeasurementDatasMeasurementDataResourceFeeDataDetails : TeaModel {
                    [NameInMap("ResourceFeeDataDetail")]
                    [Validation(Required=true)]
                    public List<DescribeMeasurementDataResponseMeasurementDatasMeasurementDataResourceFeeDataDetailsResourceFeeDataDetail> ResourceFeeDataDetail { get; set; }
                    public class DescribeMeasurementDataResponseMeasurementDatasMeasurementDataResourceFeeDataDetailsResourceFeeDataDetail : TeaModel {
                        [NameInMap("CostVal")]
                        [Validation(Required=true)]
                        public int? CostVal { get; set; }

                        [NameInMap("CostCode")]
                        [Validation(Required=true)]
                        public string CostCode { get; set; }

                        [NameInMap("CostName")]
                        [Validation(Required=true)]
                        public string CostName { get; set; }

                        [NameInMap("ResourceType")]
                        [Validation(Required=true)]
                        public string ResourceType { get; set; }

                    }

                }
                public DescribeMeasurementDataResponseMeasurementDatasMeasurementDataResourceFeeData ResourceFeeData { get; set; }
                public class DescribeMeasurementDataResponseMeasurementDatasMeasurementDataResourceFeeData : TeaModel {
                    [NameInMap("Storage")]
                    [Validation(Required=true)]
                    public int? Storage { get; set; }

                    [NameInMap("Memory")]
                    [Validation(Required=true)]
                    public int? Memory { get; set; }

                    [NameInMap("Vcpu")]
                    [Validation(Required=true)]
                    public int? Vcpu { get; set; }

                }
            }
        };

    }

}
