// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeMultiZoneAvailableResourceResponseBody : TeaModel {
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public DescribeMultiZoneAvailableResourceResponseBodyAvailableZones AvailableZones { get; set; }
        public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZones : TeaModel {
            [NameInMap("AvailableZone")]
            [Validation(Required=false)]
            public List<DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZone> AvailableZone { get; set; }
            public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZone : TeaModel {
                [NameInMap("MasterResources")]
                [Validation(Required=false)]
                public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneMasterResources MasterResources { get; set; }
                public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneMasterResources : TeaModel {
                    [NameInMap("MasterResource")]
                    [Validation(Required=false)]
                    public List<DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneMasterResourcesMasterResource> MasterResource { get; set; }
                    public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneMasterResourcesMasterResource : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>hbase.sn2.large</para>
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        [NameInMap("InstanceTypeDetail")]
                        [Validation(Required=false)]
                        public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneMasterResourcesMasterResourceInstanceTypeDetail InstanceTypeDetail { get; set; }
                        public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneMasterResourcesMasterResourceInstanceTypeDetail : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>4</para>
                            /// </summary>
                            [NameInMap("Cpu")]
                            [Validation(Required=false)]
                            public int? Cpu { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>16</para>
                            /// </summary>
                            [NameInMap("Mem")]
                            [Validation(Required=false)]
                            public int? Mem { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SupportedEngines")]
                [Validation(Required=false)]
                public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngines SupportedEngines { get; set; }
                public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngines : TeaModel {
                    [NameInMap("SupportedEngine")]
                    [Validation(Required=false)]
                    public List<DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngine> SupportedEngine { get; set; }
                    public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngine : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>hbaseue</para>
                        /// </summary>
                        [NameInMap("Engine")]
                        [Validation(Required=false)]
                        public string Engine { get; set; }

                        [NameInMap("SupportedEngineVersions")]
                        [Validation(Required=false)]
                        public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersions SupportedEngineVersions { get; set; }
                        public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersions : TeaModel {
                            [NameInMap("SupportedEngineVersion")]
                            [Validation(Required=false)]
                            public List<DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersion> SupportedEngineVersion { get; set; }
                            public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersion : TeaModel {
                                [NameInMap("SupportedCategories")]
                                [Validation(Required=false)]
                                public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategories SupportedCategories { get; set; }
                                public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategories : TeaModel {
                                    [NameInMap("SupportedCategories")]
                                    [Validation(Required=false)]
                                    public List<DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategories> SupportedCategories { get; set; }
                                    public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategories : TeaModel {
                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>cluster</para>
                                        /// </summary>
                                        [NameInMap("Category")]
                                        [Validation(Required=false)]
                                        public string Category { get; set; }

                                        [NameInMap("SupportedStorageTypes")]
                                        [Validation(Required=false)]
                                        public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypes SupportedStorageTypes { get; set; }
                                        public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypes : TeaModel {
                                            [NameInMap("SupportedStorageType")]
                                            [Validation(Required=false)]
                                            public List<DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageType> SupportedStorageType { get; set; }
                                            public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageType : TeaModel {
                                                [NameInMap("CoreResources")]
                                                [Validation(Required=false)]
                                                public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResources CoreResources { get; set; }
                                                public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResources : TeaModel {
                                                    [NameInMap("CoreResource")]
                                                    [Validation(Required=false)]
                                                    public List<DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourcesCoreResource> CoreResource { get; set; }
                                                    public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourcesCoreResource : TeaModel {
                                                        [NameInMap("DBInstanceStorageRange")]
                                                        [Validation(Required=false)]
                                                        public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourcesCoreResourceDBInstanceStorageRange DBInstanceStorageRange { get; set; }
                                                        public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourcesCoreResourceDBInstanceStorageRange : TeaModel {
                                                            /// <summary>
                                                            /// <b>Example:</b>
                                                            /// <para>64000</para>
                                                            /// </summary>
                                                            [NameInMap("MaxSize")]
                                                            [Validation(Required=false)]
                                                            public int? MaxSize { get; set; }

                                                            /// <summary>
                                                            /// <b>Example:</b>
                                                            /// <para>400</para>
                                                            /// </summary>
                                                            [NameInMap("MinSize")]
                                                            [Validation(Required=false)]
                                                            public int? MinSize { get; set; }

                                                            /// <summary>
                                                            /// <b>Example:</b>
                                                            /// <para>40</para>
                                                            /// </summary>
                                                            [NameInMap("StepSize")]
                                                            [Validation(Required=false)]
                                                            public int? StepSize { get; set; }

                                                        }

                                                        /// <summary>
                                                        /// <b>Example:</b>
                                                        /// <para>hbase.sn2.2xlarge</para>
                                                        /// </summary>
                                                        [NameInMap("InstanceType")]
                                                        [Validation(Required=false)]
                                                        public string InstanceType { get; set; }

                                                        [NameInMap("InstanceTypeDetail")]
                                                        [Validation(Required=false)]
                                                        public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourcesCoreResourceInstanceTypeDetail InstanceTypeDetail { get; set; }
                                                        public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourcesCoreResourceInstanceTypeDetail : TeaModel {
                                                            /// <summary>
                                                            /// <b>Example:</b>
                                                            /// <para>32</para>
                                                            /// </summary>
                                                            [NameInMap("Cpu")]
                                                            [Validation(Required=false)]
                                                            public int? Cpu { get; set; }

                                                            /// <summary>
                                                            /// <b>Example:</b>
                                                            /// <para>8</para>
                                                            /// </summary>
                                                            [NameInMap("Mem")]
                                                            [Validation(Required=false)]
                                                            public int? Mem { get; set; }

                                                        }

                                                        /// <summary>
                                                        /// <b>Example:</b>
                                                        /// <para>30</para>
                                                        /// </summary>
                                                        [NameInMap("MaxCoreCount")]
                                                        [Validation(Required=false)]
                                                        public int? MaxCoreCount { get; set; }

                                                    }

                                                }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>cloud_efficiency</para>
                                                /// </summary>
                                                [NameInMap("StorageType")]
                                                [Validation(Required=false)]
                                                public string StorageType { get; set; }

                                            }

                                        }

                                    }

                                }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>2.0</para>
                                /// </summary>
                                [NameInMap("Version")]
                                [Validation(Required=false)]
                                public string Version { get; set; }

                            }

                        }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou-bef-aliyun</para>
                /// </summary>
                [NameInMap("ZoneCombination")]
                [Validation(Required=false)]
                public string ZoneCombination { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B2EEBBA9-C627-4415-81A0-B77BC54F1D52</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
