// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ListPluginStatusResponseBody : TeaModel {
        /// <summary>
        /// The states of the Cloud Assistant plug-ins on the ECS instances.
        /// </summary>
        [NameInMap("InstancePluginStatusSet")]
        [Validation(Required=false)]
        public ListPluginStatusResponseBodyInstancePluginStatusSet InstancePluginStatusSet { get; set; }
        public class ListPluginStatusResponseBodyInstancePluginStatusSet : TeaModel {
            [NameInMap("InstancePluginStatus")]
            [Validation(Required=false)]
            public List<ListPluginStatusResponseBodyInstancePluginStatusSetInstancePluginStatus> InstancePluginStatus { get; set; }
            public class ListPluginStatusResponseBodyInstancePluginStatusSetInstancePluginStatus : TeaModel {
                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The states of the Cloud Assistant plug-ins.
                /// </summary>
                [NameInMap("PluginStatusSet")]
                [Validation(Required=false)]
                public ListPluginStatusResponseBodyInstancePluginStatusSetInstancePluginStatusPluginStatusSet PluginStatusSet { get; set; }
                public class ListPluginStatusResponseBodyInstancePluginStatusSetInstancePluginStatusPluginStatusSet : TeaModel {
                    [NameInMap("PluginStatus")]
                    [Validation(Required=false)]
                    public List<ListPluginStatusResponseBodyInstancePluginStatusSetInstancePluginStatusPluginStatusSetPluginStatus> PluginStatus { get; set; }
                    public class ListPluginStatusResponseBodyInstancePluginStatusSetInstancePluginStatusPluginStatusSetPluginStatus : TeaModel {
                        /// <summary>
                        /// The first time when Cloud Assistant reported the state of the plug-in.
                        /// </summary>
                        [NameInMap("FirstHeartbeatTime")]
                        [Validation(Required=false)]
                        public string FirstHeartbeatTime { get; set; }

                        /// <summary>
                        /// The last time when Cloud Assistant reported the state of the plug-in.
                        /// </summary>
                        [NameInMap("LastHeartbeatTime")]
                        [Validation(Required=false)]
                        public string LastHeartbeatTime { get; set; }

                        /// <summary>
                        /// The name of the plug-in.
                        /// </summary>
                        [NameInMap("PluginName")]
                        [Validation(Required=false)]
                        public string PluginName { get; set; }

                        /// <summary>
                        /// The state of the Cloud Assistant plug-in. Valid values:
                        /// 
                        /// *   NotInstalled
                        /// *   Installed
                        /// *   Running
                        /// *   Stopped
                        /// *   Crashed
                        /// *   Removed
                        /// *   Unknown
                        /// </summary>
                        [NameInMap("PluginStatus")]
                        [Validation(Required=false)]
                        public string PluginStatus { get; set; }

                        /// <summary>
                        /// The version of the plug-in.
                        /// </summary>
                        [NameInMap("PluginVersion")]
                        [Validation(Required=false)]
                        public string PluginVersion { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
