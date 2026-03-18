// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeResourceConstraintsResponseBody : TeaModel {
        /// <summary>
        /// <para>AccessDeniedDetail</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,     &quot;AuthPrincipalOwnerId&quot;: &quot;xxx&quot;,     &quot;EncodedDiagnosticMessage&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalType&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalDisplayName&quot;: &quot;xxx&quot;,     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,     &quot;AuthAction&quot;: &quot;sr:xxx&quot;   }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeResourceConstraintsResponseBodyData Data { get; set; }
        public class DescribeResourceConstraintsResponseBodyData : TeaModel {
            [NameInMap("AgentCu")]
            [Validation(Required=false)]
            public List<int?> AgentCu { get; set; }

            [NameInMap("BeCu")]
            [Validation(Required=false)]
            public List<int?> BeCu { get; set; }

            [NameInMap("BeCuOnEcs")]
            [Validation(Required=false)]
            public List<int?> BeCuOnEcs { get; set; }

            [NameInMap("BeNumber")]
            [Validation(Required=false)]
            public DescribeResourceConstraintsResponseBodyDataBeNumber BeNumber { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataBeNumber : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Default")]
                [Validation(Required=false)]
                public int? Default { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Max")]
                [Validation(Required=false)]
                public int? Max { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Min")]
                [Validation(Required=false)]
                public int? Min { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Step")]
                [Validation(Required=false)]
                public int? Step { get; set; }

            }

            [NameInMap("BeStorageConstraints")]
            [Validation(Required=false)]
            public List<DescribeResourceConstraintsResponseBodyDataBeStorageConstraints> BeStorageConstraints { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataBeStorageConstraints : TeaModel {
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("DiskNumberConstraint")]
                [Validation(Required=false)]
                public DescribeResourceConstraintsResponseBodyDataBeStorageConstraintsDiskNumberConstraint DiskNumberConstraint { get; set; }
                public class DescribeResourceConstraintsResponseBodyDataBeStorageConstraintsDiskNumberConstraint : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Default")]
                    [Validation(Required=false)]
                    public int? Default { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public int? Max { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public int? Step { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("ValueConstraint")]
                [Validation(Required=false)]
                public DescribeResourceConstraintsResponseBodyDataBeStorageConstraintsValueConstraint ValueConstraint { get; set; }
                public class DescribeResourceConstraintsResponseBodyDataBeStorageConstraintsValueConstraint : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Default")]
                    [Validation(Required=false)]
                    public int? Default { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public int? Max { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public int? Step { get; set; }

                }

            }

            [NameInMap("BigDataInstanceTypeConstraints")]
            [Validation(Required=false)]
            public List<DescribeResourceConstraintsResponseBodyDataBigDataInstanceTypeConstraints> BigDataInstanceTypeConstraints { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataBigDataInstanceTypeConstraints : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("DiskNumber")]
                [Validation(Required=false)]
                public string DiskNumber { get; set; }

                [NameInMap("Display")]
                [Validation(Required=false)]
                public string Display { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ecs.d2s.5xlarge</para>
                /// </summary>
                [NameInMap("EcsInstanceType")]
                [Validation(Required=false)]
                public string EcsInstanceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>local_hdd_2s_5xlarge</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public string IsDefault { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>88</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7300</para>
                /// </summary>
                [NameInMap("StorageSize")]
                [Validation(Required=false)]
                public string StorageSize { get; set; }

            }

            [NameInMap("FeCu")]
            [Validation(Required=false)]
            public List<int?> FeCu { get; set; }

            [NameInMap("FeCuOnEcs")]
            [Validation(Required=false)]
            public List<int?> FeCuOnEcs { get; set; }

            [NameInMap("FeNumber")]
            [Validation(Required=false)]
            public DescribeResourceConstraintsResponseBodyDataFeNumber FeNumber { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataFeNumber : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Default")]
                [Validation(Required=false)]
                public int? Default { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("Max")]
                [Validation(Required=false)]
                public int? Max { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Min")]
                [Validation(Required=false)]
                public int? Min { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Step")]
                [Validation(Required=false)]
                public int? Step { get; set; }

            }

            [NameInMap("FeSpecType")]
            [Validation(Required=false)]
            public List<DescribeResourceConstraintsResponseBodyDataFeSpecType> FeSpecType { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataFeSpecType : TeaModel {
                [NameInMap("Display")]
                [Validation(Required=false)]
                public string Display { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("FeStorage")]
            [Validation(Required=false)]
            public DescribeResourceConstraintsResponseBodyDataFeStorage FeStorage { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataFeStorage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("Default")]
                [Validation(Required=false)]
                public int? Default { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("Max")]
                [Validation(Required=false)]
                public int? Max { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Min")]
                [Validation(Required=false)]
                public int? Min { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Step")]
                [Validation(Required=false)]
                public int? Step { get; set; }

            }

            [NameInMap("HaFeResourceSpec")]
            [Validation(Required=false)]
            public DescribeResourceConstraintsResponseBodyDataHaFeResourceSpec HaFeResourceSpec { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataHaFeResourceSpec : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("Cu")]
                [Validation(Required=false)]
                public int? Cu { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("NodeNumber")]
                [Validation(Required=false)]
                public int? NodeNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("StorageSize")]
                [Validation(Required=false)]
                public int? StorageSize { get; set; }

            }

            [NameInMap("LocalSSDInstanceTypeConstraints")]
            [Validation(Required=false)]
            public List<DescribeResourceConstraintsResponseBodyDataLocalSSDInstanceTypeConstraints> LocalSSDInstanceTypeConstraints { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataLocalSSDInstanceTypeConstraints : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DiskNumber")]
                [Validation(Required=false)]
                public string DiskNumber { get; set; }

                [NameInMap("Display")]
                [Validation(Required=false)]
                public string Display { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ecs.i2g.4xlarge</para>
                /// </summary>
                [NameInMap("EcsInstanceType")]
                [Validation(Required=false)]
                public string EcsInstanceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>local_ssd_2g_4xlarge</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public string IsDefault { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>64</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1788</para>
                /// </summary>
                [NameInMap("StorageSize")]
                [Validation(Required=false)]
                public string StorageSize { get; set; }

            }

            [NameInMap("NormalFeResourceSpec")]
            [Validation(Required=false)]
            public DescribeResourceConstraintsResponseBodyDataNormalFeResourceSpec NormalFeResourceSpec { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataNormalFeResourceSpec : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>64</para>
                /// </summary>
                [NameInMap("Cu")]
                [Validation(Required=false)]
                public int? Cu { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("NodeNumber")]
                [Validation(Required=false)]
                public int? NodeNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("StorageSize")]
                [Validation(Required=false)]
                public int? StorageSize { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("SpecType")]
            [Validation(Required=false)]
            public List<DescribeResourceConstraintsResponseBodyDataSpecType> SpecType { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataSpecType : TeaModel {
                [NameInMap("Display")]
                [Validation(Required=false)]
                public string Display { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("SplitDiskThresholdMap")]
            [Validation(Required=false)]
            public Dictionary<string, Dictionary<string, object>> SplitDiskThresholdMap { get; set; }

            [NameInMap("VersionConstraint")]
            [Validation(Required=false)]
            public DescribeResourceConstraintsResponseBodyDataVersionConstraint VersionConstraint { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataVersionConstraint : TeaModel {
                [NameInMap("BetaVersions")]
                [Validation(Required=false)]
                public List<string> BetaVersions { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3.3</para>
                /// </summary>
                [NameInMap("DefaultVersion")]
                [Validation(Required=false)]
                public string DefaultVersion { get; set; }

                [NameInMap("Versions")]
                [Validation(Required=false)]
                public List<string> Versions { get; set; }

            }

            [NameInMap("ZoneSupportedEedTypes")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> ZoneSupportedEedTypes { get; set; }

            [NameInMap("ZoneSupportedSpecTypes")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> ZoneSupportedSpecTypes { get; set; }

            [NameInMap("compactionServiceCuConstraint")]
            [Validation(Required=false)]
            public DescribeResourceConstraintsResponseBodyDataCompactionServiceCuConstraint CompactionServiceCuConstraint { get; set; }
            public class DescribeResourceConstraintsResponseBodyDataCompactionServiceCuConstraint : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("def")]
                [Validation(Required=false)]
                public int? Def { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>256</para>
                /// </summary>
                [NameInMap("max")]
                [Validation(Required=false)]
                public int? Max { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("min")]
                [Validation(Required=false)]
                public int? Min { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("step")]
                [Validation(Required=false)]
                public int? Step { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Invalid params: [instance not exists].</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B67D142D-D54E-184F-A306-22BDC01B2XXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
