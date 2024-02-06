// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeMeasurementDataResponseBody : TeaModel {
        /// <summary>
        /// The metering data returned.
        /// </summary>
        [NameInMap("MeasurementDatas")]
        [Validation(Required=false)]
        public DescribeMeasurementDataResponseBodyMeasurementDatas MeasurementDatas { get; set; }
        public class DescribeMeasurementDataResponseBodyMeasurementDatas : TeaModel {
            [NameInMap("MeasurementData")]
            [Validation(Required=false)]
            public List<DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementData> MeasurementData { get; set; }
            public class DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementData : TeaModel {
                /// <summary>
                /// The bandwidth data returned.
                /// </summary>
                [NameInMap("BandWidthFeeDatas")]
                [Validation(Required=false)]
                public DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataBandWidthFeeDatas BandWidthFeeDatas { get; set; }
                public class DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataBandWidthFeeDatas : TeaModel {
                    [NameInMap("BandWidthFeeData")]
                    [Validation(Required=false)]
                    public List<DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataBandWidthFeeDatasBandWidthFeeData> BandWidthFeeData { get; set; }
                    public class DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataBandWidthFeeDatasBandWidthFeeData : TeaModel {
                        /// <summary>
                        /// The code of the bandwidth plan.
                        /// </summary>
                        [NameInMap("CostCode")]
                        [Validation(Required=false)]
                        public string CostCode { get; set; }

                        /// <summary>
                        /// The name of the bandwidth plan.
                        /// </summary>
                        [NameInMap("CostName")]
                        [Validation(Required=false)]
                        public string CostName { get; set; }

                        /// <summary>
                        /// The bandwidth consumption. Unit: bit/second.
                        /// </summary>
                        [NameInMap("CostVal")]
                        [Validation(Required=false)]
                        public int? CostVal { get; set; }

                    }

                }

                /// <summary>
                /// The metering method. Valid values:
                /// 
                /// *   ChargeByUnified: unified metering.
                /// *   ChargeByGrade: differential metering.
                /// </summary>
                [NameInMap("ChargeModel")]
                [Validation(Required=false)]
                public string ChargeModel { get; set; }

                /// <summary>
                /// The metering cycle.
                /// </summary>
                [NameInMap("CostCycle")]
                [Validation(Required=false)]
                public string CostCycle { get; set; }

                /// <summary>
                /// The end time of the metering cycle.
                /// </summary>
                [NameInMap("CostEndTime")]
                [Validation(Required=false)]
                public string CostEndTime { get; set; }

                /// <summary>
                /// The start time of the metering cycle.
                /// </summary>
                [NameInMap("CostStartTime")]
                [Validation(Required=false)]
                public string CostStartTime { get; set; }

                /// <summary>
                /// The information about computing resources.
                /// </summary>
                [NameInMap("ResourceFeeData")]
                [Validation(Required=false)]
                public DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataResourceFeeData ResourceFeeData { get; set; }
                public class DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataResourceFeeData : TeaModel {
                    /// <summary>
                    /// The memory size. Unit: GB.
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                    /// <summary>
                    /// The storage capacity. Unit: GB.
                    /// </summary>
                    [NameInMap("Storage")]
                    [Validation(Required=false)]
                    public int? Storage { get; set; }

                    /// <summary>
                    /// The number of vCPUs.
                    /// </summary>
                    [NameInMap("Vcpu")]
                    [Validation(Required=false)]
                    public int? Vcpu { get; set; }

                }

                /// <summary>
                /// Details of the computing resources.
                /// </summary>
                [NameInMap("ResourceFeeDataDetails")]
                [Validation(Required=false)]
                public DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataResourceFeeDataDetails ResourceFeeDataDetails { get; set; }
                public class DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataResourceFeeDataDetails : TeaModel {
                    [NameInMap("ResourceFeeDataDetail")]
                    [Validation(Required=false)]
                    public List<DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataResourceFeeDataDetailsResourceFeeDataDetail> ResourceFeeDataDetail { get; set; }
                    public class DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataResourceFeeDataDetailsResourceFeeDataDetail : TeaModel {
                        /// <summary>
                        /// The code of the resource.
                        /// </summary>
                        [NameInMap("CostCode")]
                        [Validation(Required=false)]
                        public string CostCode { get; set; }

                        /// <summary>
                        /// The name of the resource.
                        /// </summary>
                        [NameInMap("CostName")]
                        [Validation(Required=false)]
                        public string CostName { get; set; }

                        /// <summary>
                        /// The consumption of the resource.
                        /// 
                        /// *   Memory unit: GB.
                        /// *   CPU unit: vCPU.
                        /// *   Storage unit: GB.
                        /// </summary>
                        [NameInMap("CostVal")]
                        [Validation(Required=false)]
                        public int? CostVal { get; set; }

                        /// <summary>
                        /// The type of the resource.
                        /// </summary>
                        [NameInMap("ResourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
