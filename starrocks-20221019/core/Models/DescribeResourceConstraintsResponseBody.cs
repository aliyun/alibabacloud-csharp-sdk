// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeResourceConstraintsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,     &quot;AuthPrincipalOwnerId&quot;: &quot;xxx&quot;,     &quot;EncodedDiagnosticMessage&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalType&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalDisplayName&quot;: &quot;xxx&quot;,     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,     &quot;AuthAction&quot;: &quot;sr:xxx&quot;   }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeResourceConstraintsResponseBodyData Data { get; set; }
        public class DescribeResourceConstraintsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The CU sizes for agents.</para>
            /// </summary>
            [NameInMap("AgentCu")]
            [Validation(Required=false)]
            public List<int?> AgentCu { get; set; }

            /// <summary>
            /// <para>The available CU (Compute Unit) sizes for BE nodes.</para>
            /// </summary>
            [NameInMap("BeCu")]
            [Validation(Required=false)]
            public List<int?> BeCu { get; set; }

            /// <summary>
            /// <para>The CU sizes for BE nodes on ECS.</para>
            /// </summary>
            [NameInMap("BeCuOnEcs")]
            [Validation(Required=false)]
            public List<int?> BeCuOnEcs { get; set; }

            /// <summary>
            /// <para>The BE node configuration.</para>
            /// </summary>
            [NameInMap("BeNumber")]
            [Validation(Required=false)]
            public DescribeResourceConstraintsResponseBodyDataBeNumber BeNumber { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataBeNumber : TeaModel {
                /// <summary>
                /// <para>The default value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Default")]
                [Validation(Required=false)]
                public int? Default { get; set; }

                /// <summary>
                /// <para>The maximum value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Max")]
                [Validation(Required=false)]
                public int? Max { get; set; }

                /// <summary>
                /// <para>The minimum value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Min")]
                [Validation(Required=false)]
                public int? Min { get; set; }

                /// <summary>
                /// <para>The step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Step")]
                [Validation(Required=false)]
                public int? Step { get; set; }

            }

            /// <summary>
            /// <para>The storage constraints for BE nodes.</para>
            /// </summary>
            [NameInMap("BeStorageConstraints")]
            [Validation(Required=false)]
            public List<DescribeResourceConstraintsResponseBodyDataBeStorageConstraints> BeStorageConstraints { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataBeStorageConstraints : TeaModel {
                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BE 存储约束描述</para>
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>The disk count constraint.</para>
                /// </summary>
                [NameInMap("DiskNumberConstraint")]
                [Validation(Required=false)]
                public DescribeResourceConstraintsResponseBodyDataBeStorageConstraintsDiskNumberConstraint DiskNumberConstraint { get; set; }
                public class DescribeResourceConstraintsResponseBodyDataBeStorageConstraintsDiskNumberConstraint : TeaModel {
                    /// <summary>
                    /// <para>The default value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Default")]
                    [Validation(Required=false)]
                    public int? Default { get; set; }

                    /// <summary>
                    /// <para>The maximum number of disks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public int? Max { get; set; }

                    /// <summary>
                    /// <para>The minimum number of disks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                    /// <summary>
                    /// <para>The step.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public int? Step { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether this is the default option.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <para>The disk performance level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The value constraint.</para>
                /// </summary>
                [NameInMap("ValueConstraint")]
                [Validation(Required=false)]
                public DescribeResourceConstraintsResponseBodyDataBeStorageConstraintsValueConstraint ValueConstraint { get; set; }
                public class DescribeResourceConstraintsResponseBodyDataBeStorageConstraintsValueConstraint : TeaModel {
                    /// <summary>
                    /// <para>The default value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Default")]
                    [Validation(Required=false)]
                    public int? Default { get; set; }

                    /// <summary>
                    /// <para>The maximum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public int? Max { get; set; }

                    /// <summary>
                    /// <para>The minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                    /// <summary>
                    /// <para>The step.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public int? Step { get; set; }

                }

            }

            /// <summary>
            /// <para>The specification constraints for big data instance types.</para>
            /// </summary>
            [NameInMap("BigDataInstanceTypeConstraints")]
            [Validation(Required=false)]
            public List<DescribeResourceConstraintsResponseBodyDataBigDataInstanceTypeConstraints> BigDataInstanceTypeConstraints { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataBigDataInstanceTypeConstraints : TeaModel {
                /// <summary>
                /// <para>The number of vCPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The disk count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("DiskNumber")]
                [Validation(Required=false)]
                public string DiskNumber { get; set; }

                /// <summary>
                /// <para>The display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20核 88GiB 8*7300GiB 本地HDD盘</para>
                /// </summary>
                [NameInMap("Display")]
                [Validation(Required=false)]
                public string Display { get; set; }

                /// <summary>
                /// <para>The corresponding ECS instance family.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.d2s.5xlarge</para>
                /// </summary>
                [NameInMap("EcsInstanceType")]
                [Validation(Required=false)]
                public string EcsInstanceType { get; set; }

                /// <summary>
                /// <para>The instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>local_hdd_2s_5xlarge</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>Indicates whether this is the default option.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public string IsDefault { get; set; }

                /// <summary>
                /// <para>The memory size, in GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>88</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                /// <summary>
                /// <para>The storage size, in GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7300</para>
                /// </summary>
                [NameInMap("StorageSize")]
                [Validation(Required=false)]
                public string StorageSize { get; set; }

            }

            /// <summary>
            /// <para>The available CU sizes for FE nodes.</para>
            /// </summary>
            [NameInMap("FeCu")]
            [Validation(Required=false)]
            public List<int?> FeCu { get; set; }

            /// <summary>
            /// <para>The CU sizes for FE nodes on ECS.</para>
            /// </summary>
            [NameInMap("FeCuOnEcs")]
            [Validation(Required=false)]
            public List<int?> FeCuOnEcs { get; set; }

            /// <summary>
            /// <para>The number of FE nodes.</para>
            /// </summary>
            [NameInMap("FeNumber")]
            [Validation(Required=false)]
            public DescribeResourceConstraintsResponseBodyDataFeNumber FeNumber { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataFeNumber : TeaModel {
                /// <summary>
                /// <para>The default value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Default")]
                [Validation(Required=false)]
                public int? Default { get; set; }

                /// <summary>
                /// <para>The maximum value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("Max")]
                [Validation(Required=false)]
                public int? Max { get; set; }

                /// <summary>
                /// <para>The minimum value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Min")]
                [Validation(Required=false)]
                public int? Min { get; set; }

                /// <summary>
                /// <para>The step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Step")]
                [Validation(Required=false)]
                public int? Step { get; set; }

            }

            /// <summary>
            /// <para>The instance types for FE nodes.</para>
            /// </summary>
            [NameInMap("FeSpecType")]
            [Validation(Required=false)]
            public List<DescribeResourceConstraintsResponseBodyDataFeSpecType> FeSpecType { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataFeSpecType : TeaModel {
                /// <summary>
                /// <para>The display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>标准版</para>
                /// </summary>
                [NameInMap("Display")]
                [Validation(Required=false)]
                public string Display { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The storage size for the FE node.</para>
            /// </summary>
            [NameInMap("FeStorage")]
            [Validation(Required=false)]
            public DescribeResourceConstraintsResponseBodyDataFeStorage FeStorage { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataFeStorage : TeaModel {
                /// <summary>
                /// <para>The default value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("Default")]
                [Validation(Required=false)]
                public int? Default { get; set; }

                /// <summary>
                /// <para>The maximum value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("Max")]
                [Validation(Required=false)]
                public int? Max { get; set; }

                /// <summary>
                /// <para>The minimum value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Min")]
                [Validation(Required=false)]
                public int? Min { get; set; }

                /// <summary>
                /// <para>The step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Step")]
                [Validation(Required=false)]
                public int? Step { get; set; }

            }

            /// <summary>
            /// <para>The high availability (HA) FE node configuration.</para>
            /// </summary>
            [NameInMap("HaFeResourceSpec")]
            [Validation(Required=false)]
            public DescribeResourceConstraintsResponseBodyDataHaFeResourceSpec HaFeResourceSpec { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataHaFeResourceSpec : TeaModel {
                /// <summary>
                /// <para>The CU (Compute Unit) size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("Cu")]
                [Validation(Required=false)]
                public int? Cu { get; set; }

                /// <summary>
                /// <para>The total number of nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("NodeNumber")]
                [Validation(Required=false)]
                public int? NodeNumber { get; set; }

                /// <summary>
                /// <para>The storage size, in GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("StorageSize")]
                [Validation(Required=false)]
                public int? StorageSize { get; set; }

            }

            /// <summary>
            /// <para>The specification constraints for local SSD instance types.</para>
            /// </summary>
            [NameInMap("LocalSSDInstanceTypeConstraints")]
            [Validation(Required=false)]
            public List<DescribeResourceConstraintsResponseBodyDataLocalSSDInstanceTypeConstraints> LocalSSDInstanceTypeConstraints { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataLocalSSDInstanceTypeConstraints : TeaModel {
                /// <summary>
                /// <para>The number of vCPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The disk count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DiskNumber")]
                [Validation(Required=false)]
                public string DiskNumber { get; set; }

                /// <summary>
                /// <para>The display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[i2g]16核 64GiB 1*1788GiB 本地SSD盘</para>
                /// </summary>
                [NameInMap("Display")]
                [Validation(Required=false)]
                public string Display { get; set; }

                /// <summary>
                /// <para>The corresponding ECS instance family.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.i2g.4xlarge</para>
                /// </summary>
                [NameInMap("EcsInstanceType")]
                [Validation(Required=false)]
                public string EcsInstanceType { get; set; }

                /// <summary>
                /// <para>The instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>local_ssd_2g_4xlarge</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>Indicates whether this is the default option.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public string IsDefault { get; set; }

                /// <summary>
                /// <para>The memory size, in GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>64</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                /// <summary>
                /// <para>The storage size, in GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1788</para>
                /// </summary>
                [NameInMap("StorageSize")]
                [Validation(Required=false)]
                public string StorageSize { get; set; }

            }

            /// <summary>
            /// <para>The standard FE resource configuration.</para>
            /// </summary>
            [NameInMap("NormalFeResourceSpec")]
            [Validation(Required=false)]
            public DescribeResourceConstraintsResponseBodyDataNormalFeResourceSpec NormalFeResourceSpec { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataNormalFeResourceSpec : TeaModel {
                /// <summary>
                /// <para>The CU (Compute Unit) size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>64</para>
                /// </summary>
                [NameInMap("Cu")]
                [Validation(Required=false)]
                public int? Cu { get; set; }

                /// <summary>
                /// <para>The total number of nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("NodeNumber")]
                [Validation(Required=false)]
                public int? NodeNumber { get; set; }

                /// <summary>
                /// <para>The storage size, in GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("StorageSize")]
                [Validation(Required=false)]
                public int? StorageSize { get; set; }

            }

            /// <summary>
            /// <para>The instance type for compute nodes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>standard</c>: Standard.</para>
            /// </description></item>
            /// <item><description><para><c>localSSD</c>: Local SSD.</para>
            /// </description></item>
            /// <item><description><para><c>bigData</c>: Large-capacity storage.</para>
            /// </description></item>
            /// <item><description><para><c>ramEnhanced</c>: Memory-enhanced.</para>
            /// </description></item>
            /// <item><description><para><c>networkEnhanced</c>: Network-enhanced.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("SpecType")]
            [Validation(Required=false)]
            public List<DescribeResourceConstraintsResponseBodyDataSpecType> SpecType { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataSpecType : TeaModel {
                /// <summary>
                /// <para>The display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>标准版</para>
                /// </summary>
                [NameInMap("Display")]
                [Validation(Required=false)]
                public string Display { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Deprecated.</para>
            /// </summary>
            [NameInMap("SplitDiskThresholdMap")]
            [Validation(Required=false)]
            public Dictionary<string, Dictionary<string, object>> SplitDiskThresholdMap { get; set; }

            /// <summary>
            /// <para>The version constraint.</para>
            /// </summary>
            [NameInMap("VersionConstraint")]
            [Validation(Required=false)]
            public DescribeResourceConstraintsResponseBodyDataVersionConstraint VersionConstraint { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataVersionConstraint : TeaModel {
                /// <summary>
                /// <para>The beta versions.</para>
                /// </summary>
                [NameInMap("BetaVersions")]
                [Validation(Required=false)]
                public List<string> BetaVersions { get; set; }

                /// <summary>
                /// <para>The default version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.3</para>
                /// </summary>
                [NameInMap("DefaultVersion")]
                [Validation(Required=false)]
                public string DefaultVersion { get; set; }

                /// <summary>
                /// <para>The available versions.</para>
                /// </summary>
                [NameInMap("Versions")]
                [Validation(Required=false)]
                public List<string> Versions { get; set; }

            }

            /// <summary>
            /// <para>The EED types supported in each availability zone.</para>
            /// </summary>
            [NameInMap("ZoneSupportedEedTypes")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> ZoneSupportedEedTypes { get; set; }

            /// <summary>
            /// <para>The instance types supported in each availability zone.</para>
            /// </summary>
            [NameInMap("ZoneSupportedSpecTypes")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> ZoneSupportedSpecTypes { get; set; }

            /// <summary>
            /// <para>The CU constraints for the compaction service.</para>
            /// </summary>
            [NameInMap("compactionServiceCuConstraint")]
            [Validation(Required=false)]
            public DescribeResourceConstraintsResponseBodyDataCompactionServiceCuConstraint CompactionServiceCuConstraint { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataCompactionServiceCuConstraint : TeaModel {
                /// <summary>
                /// <para>The default value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("def")]
                [Validation(Required=false)]
                public int? Def { get; set; }

                /// <summary>
                /// <para>The maximum value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>256</para>
                /// </summary>
                [NameInMap("max")]
                [Validation(Required=false)]
                public int? Max { get; set; }

                /// <summary>
                /// <para>The minimum value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("min")]
                [Validation(Required=false)]
                public int? Min { get; set; }

                /// <summary>
                /// <para>The step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("step")]
                [Validation(Required=false)]
                public int? Step { get; set; }

            }

            /// <summary>
            /// <para>The compaction services supported in each availability zone.</para>
            /// </summary>
            [NameInMap("zoneSupportCompactionService")]
            [Validation(Required=false)]
            public Dictionary<string, List<DataZoneSupportCompactionServiceValue>> ZoneSupportCompactionService { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid params: [instance not exists].</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The error code. A value of <c>Success</c> indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B67D142D-D54E-184F-A306-22BDC01B2XXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
