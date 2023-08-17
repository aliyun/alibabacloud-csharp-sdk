// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        /// <summary>
        /// The resources available in elastic mode.
        /// </summary>
        [NameInMap("AvailableZoneList")]
        [Validation(Required=false)]
        public List<DescribeAvailableResourceResponseBodyAvailableZoneList> AvailableZoneList { get; set; }
        public class DescribeAvailableResourceResponseBodyAvailableZoneList : TeaModel {
            [NameInMap("SupportedComputeResource")]
            [Validation(Required=false)]
            public List<string> SupportedComputeResource { get; set; }

            /// <summary>
            /// The available computing resources.
            /// </summary>
            [NameInMap("SupportedMode")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodyAvailableZoneListSupportedMode> SupportedMode { get; set; }
            public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedMode : TeaModel {
                /// <summary>
                /// N/A
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// The available elastic I/O units (EIUs).
                /// </summary>
                [NameInMap("SupportedSerialList")]
                [Validation(Required=false)]
                public List<DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialList> SupportedSerialList { get; set; }
                public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialList : TeaModel {
                    /// <summary>
                    /// The step size.
                    /// </summary>
                    [NameInMap("Serial")]
                    [Validation(Required=false)]
                    public string Serial { get; set; }

                    /// <summary>
                    /// The minimum number of EIUs.
                    /// </summary>
                    [NameInMap("SupportedFlexibleResource")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedFlexibleResource> SupportedFlexibleResource { get; set; }
                    public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedFlexibleResource : TeaModel {
                        /// <summary>
                        /// The maximum number of EIUs.
                        /// </summary>
                        [NameInMap("StorageType")]
                        [Validation(Required=false)]
                        public string StorageType { get; set; }

                        [NameInMap("SupportedComputeResource")]
                        [Validation(Required=false)]
                        public List<string> SupportedComputeResource { get; set; }

                        [NameInMap("SupportedElasticIOResource")]
                        [Validation(Required=false)]
                        public DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedFlexibleResourceSupportedElasticIOResource SupportedElasticIOResource { get; set; }
                        public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedFlexibleResourceSupportedElasticIOResource : TeaModel {
                            [NameInMap("MaxCount")]
                            [Validation(Required=false)]
                            public string MaxCount { get; set; }

                            [NameInMap("MinCount")]
                            [Validation(Required=false)]
                            public string MinCount { get; set; }

                            [NameInMap("Step")]
                            [Validation(Required=false)]
                            public string Step { get; set; }

                        }

                        [NameInMap("SupportedStorageResource")]
                        [Validation(Required=false)]
                        public List<string> SupportedStorageResource { get; set; }

                    }

                    [NameInMap("SupportedInstanceClassList")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassList> SupportedInstanceClassList { get; set; }
                    public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassList : TeaModel {
                        [NameInMap("InstanceClass")]
                        [Validation(Required=false)]
                        public string InstanceClass { get; set; }

                        [NameInMap("SupportedExecutorList")]
                        [Validation(Required=false)]
                        public List<DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedExecutorList> SupportedExecutorList { get; set; }
                        public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedExecutorList : TeaModel {
                            [NameInMap("NodeCount")]
                            [Validation(Required=false)]
                            public DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedExecutorListNodeCount NodeCount { get; set; }
                            public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedExecutorListNodeCount : TeaModel {
                                [NameInMap("MaxCount")]
                                [Validation(Required=false)]
                                public string MaxCount { get; set; }

                                [NameInMap("MinCount")]
                                [Validation(Required=false)]
                                public string MinCount { get; set; }

                                [NameInMap("Step")]
                                [Validation(Required=false)]
                                public string Step { get; set; }

                            }

                        }

                        [NameInMap("SupportedNodeCountList")]
                        [Validation(Required=false)]
                        public List<DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedNodeCountList> SupportedNodeCountList { get; set; }
                        public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedNodeCountList : TeaModel {
                            [NameInMap("NodeCount")]
                            [Validation(Required=false)]
                            public DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedNodeCountListNodeCount NodeCount { get; set; }
                            public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedNodeCountListNodeCount : TeaModel {
                                [NameInMap("MaxCount")]
                                [Validation(Required=false)]
                                public string MaxCount { get; set; }

                                [NameInMap("MinCount")]
                                [Validation(Required=false)]
                                public string MinCount { get; set; }

                                [NameInMap("Step")]
                                [Validation(Required=false)]
                                public string Step { get; set; }

                            }

                            [NameInMap("StorageSize")]
                            [Validation(Required=false)]
                            public List<string> StorageSize { get; set; }

                        }

                        [NameInMap("Tips")]
                        [Validation(Required=false)]
                        public string Tips { get; set; }

                    }

                }

            }

            [NameInMap("SupportedStorageResource")]
            [Validation(Required=false)]
            public List<string> SupportedStorageResource { get; set; }

            /// <summary>
            /// The storage type. Valid values:
            /// 
            /// *   **hdd**
            /// *   **ssd**
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// The resources available in the supported editions.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The supported edition. Valid values:
        /// 
        /// *   **basic**: Basic Edition
        /// *   **cluster**: Cluster Edition
        /// *   **mixed_storage**: elastic mode for Cluster Edition
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
