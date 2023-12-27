// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        /// <summary>
        /// The supported zones.
        /// </summary>
        [NameInMap("AvailableZoneList")]
        [Validation(Required=false)]
        public List<DescribeAvailableResourceResponseBodyAvailableZoneList> AvailableZoneList { get; set; }
        public class DescribeAvailableResourceResponseBodyAvailableZoneList : TeaModel {
            /// <summary>
            /// A reserved parameter.
            /// </summary>
            [NameInMap("SupportedComputeResource")]
            [Validation(Required=false)]
            public List<string> SupportedComputeResource { get; set; }

            /// <summary>
            /// The supported modes.
            /// </summary>
            [NameInMap("SupportedMode")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodyAvailableZoneListSupportedMode> SupportedMode { get; set; }
            public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedMode : TeaModel {
                /// <summary>
                /// The supported mode. Valid values:
                /// 
                /// *   **flexible**: elastic mode.
                /// *   **reserver**: reserved mode.
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// The supported editions.
                /// </summary>
                [NameInMap("SupportedSerialList")]
                [Validation(Required=false)]
                public List<DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialList> SupportedSerialList { get; set; }
                public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialList : TeaModel {
                    /// <summary>
                    /// The supported edition. Valid values:
                    /// 
                    /// *   **basic**: Basic Edition.
                    /// *   **cluster**: Cluster Edition.
                    /// *   **mixed_storage**: elastic mode for Cluster Edition.
                    /// </summary>
                    [NameInMap("Serial")]
                    [Validation(Required=false)]
                    public string Serial { get; set; }

                    /// <summary>
                    /// The supported resources in elastic mode.
                    /// </summary>
                    [NameInMap("SupportedFlexibleResource")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedFlexibleResource> SupportedFlexibleResource { get; set; }
                    public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedFlexibleResource : TeaModel {
                        /// <summary>
                        /// The disk storage type. Valid values:
                        /// 
                        /// *   **hdd**
                        /// *   **ssd**
                        /// </summary>
                        [NameInMap("StorageType")]
                        [Validation(Required=false)]
                        public string StorageType { get; set; }

                        /// <summary>
                        /// The supported computing resources.
                        /// </summary>
                        [NameInMap("SupportedComputeResource")]
                        [Validation(Required=false)]
                        public List<string> SupportedComputeResource { get; set; }

                        /// <summary>
                        /// The supported elastic I/O resources.
                        /// </summary>
                        [NameInMap("SupportedElasticIOResource")]
                        [Validation(Required=false)]
                        public DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedFlexibleResourceSupportedElasticIOResource SupportedElasticIOResource { get; set; }
                        public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedFlexibleResourceSupportedElasticIOResource : TeaModel {
                            /// <summary>
                            /// The maximum amount of elastic I/O resources.
                            /// </summary>
                            [NameInMap("MaxCount")]
                            [Validation(Required=false)]
                            public string MaxCount { get; set; }

                            /// <summary>
                            /// The minimum amount of elastic I/O resources.
                            /// </summary>
                            [NameInMap("MinCount")]
                            [Validation(Required=false)]
                            public string MinCount { get; set; }

                            /// <summary>
                            /// The step size.
                            /// </summary>
                            [NameInMap("Step")]
                            [Validation(Required=false)]
                            public string Step { get; set; }

                        }

                        /// <summary>
                        /// The supported storage resources.
                        /// </summary>
                        [NameInMap("SupportedStorageResource")]
                        [Validation(Required=false)]
                        public List<string> SupportedStorageResource { get; set; }

                    }

                    /// <summary>
                    /// The supported resources in reserved mode.
                    /// </summary>
                    [NameInMap("SupportedInstanceClassList")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassList> SupportedInstanceClassList { get; set; }
                    public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassList : TeaModel {
                        /// <summary>
                        /// The supported instance type.
                        /// </summary>
                        [NameInMap("InstanceClass")]
                        [Validation(Required=false)]
                        public string InstanceClass { get; set; }

                        /// <summary>
                        /// A reserved parameter.
                        /// </summary>
                        [NameInMap("SupportedExecutorList")]
                        [Validation(Required=false)]
                        public List<DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedExecutorList> SupportedExecutorList { get; set; }
                        public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedExecutorList : TeaModel {
                            /// <summary>
                            /// The information about the supported compute nodes.
                            /// </summary>
                            [NameInMap("NodeCount")]
                            [Validation(Required=false)]
                            public DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedExecutorListNodeCount NodeCount { get; set; }
                            public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedExecutorListNodeCount : TeaModel {
                                /// <summary>
                                /// A reserved parameter.
                                /// </summary>
                                [NameInMap("MaxCount")]
                                [Validation(Required=false)]
                                public string MaxCount { get; set; }

                                /// <summary>
                                /// A reserved parameter.
                                /// </summary>
                                [NameInMap("MinCount")]
                                [Validation(Required=false)]
                                public string MinCount { get; set; }

                                /// <summary>
                                /// A reserved parameter.
                                /// </summary>
                                [NameInMap("Step")]
                                [Validation(Required=false)]
                                public string Step { get; set; }

                            }

                        }

                        /// <summary>
                        /// The supported compute nodes.
                        /// </summary>
                        [NameInMap("SupportedNodeCountList")]
                        [Validation(Required=false)]
                        public List<DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedNodeCountList> SupportedNodeCountList { get; set; }
                        public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedNodeCountList : TeaModel {
                            /// <summary>
                            /// The number of the supported compute nodes.
                            /// </summary>
                            [NameInMap("NodeCount")]
                            [Validation(Required=false)]
                            public DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedNodeCountListNodeCount NodeCount { get; set; }
                            public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedNodeCountListNodeCount : TeaModel {
                                /// <summary>
                                /// The maximum number of compute nodes.
                                /// </summary>
                                [NameInMap("MaxCount")]
                                [Validation(Required=false)]
                                public string MaxCount { get; set; }

                                /// <summary>
                                /// The minimum number of compute nodes.
                                /// </summary>
                                [NameInMap("MinCount")]
                                [Validation(Required=false)]
                                public string MinCount { get; set; }

                                /// <summary>
                                /// The step size.
                                /// </summary>
                                [NameInMap("Step")]
                                [Validation(Required=false)]
                                public string Step { get; set; }

                            }

                            /// <summary>
                            /// The support storage capacity. Unit: GB.
                            /// </summary>
                            [NameInMap("StorageSize")]
                            [Validation(Required=false)]
                            public List<string> StorageSize { get; set; }

                        }

                        /// <summary>
                        /// The description of the instance type.
                        /// </summary>
                        [NameInMap("Tips")]
                        [Validation(Required=false)]
                        public string Tips { get; set; }

                    }

                }

            }

            /// <summary>
            /// A reserved parameter.
            /// </summary>
            [NameInMap("SupportedStorageResource")]
            [Validation(Required=false)]
            public List<string> SupportedStorageResource { get; set; }

            /// <summary>
            /// The zone ID.
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
