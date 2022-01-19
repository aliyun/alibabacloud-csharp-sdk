// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        [NameInMap("AvailableZoneList")]
        [Validation(Required=false)]
        public DescribeAvailableResourceResponseBodyAvailableZoneList AvailableZoneList { get; set; }
        public class DescribeAvailableResourceResponseBodyAvailableZoneList : TeaModel {
            [NameInMap("AvailableZone")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZone> AvailableZone { get; set; }
            public class DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZone : TeaModel {
                public DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialList SupportedSerialList { get; set; }
                public class DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialList : TeaModel {
                    [NameInMap("SupportedSerial")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerial> SupportedSerial { get; set; }
                    public class DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerial : TeaModel {
                        [NameInMap("Serial")]
                        [Validation(Required=false)]
                        public string Serial { get; set; }

                        [NameInMap("SupportedInstanceClassList")]
                        [Validation(Required=false)]
                        public DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassList SupportedInstanceClassList { get; set; }
                        public class DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassList : TeaModel {
                            [NameInMap("SupportedInstanceClass")]
                            [Validation(Required=false)]
                            public List<DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClass> SupportedInstanceClass { get; set; }
                            public class DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClass : TeaModel {
                                public string InstanceClass { get; set; }
                                public DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClassSupportedExecutorList SupportedExecutorList { get; set; }
                                public class DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClassSupportedExecutorList : TeaModel {
                                    [NameInMap("SupportedExecutor")]
                                    [Validation(Required=false)]
                                    public List<DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClassSupportedExecutorListSupportedExecutor> SupportedExecutor { get; set; }
                                    public class DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClassSupportedExecutorListSupportedExecutor : TeaModel {
                                        [NameInMap("NodeCount")]
                                        [Validation(Required=false)]
                                        public DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClassSupportedExecutorListSupportedExecutorNodeCount NodeCount { get; set; }
                                        public class DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClassSupportedExecutorListSupportedExecutorNodeCount : TeaModel {
                                            [NameInMap("MaxCount")]
                                            [Validation(Required=false)]
                                            public string MaxCount { get; set; }
                                            [NameInMap("MinCount")]
                                            [Validation(Required=false)]
                                            public string MinCount { get; set; }
                                            [NameInMap("Step")]
                                            [Validation(Required=false)]
                                            public string Step { get; set; }
                                        };

                                    }

                                }
                                public DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClassSupportedNodeCountList SupportedNodeCountList { get; set; }
                                public class DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClassSupportedNodeCountList : TeaModel {
                                    [NameInMap("SupportedNodeCount")]
                                    [Validation(Required=false)]
                                    public List<DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClassSupportedNodeCountListSupportedNodeCount> SupportedNodeCount { get; set; }
                                    public class DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClassSupportedNodeCountListSupportedNodeCount : TeaModel {
                                        [NameInMap("NodeCount")]
                                        [Validation(Required=false)]
                                        public DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClassSupportedNodeCountListSupportedNodeCountNodeCount NodeCount { get; set; }
                                        public class DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClassSupportedNodeCountListSupportedNodeCountNodeCount : TeaModel {
                                            [NameInMap("MaxCount")]
                                            [Validation(Required=false)]
                                            public string MaxCount { get; set; }
                                            [NameInMap("MinCount")]
                                            [Validation(Required=false)]
                                            public string MinCount { get; set; }
                                            [NameInMap("Step")]
                                            [Validation(Required=false)]
                                            public string Step { get; set; }
                                        };

                                        [NameInMap("StorageSize")]
                                        [Validation(Required=false)]
                                        public DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClassSupportedNodeCountListSupportedNodeCountStorageSize StorageSize { get; set; }
                                        public class DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClassSupportedNodeCountListSupportedNodeCountStorageSize : TeaModel {
                                            [NameInMap("StorageSize")]
                                            [Validation(Required=false)]
                                            public List<string> StorageSize { get; set; }
                                        };

                                    }

                                }
                                public string Tips { get; set; }
                            }
                        };

                    }

                }
                public string ZoneId { get; set; }
            }
        };

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
