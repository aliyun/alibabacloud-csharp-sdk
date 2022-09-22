// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeLocalDiskRepairActivitiesResponseBody : TeaModel {
        [NameInMap("LocalDiskRepairActivities")]
        [Validation(Required=false)]
        public DescribeLocalDiskRepairActivitiesResponseBodyLocalDiskRepairActivities LocalDiskRepairActivities { get; set; }
        public class DescribeLocalDiskRepairActivitiesResponseBodyLocalDiskRepairActivities : TeaModel {
            [NameInMap("LocalDiskRepairActivity")]
            [Validation(Required=false)]
            public List<DescribeLocalDiskRepairActivitiesResponseBodyLocalDiskRepairActivitiesLocalDiskRepairActivity> LocalDiskRepairActivity { get; set; }
            public class DescribeLocalDiskRepairActivitiesResponseBodyLocalDiskRepairActivitiesLocalDiskRepairActivity : TeaModel {
                [NameInMap("DiskEvent")]
                [Validation(Required=false)]
                public DescribeLocalDiskRepairActivitiesResponseBodyLocalDiskRepairActivitiesLocalDiskRepairActivityDiskEvent DiskEvent { get; set; }
                public class DescribeLocalDiskRepairActivitiesResponseBodyLocalDiskRepairActivitiesLocalDiskRepairActivityDiskEvent : TeaModel {
                    [NameInMap("EventEndTime")]
                    [Validation(Required=false)]
                    public string EventEndTime { get; set; }

                    [NameInMap("EventId")]
                    [Validation(Required=false)]
                    public string EventId { get; set; }

                    [NameInMap("EventTime")]
                    [Validation(Required=false)]
                    public string EventTime { get; set; }

                    [NameInMap("EventType")]
                    [Validation(Required=false)]
                    public DescribeLocalDiskRepairActivitiesResponseBodyLocalDiskRepairActivitiesLocalDiskRepairActivityDiskEventEventType EventType { get; set; }
                    public class DescribeLocalDiskRepairActivitiesResponseBodyLocalDiskRepairActivitiesLocalDiskRepairActivityDiskEventEventType : TeaModel {
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public int? Code { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                [NameInMap("InstanceEvents")]
                [Validation(Required=false)]
                public DescribeLocalDiskRepairActivitiesResponseBodyLocalDiskRepairActivitiesLocalDiskRepairActivityInstanceEvents InstanceEvents { get; set; }
                public class DescribeLocalDiskRepairActivitiesResponseBodyLocalDiskRepairActivitiesLocalDiskRepairActivityInstanceEvents : TeaModel {
                    [NameInMap("InstanceEvent")]
                    [Validation(Required=false)]
                    public List<DescribeLocalDiskRepairActivitiesResponseBodyLocalDiskRepairActivitiesLocalDiskRepairActivityInstanceEventsInstanceEvent> InstanceEvent { get; set; }
                    public class DescribeLocalDiskRepairActivitiesResponseBodyLocalDiskRepairActivitiesLocalDiskRepairActivityInstanceEventsInstanceEvent : TeaModel {
                        [NameInMap("EventCycleStatus")]
                        [Validation(Required=false)]
                        public DescribeLocalDiskRepairActivitiesResponseBodyLocalDiskRepairActivitiesLocalDiskRepairActivityInstanceEventsInstanceEventEventCycleStatus EventCycleStatus { get; set; }
                        public class DescribeLocalDiskRepairActivitiesResponseBodyLocalDiskRepairActivitiesLocalDiskRepairActivityInstanceEventsInstanceEventEventCycleStatus : TeaModel {
                            [NameInMap("Code")]
                            [Validation(Required=false)]
                            public int? Code { get; set; }

                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        [NameInMap("EventFinishTime")]
                        [Validation(Required=false)]
                        public string EventFinishTime { get; set; }

                        [NameInMap("EventId")]
                        [Validation(Required=false)]
                        public string EventId { get; set; }

                        [NameInMap("EventPublishTime")]
                        [Validation(Required=false)]
                        public string EventPublishTime { get; set; }

                        [NameInMap("EventType")]
                        [Validation(Required=false)]
                        public DescribeLocalDiskRepairActivitiesResponseBodyLocalDiskRepairActivitiesLocalDiskRepairActivityInstanceEventsInstanceEventEventType EventType { get; set; }
                        public class DescribeLocalDiskRepairActivitiesResponseBodyLocalDiskRepairActivitiesLocalDiskRepairActivityInstanceEventsInstanceEventEventType : TeaModel {
                            [NameInMap("Code")]
                            [Validation(Required=false)]
                            public int? Code { get; set; }

                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        [NameInMap("ExtendedAttribute")]
                        [Validation(Required=false)]
                        public DescribeLocalDiskRepairActivitiesResponseBodyLocalDiskRepairActivitiesLocalDiskRepairActivityInstanceEventsInstanceEventExtendedAttribute ExtendedAttribute { get; set; }
                        public class DescribeLocalDiskRepairActivitiesResponseBodyLocalDiskRepairActivitiesLocalDiskRepairActivityInstanceEventsInstanceEventExtendedAttribute : TeaModel {
                            [NameInMap("Device")]
                            [Validation(Required=false)]
                            public string Device { get; set; }

                            [NameInMap("DiskId")]
                            [Validation(Required=false)]
                            public string DiskId { get; set; }

                            [NameInMap("OnlineRepairPolicy")]
                            [Validation(Required=false)]
                            public string OnlineRepairPolicy { get; set; }

                        }

                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        [NameInMap("Reason")]
                        [Validation(Required=false)]
                        public string Reason { get; set; }

                    }

                }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
