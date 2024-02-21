// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListResourcePoolResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PoolInfoList")]
        [Validation(Required=false)]
        public ListResourcePoolResponseBodyPoolInfoList PoolInfoList { get; set; }
        public class ListResourcePoolResponseBodyPoolInfoList : TeaModel {
            [NameInMap("PoolInfo")]
            [Validation(Required=false)]
            public List<ListResourcePoolResponseBodyPoolInfoListPoolInfo> PoolInfo { get; set; }
            public class ListResourcePoolResponseBodyPoolInfoListPoolInfo : TeaModel {
                [NameInMap("EcmResourcePool")]
                [Validation(Required=false)]
                public ListResourcePoolResponseBodyPoolInfoListPoolInfoEcmResourcePool EcmResourcePool { get; set; }
                public class ListResourcePoolResponseBodyPoolInfoListPoolInfoEcmResourcePool : TeaModel {
                    [NameInMap("Active")]
                    [Validation(Required=false)]
                    public bool? Active { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Note")]
                    [Validation(Required=false)]
                    public string Note { get; set; }

                    [NameInMap("PoolType")]
                    [Validation(Required=false)]
                    public string PoolType { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    [NameInMap("YarnSiteConfig")]
                    [Validation(Required=false)]
                    public string YarnSiteConfig { get; set; }

                }

                [NameInMap("EcmResourcePoolConfigList")]
                [Validation(Required=false)]
                public ListResourcePoolResponseBodyPoolInfoListPoolInfoEcmResourcePoolConfigList EcmResourcePoolConfigList { get; set; }
                public class ListResourcePoolResponseBodyPoolInfoListPoolInfoEcmResourcePoolConfigList : TeaModel {
                    [NameInMap("EcmResourcePoolConfig")]
                    [Validation(Required=false)]
                    public List<ListResourcePoolResponseBodyPoolInfoListPoolInfoEcmResourcePoolConfigListEcmResourcePoolConfig> EcmResourcePoolConfig { get; set; }
                    public class ListResourcePoolResponseBodyPoolInfoListPoolInfoEcmResourcePoolConfigListEcmResourcePoolConfig : TeaModel {
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        [NameInMap("ConfigKey")]
                        [Validation(Required=false)]
                        public string ConfigKey { get; set; }

                        [NameInMap("ConfigType")]
                        [Validation(Required=false)]
                        public string ConfigType { get; set; }

                        [NameInMap("ConfigValue")]
                        [Validation(Required=false)]
                        public string ConfigValue { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        [NameInMap("Note")]
                        [Validation(Required=false)]
                        public string Note { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                [NameInMap("QueueList")]
                [Validation(Required=false)]
                public ListResourcePoolResponseBodyPoolInfoListPoolInfoQueueList QueueList { get; set; }
                public class ListResourcePoolResponseBodyPoolInfoListPoolInfoQueueList : TeaModel {
                    [NameInMap("Queue")]
                    [Validation(Required=false)]
                    public List<ListResourcePoolResponseBodyPoolInfoListPoolInfoQueueListQueue> Queue { get; set; }
                    public class ListResourcePoolResponseBodyPoolInfoListPoolInfoQueueListQueue : TeaModel {
                        [NameInMap("EcmResourcePoolConfigList")]
                        [Validation(Required=false)]
                        public ListResourcePoolResponseBodyPoolInfoListPoolInfoQueueListQueueEcmResourcePoolConfigList EcmResourcePoolConfigList { get; set; }
                        public class ListResourcePoolResponseBodyPoolInfoListPoolInfoQueueListQueueEcmResourcePoolConfigList : TeaModel {
                            [NameInMap("EcmResourcePoolConfig")]
                            [Validation(Required=false)]
                            public List<ListResourcePoolResponseBodyPoolInfoListPoolInfoQueueListQueueEcmResourcePoolConfigListEcmResourcePoolConfig> EcmResourcePoolConfig { get; set; }
                            public class ListResourcePoolResponseBodyPoolInfoListPoolInfoQueueListQueueEcmResourcePoolConfigListEcmResourcePoolConfig : TeaModel {
                                [NameInMap("Category")]
                                [Validation(Required=false)]
                                public string Category { get; set; }

                                [NameInMap("ConfigKey")]
                                [Validation(Required=false)]
                                public string ConfigKey { get; set; }

                                [NameInMap("ConfigType")]
                                [Validation(Required=false)]
                                public string ConfigType { get; set; }

                                [NameInMap("ConfigValue")]
                                [Validation(Required=false)]
                                public string ConfigValue { get; set; }

                                [NameInMap("Id")]
                                [Validation(Required=false)]
                                public long? Id { get; set; }

                                [NameInMap("Note")]
                                [Validation(Required=false)]
                                public string Note { get; set; }

                                [NameInMap("Status")]
                                [Validation(Required=false)]
                                public string Status { get; set; }

                            }

                        }

                        [NameInMap("EcmResourceQueue")]
                        [Validation(Required=false)]
                        public ListResourcePoolResponseBodyPoolInfoListPoolInfoQueueListQueueEcmResourceQueue EcmResourceQueue { get; set; }
                        public class ListResourcePoolResponseBodyPoolInfoListPoolInfoQueueListQueueEcmResourceQueue : TeaModel {
                            [NameInMap("Id")]
                            [Validation(Required=false)]
                            public long? Id { get; set; }

                            [NameInMap("Leaf")]
                            [Validation(Required=false)]
                            public bool? Leaf { get; set; }

                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            [NameInMap("ParentQueueId")]
                            [Validation(Required=false)]
                            public long? ParentQueueId { get; set; }

                            /// <summary>
                            /// QualifiedName。
                            /// </summary>
                            [NameInMap("QualifiedName")]
                            [Validation(Required=false)]
                            public string QualifiedName { get; set; }

                            [NameInMap("QueueType")]
                            [Validation(Required=false)]
                            public string QueueType { get; set; }

                            [NameInMap("ResourcePoolId")]
                            [Validation(Required=false)]
                            public long? ResourcePoolId { get; set; }

                            [NameInMap("Status")]
                            [Validation(Required=false)]
                            public string Status { get; set; }

                            [NameInMap("UserId")]
                            [Validation(Required=false)]
                            public string UserId { get; set; }

                        }

                    }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
