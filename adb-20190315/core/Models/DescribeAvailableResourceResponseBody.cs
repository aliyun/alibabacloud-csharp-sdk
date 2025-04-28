// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The supported zones.</para>
        /// </summary>
        [NameInMap("AvailableZoneList")]
        [Validation(Required=false)]
        public List<DescribeAvailableResourceResponseBodyAvailableZoneList> AvailableZoneList { get; set; }
        public class DescribeAvailableResourceResponseBodyAvailableZoneList : TeaModel {
            /// <summary>
            /// <para>A reserved parameter.</para>
            /// </summary>
            [NameInMap("SupportedComputeResource")]
            [Validation(Required=false)]
            public List<string> SupportedComputeResource { get; set; }

            /// <summary>
            /// <para>The supported modes.</para>
            /// </summary>
            [NameInMap("SupportedMode")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodyAvailableZoneListSupportedMode> SupportedMode { get; set; }
            public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedMode : TeaModel {
                /// <summary>
                /// <para>The supported mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>flexible</b>: elastic mode.</description></item>
                /// <item><description><b>reserver</b>: reserved mode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>flexible</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The supported editions.</para>
                /// </summary>
                [NameInMap("SupportedSerialList")]
                [Validation(Required=false)]
                public List<DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialList> SupportedSerialList { get; set; }
                public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialList : TeaModel {
                    /// <summary>
                    /// <para>The supported edition. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>basic</b>: Basic Edition.</description></item>
                    /// <item><description><b>cluster</b>: Cluster Edition.</description></item>
                    /// <item><description><b>mixed_storage</b>: elastic mode for Cluster Edition.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mixed_storage</para>
                    /// </summary>
                    [NameInMap("Serial")]
                    [Validation(Required=false)]
                    public string Serial { get; set; }

                    /// <summary>
                    /// <para>The supported resources in elastic mode.</para>
                    /// </summary>
                    [NameInMap("SupportedFlexibleResource")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedFlexibleResource> SupportedFlexibleResource { get; set; }
                    public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedFlexibleResource : TeaModel {
                        /// <summary>
                        /// <para>The disk storage type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>hdd</b></description></item>
                        /// <item><description><b>ssd</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>hdd</para>
                        /// </summary>
                        [NameInMap("StorageType")]
                        [Validation(Required=false)]
                        public string StorageType { get; set; }

                        /// <summary>
                        /// <para>The supported computing resources.</para>
                        /// </summary>
                        [NameInMap("SupportedComputeResource")]
                        [Validation(Required=false)]
                        public List<string> SupportedComputeResource { get; set; }

                        /// <summary>
                        /// <para>The supported elastic I/O resources.</para>
                        /// </summary>
                        [NameInMap("SupportedElasticIOResource")]
                        [Validation(Required=false)]
                        public DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedFlexibleResourceSupportedElasticIOResource SupportedElasticIOResource { get; set; }
                        public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedFlexibleResourceSupportedElasticIOResource : TeaModel {
                            /// <summary>
                            /// <para>The maximum amount of elastic I/O resources.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>200</para>
                            /// </summary>
                            [NameInMap("MaxCount")]
                            [Validation(Required=false)]
                            public string MaxCount { get; set; }

                            /// <summary>
                            /// <para>The minimum amount of elastic I/O resources.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("MinCount")]
                            [Validation(Required=false)]
                            public string MinCount { get; set; }

                            /// <summary>
                            /// <para>The step size.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("Step")]
                            [Validation(Required=false)]
                            public string Step { get; set; }

                        }

                        /// <summary>
                        /// <para>The supported storage resources.</para>
                        /// </summary>
                        [NameInMap("SupportedStorageResource")]
                        [Validation(Required=false)]
                        public List<string> SupportedStorageResource { get; set; }

                    }

                    /// <summary>
                    /// <para>The supported resources in reserved mode.</para>
                    /// </summary>
                    [NameInMap("SupportedInstanceClassList")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassList> SupportedInstanceClassList { get; set; }
                    public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassList : TeaModel {
                        /// <summary>
                        /// <para>The supported instance type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>C32</para>
                        /// </summary>
                        [NameInMap("InstanceClass")]
                        [Validation(Required=false)]
                        public string InstanceClass { get; set; }

                        /// <summary>
                        /// <para>A reserved parameter.</para>
                        /// </summary>
                        [NameInMap("SupportedExecutorList")]
                        [Validation(Required=false)]
                        public List<DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedExecutorList> SupportedExecutorList { get; set; }
                        public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedExecutorList : TeaModel {
                            /// <summary>
                            /// <para>The information about the supported compute nodes.</para>
                            /// </summary>
                            [NameInMap("NodeCount")]
                            [Validation(Required=false)]
                            public DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedExecutorListNodeCount NodeCount { get; set; }
                            public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedExecutorListNodeCount : TeaModel {
                                /// <summary>
                                /// <para>A reserved parameter.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>N/A</para>
                                /// </summary>
                                [NameInMap("MaxCount")]
                                [Validation(Required=false)]
                                public string MaxCount { get; set; }

                                /// <summary>
                                /// <para>A reserved parameter.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>N/A</para>
                                /// </summary>
                                [NameInMap("MinCount")]
                                [Validation(Required=false)]
                                public string MinCount { get; set; }

                                /// <summary>
                                /// <para>A reserved parameter.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>N/A</para>
                                /// </summary>
                                [NameInMap("Step")]
                                [Validation(Required=false)]
                                public string Step { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The supported compute nodes.</para>
                        /// </summary>
                        [NameInMap("SupportedNodeCountList")]
                        [Validation(Required=false)]
                        public List<DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedNodeCountList> SupportedNodeCountList { get; set; }
                        public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedNodeCountList : TeaModel {
                            /// <summary>
                            /// <para>The number of the supported compute nodes.</para>
                            /// </summary>
                            [NameInMap("NodeCount")]
                            [Validation(Required=false)]
                            public DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedNodeCountListNodeCount NodeCount { get; set; }
                            public class DescribeAvailableResourceResponseBodyAvailableZoneListSupportedModeSupportedSerialListSupportedInstanceClassListSupportedNodeCountListNodeCount : TeaModel {
                                /// <summary>
                                /// <para>The maximum number of compute nodes.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>200</para>
                                /// </summary>
                                [NameInMap("MaxCount")]
                                [Validation(Required=false)]
                                public string MaxCount { get; set; }

                                /// <summary>
                                /// <para>The minimum number of compute nodes.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("MinCount")]
                                [Validation(Required=false)]
                                public string MinCount { get; set; }

                                /// <summary>
                                /// <para>The step size.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("Step")]
                                [Validation(Required=false)]
                                public string Step { get; set; }

                            }

                            /// <summary>
                            /// <para>The support storage capacity. Unit: GB.</para>
                            /// </summary>
                            [NameInMap("StorageSize")]
                            [Validation(Required=false)]
                            public List<string> StorageSize { get; set; }

                        }

                        /// <summary>
                        /// <para>The description of the instance type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>C32</para>
                        /// </summary>
                        [NameInMap("Tips")]
                        [Validation(Required=false)]
                        public string Tips { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>A reserved parameter.</para>
            /// </summary>
            [NameInMap("SupportedStorageResource")]
            [Validation(Required=false)]
            public List<string> SupportedStorageResource { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            /// <summary>
            /// <para>The name of the zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-k</para>
            /// </summary>
            [NameInMap("ZoneName")]
            [Validation(Required=false)]
            public string ZoneName { get; set; }

        }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
