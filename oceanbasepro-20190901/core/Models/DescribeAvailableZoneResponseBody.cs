// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAvailableZoneResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAvailableZoneResponseBodyData Data { get; set; }
        public class DescribeAvailableZoneResponseBodyData : TeaModel {
            [NameInMap("AvailableZones")]
            [Validation(Required=false)]
            public List<DescribeAvailableZoneResponseBodyDataAvailableZones> AvailableZones { get; set; }
            public class DescribeAvailableZoneResponseBodyDataAvailableZones : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>PUBLIC</para>
                /// </summary>
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>x86</para>
                /// </summary>
                [NameInMap("CpuArch")]
                [Validation(Required=false)]
                public string CpuArch { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>multiple</para>
                /// </summary>
                [NameInMap("DeployType")]
                [Validation(Required=false)]
                public string DeployType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cluster</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("Series")]
                [Validation(Required=false)]
                public string Series { get; set; }

                [NameInMap("SupportSpecifications")]
                [Validation(Required=false)]
                public List<DescribeAvailableZoneResponseBodyDataAvailableZonesSupportSpecifications> SupportSpecifications { get; set; }
                public class DescribeAvailableZoneResponseBodyDataAvailableZonesSupportSpecifications : TeaModel {
                    [NameInMap("DiskSizeRange")]
                    [Validation(Required=false)]
                    public DescribeAvailableZoneResponseBodyDataAvailableZonesSupportSpecificationsDiskSizeRange DiskSizeRange { get; set; }
                    public class DescribeAvailableZoneResponseBodyDataAvailableZonesSupportSpecificationsDiskSizeRange : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>40000</para>
                        /// </summary>
                        [NameInMap("Max")]
                        [Validation(Required=false)]
                        public long? Max { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1000</para>
                        /// </summary>
                        [NameInMap("Min")]
                        [Validation(Required=false)]
                        public long? Min { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Step")]
                        [Validation(Required=false)]
                        public long? Step { get; set; }

                    }

                    [NameInMap("DiskTypes")]
                    [Validation(Required=false)]
                    public List<string> DiskTypes { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4C16GB</para>
                    /// </summary>
                    [NameInMap("InstanceClass")]
                    [Validation(Required=false)]
                    public string InstanceClass { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>oceanbase.cluster.cd8.xlarge</para>
                    /// </summary>
                    [NameInMap("Spec")]
                    [Validation(Required=false)]
                    public string Spec { get; set; }

                    [NameInMap("SupportEngineVersions")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableZoneResponseBodyDataAvailableZonesSupportSpecificationsSupportEngineVersions> SupportEngineVersions { get; set; }
                    public class DescribeAvailableZoneResponseBodyDataAvailableZonesSupportSpecificationsSupportEngineVersions : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3.2.4.4</para>
                        /// </summary>
                        [NameInMap("ObVersion")]
                        [Validation(Required=false)]
                        public string ObVersion { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("SupportIsolationOptimization")]
                        [Validation(Required=false)]
                        public bool? SupportIsolationOptimization { get; set; }

                        [NameInMap("SupportReplicaModes")]
                        [Validation(Required=false)]
                        public List<string> SupportReplicaModes { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h,cn-hangzhou-i,cn-hangzhou-j</para>
                /// </summary>
                [NameInMap("Zones")]
                [Validation(Required=false)]
                public string Zones { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
