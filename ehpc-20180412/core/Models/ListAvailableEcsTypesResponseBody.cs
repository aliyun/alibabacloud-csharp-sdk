// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListAvailableEcsTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance family to which the instance type belongs.</para>
        /// </summary>
        [NameInMap("InstanceTypeFamilies")]
        [Validation(Required=false)]
        public ListAvailableEcsTypesResponseBodyInstanceTypeFamilies InstanceTypeFamilies { get; set; }
        public class ListAvailableEcsTypesResponseBodyInstanceTypeFamilies : TeaModel {
            [NameInMap("InstanceTypeFamilyInfo")]
            [Validation(Required=false)]
            public List<ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfo> InstanceTypeFamilyInfo { get; set; }
            public class ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfo : TeaModel {
                /// <summary>
                /// <para>The instance family.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs-3</para>
                /// </summary>
                [NameInMap("Generation")]
                [Validation(Required=false)]
                public string Generation { get; set; }

                /// <summary>
                /// <para>The ID of the instance family. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.n4</para>
                /// </summary>
                [NameInMap("InstanceTypeFamilyId")]
                [Validation(Required=false)]
                public string InstanceTypeFamilyId { get; set; }

                /// <summary>
                /// <para>The list of instance types.</para>
                /// </summary>
                [NameInMap("Types")]
                [Validation(Required=false)]
                public ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfoTypes Types { get; set; }
                public class ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfoTypes : TeaModel {
                    [NameInMap("TypesInfo")]
                    [Validation(Required=false)]
                    public List<ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfoTypesTypesInfo> TypesInfo { get; set; }
                    public class ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfoTypesTypesInfo : TeaModel {
                        /// <summary>
                        /// <para>The number of vCPUs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("CpuCoreCount")]
                        [Validation(Required=false)]
                        public int? CpuCoreCount { get; set; }

                        /// <summary>
                        /// <para>The maximum number of elastic network interfaces (ENIs) that can be bound to an ECS instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("EniQuantity")]
                        [Validation(Required=false)]
                        public int? EniQuantity { get; set; }

                        /// <summary>
                        /// <para>The number of GPUs of an ECS instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("GPUAmount")]
                        [Validation(Required=false)]
                        public int? GPUAmount { get; set; }

                        /// <summary>
                        /// <para>The GPU type of the ECS instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NVIDIA V100</para>
                        /// </summary>
                        [NameInMap("GPUSpec")]
                        [Validation(Required=false)]
                        public string GPUSpec { get; set; }

                        /// <summary>
                        /// <para>The maximum inbound internal bandwidth. Unit: Kbit/s.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10240000</para>
                        /// </summary>
                        [NameInMap("InstanceBandwidthRx")]
                        [Validation(Required=false)]
                        public int? InstanceBandwidthRx { get; set; }

                        /// <summary>
                        /// <para>The maximum outbound internal bandwidth. Unit: Kbit/s.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10240000</para>
                        /// </summary>
                        [NameInMap("InstanceBandwidthTx")]
                        [Validation(Required=false)]
                        public int? InstanceBandwidthTx { get; set; }

                        /// <summary>
                        /// <para>The inbound packet forwarding rate over the internal network. Unit: pps.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9000000</para>
                        /// </summary>
                        [NameInMap("InstancePpsRx")]
                        [Validation(Required=false)]
                        public int? InstancePpsRx { get; set; }

                        /// <summary>
                        /// <para>The outbound packet forwarding rate over the internal network. Unit: pps.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9000000</para>
                        /// </summary>
                        [NameInMap("InstancePpsTx")]
                        [Validation(Required=false)]
                        public int? InstancePpsTx { get; set; }

                        /// <summary>
                        /// <para>The ID of the ECS instance type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ecs.n4.xlarge</para>
                        /// </summary>
                        [NameInMap("InstanceTypeId")]
                        [Validation(Required=false)]
                        public string InstanceTypeId { get; set; }

                        /// <summary>
                        /// <para>The memory size of the ECS instance. Unit: GiB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8</para>
                        /// </summary>
                        [NameInMap("MemorySize")]
                        [Validation(Required=false)]
                        public int? MemorySize { get; set; }

                        /// <summary>
                        /// <para>The status of the ECS instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>SoldOut</description></item>
                        /// <item><description>Available</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Available</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// <para>The list of zone IDs.</para>
                        /// </summary>
                        [NameInMap("ZoneIds")]
                        [Validation(Required=false)]
                        public ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfoTypesTypesInfoZoneIds ZoneIds { get; set; }
                        public class ListAvailableEcsTypesResponseBodyInstanceTypeFamiliesInstanceTypeFamilyInfoTypesTypesInfoZoneIds : TeaModel {
                            [NameInMap("ZoneId")]
                            [Validation(Required=false)]
                            public List<string> ZoneId { get; set; }

                        }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9DD3AF8-1F91-4075-8669-55D10E45****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Specifies whether preemptible instances are supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: not supported</description></item>
        /// <item><description>true: supported</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SupportSpotInstance")]
        [Validation(Required=false)]
        public bool? SupportSpotInstance { get; set; }

    }

}
