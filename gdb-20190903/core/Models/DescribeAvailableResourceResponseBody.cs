// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gdb20190903.Models
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
                [NameInMap("SupportedSerialList")]
                [Validation(Required=false)]
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
                                [NameInMap("InstanceClass")]
                                [Validation(Required=false)]
                                public string InstanceClass { get; set; }

                                [NameInMap("SupportedStorageSizeList")]
                                [Validation(Required=false)]
                                public DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClassSupportedStorageSizeList SupportedStorageSizeList { get; set; }
                                public class DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClassSupportedStorageSizeList : TeaModel {
                                    [NameInMap("SupportedStorageSize")]
                                    [Validation(Required=false)]
                                    public List<DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClassSupportedStorageSizeListSupportedStorageSize> SupportedStorageSize { get; set; }
                                    public class DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClassSupportedStorageSizeListSupportedStorageSize : TeaModel {
                                        [NameInMap("StorageSize")]
                                        [Validation(Required=false)]
                                        public DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClassSupportedStorageSizeListSupportedStorageSizeStorageSize StorageSize { get; set; }
                                        public class DescribeAvailableResourceResponseBodyAvailableZoneListAvailableZoneSupportedSerialListSupportedSerialSupportedInstanceClassListSupportedInstanceClassSupportedStorageSizeListSupportedStorageSizeStorageSize : TeaModel {
                                            [NameInMap("Max")]
                                            [Validation(Required=false)]
                                            public int? Max { get; set; }

                                            [NameInMap("Min")]
                                            [Validation(Required=false)]
                                            public int? Min { get; set; }

                                            [NameInMap("Step")]
                                            [Validation(Required=false)]
                                            public int? Step { get; set; }

                                        }

                                        [NameInMap("StorageType")]
                                        [Validation(Required=false)]
                                        public string StorageType { get; set; }

                                    }

                                }

                                [NameInMap("Tips")]
                                [Validation(Required=false)]
                                public string Tips { get; set; }

                            }

                        }

                    }

                }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
