// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEpnMeasurementDataResponseBody : TeaModel {
        /// <summary>
        /// The metering data returned.
        /// </summary>
        [NameInMap("MeasurementDatas")]
        [Validation(Required=false)]
        public DescribeEpnMeasurementDataResponseBodyMeasurementDatas MeasurementDatas { get; set; }
        public class DescribeEpnMeasurementDataResponseBodyMeasurementDatas : TeaModel {
            [NameInMap("MeasurementData")]
            [Validation(Required=false)]
            public List<DescribeEpnMeasurementDataResponseBodyMeasurementDatasMeasurementData> MeasurementData { get; set; }
            public class DescribeEpnMeasurementDataResponseBodyMeasurementDatasMeasurementData : TeaModel {
                /// <summary>
                /// The bandwidth data returned.
                /// </summary>
                [NameInMap("BandWidthFeeDatas")]
                [Validation(Required=false)]
                public DescribeEpnMeasurementDataResponseBodyMeasurementDatasMeasurementDataBandWidthFeeDatas BandWidthFeeDatas { get; set; }
                public class DescribeEpnMeasurementDataResponseBodyMeasurementDatasMeasurementDataBandWidthFeeDatas : TeaModel {
                    [NameInMap("BandWidthFeeData")]
                    [Validation(Required=false)]
                    public List<DescribeEpnMeasurementDataResponseBodyMeasurementDatasMeasurementDataBandWidthFeeDatasBandWidthFeeData> BandWidthFeeData { get; set; }
                    public class DescribeEpnMeasurementDataResponseBodyMeasurementDatasMeasurementDataBandWidthFeeDatasBandWidthFeeData : TeaModel {
                        /// <summary>
                        /// The code of the billable item.
                        /// </summary>
                        [NameInMap("CostCode")]
                        [Validation(Required=false)]
                        public string CostCode { get; set; }

                        /// <summary>
                        /// The name of the billable item.
                        /// </summary>
                        [NameInMap("CostName")]
                        [Validation(Required=false)]
                        public string CostName { get; set; }

                        /// <summary>
                        /// Metering method
                        /// 
                        /// *   SpeedUp: bandwidth of intelligent acceleration
                        /// *   IntranetConnection: internal bandwidth
                        /// </summary>
                        [NameInMap("CostType")]
                        [Validation(Required=false)]
                        public string CostType { get; set; }

                        /// <summary>
                        /// The value of the billable item.
                        /// </summary>
                        [NameInMap("CostVal")]
                        [Validation(Required=false)]
                        public int? CostVal { get; set; }

                        /// <summary>
                        /// This parameter is unavailable.
                        /// </summary>
                        [NameInMap("IspLine")]
                        [Validation(Required=false)]
                        public string IspLine { get; set; }

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

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
