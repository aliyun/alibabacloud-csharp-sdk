// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeMeasurementDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The metering data returned.</para>
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
                /// <para>The bandwidth data returned.</para>
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
                        /// <para>The code of the bandwidth plan.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-cmcc-1</para>
                        /// </summary>
                        [NameInMap("CostCode")]
                        [Validation(Required=false)]
                        public string CostCode { get; set; }

                        /// <summary>
                        /// <para>The name of the bandwidth plan.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Beijing, Shanghai, and Guangzhou Mobile</para>
                        /// </summary>
                        [NameInMap("CostName")]
                        [Validation(Required=false)]
                        public string CostName { get; set; }

                        /// <summary>
                        /// <para>The bandwidth consumption. Unit: bit/second.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>16486</para>
                        /// </summary>
                        [NameInMap("CostVal")]
                        [Validation(Required=false)]
                        public int? CostVal { get; set; }

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

                /// <summary>
                /// <para>The information about computing resources.</para>
                /// </summary>
                [NameInMap("ResourceFeeData")]
                [Validation(Required=false)]
                public DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataResourceFeeData ResourceFeeData { get; set; }
                public class DescribeMeasurementDataResponseBodyMeasurementDatasMeasurementDataResourceFeeData : TeaModel {
                    /// <summary>
                    /// <para>The memory size. Unit: GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>24</para>
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                    /// <summary>
                    /// <para>The storage capacity. Unit: GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("Storage")]
                    [Validation(Required=false)]
                    public int? Storage { get; set; }

                    /// <summary>
                    /// <para>The number of vCPUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("Vcpu")]
                    [Validation(Required=false)]
                    public int? Vcpu { get; set; }

                }

                /// <summary>
                /// <para>Details of the computing resources.</para>
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
                        /// <para>The code of the resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vCPU</para>
                        /// </summary>
                        [NameInMap("CostCode")]
                        [Validation(Required=false)]
                        public string CostCode { get; set; }

                        /// <summary>
                        /// <para>The name of the resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vCPU</para>
                        /// </summary>
                        [NameInMap("CostName")]
                        [Validation(Required=false)]
                        public string CostName { get; set; }

                        /// <summary>
                        /// <para>The consumption of the resource.</para>
                        /// <list type="bullet">
                        /// <item><description>Memory unit: GB.</description></item>
                        /// <item><description>CPU unit: vCPU.</description></item>
                        /// <item><description>Storage unit: GB.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>55</para>
                        /// </summary>
                        [NameInMap("CostVal")]
                        [Validation(Required=false)]
                        public int? CostVal { get; set; }

                        /// <summary>
                        /// <para>The type of the resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vCPU</para>
                        /// </summary>
                        [NameInMap("ResourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>125B04C7-3D0D-4245-AF96-14E3758E3F06</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
