// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEpnMeasurementDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The metering data returned.</para>
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
                /// <para>The bandwidth data returned.</para>
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
                        /// <para>The code of the billable item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-cmcc-1</para>
                        /// </summary>
                        [NameInMap("CostCode")]
                        [Validation(Required=false)]
                        public string CostCode { get; set; }

                        /// <summary>
                        /// <para>The name of the billable item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Beijing, Shanghai, and Guangzhou Mobile</para>
                        /// </summary>
                        [NameInMap("CostName")]
                        [Validation(Required=false)]
                        public string CostName { get; set; }

                        /// <summary>
                        /// <para>Metering method</para>
                        /// <list type="bullet">
                        /// <item><description>SpeedUp: bandwidth of intelligent acceleration</description></item>
                        /// <item><description>IntranetConnection: internal bandwidth</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SpeedUp</para>
                        /// </summary>
                        [NameInMap("CostType")]
                        [Validation(Required=false)]
                        public string CostType { get; set; }

                        /// <summary>
                        /// <para>The value of the billable item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>16486</para>
                        /// </summary>
                        [NameInMap("CostVal")]
                        [Validation(Required=false)]
                        public int? CostVal { get; set; }

                        /// <summary>
                        /// <para>This parameter is unavailable.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>This parameter is not currently in use.</para>
                        /// </summary>
                        [NameInMap("IspLine")]
                        [Validation(Required=false)]
                        public string IspLine { get; set; }

                    }

                }

                /// <summary>
                /// <para>The metering method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ChargeByUnified: unified metering.</description></item>
                /// <item><description>ChargeByGrade: differential metering.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ChargeByGrade</para>
                /// </summary>
                [NameInMap("ChargeModel")]
                [Validation(Required=false)]
                public string ChargeModel { get; set; }

                /// <summary>
                /// <para>The metering cycle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-07-30</para>
                /// </summary>
                [NameInMap("CostCycle")]
                [Validation(Required=false)]
                public string CostCycle { get; set; }

                /// <summary>
                /// <para>The end time of the metering cycle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-07-30T16:00:00Z</para>
                /// </summary>
                [NameInMap("CostEndTime")]
                [Validation(Required=false)]
                public string CostEndTime { get; set; }

                /// <summary>
                /// <para>The start time of the metering cycle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-07-29T16:00:00Z</para>
                /// </summary>
                [NameInMap("CostStartTime")]
                [Validation(Required=false)]
                public string CostStartTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A6328C33-6304-5291-8641-0A00A99D0DD0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
