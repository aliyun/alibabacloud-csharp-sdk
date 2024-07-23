// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ListPluginStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The states of Cloud Assistant plug-ins on the instances.</para>
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
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-xxxxx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The queried Cloud Assistant plug-ins.</para>
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
                        /// <para>The first time when Cloud Assistant reported the state of the plug-in.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2020-01-19T09:15:46Z</para>
                        /// </summary>
                        [NameInMap("FirstHeartbeatTime")]
                        [Validation(Required=false)]
                        public string FirstHeartbeatTime { get; set; }

                        /// <summary>
                        /// <para>The last time when Cloud Assistant reported the state of the plug-in.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2020-01-19T09:15:46Z</para>
                        /// </summary>
                        [NameInMap("LastHeartbeatTime")]
                        [Validation(Required=false)]
                        public string LastHeartbeatTime { get; set; }

                        /// <summary>
                        /// <para>The name of the plug-in.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testName</para>
                        /// </summary>
                        [NameInMap("PluginName")]
                        [Validation(Required=false)]
                        public string PluginName { get; set; }

                        /// <summary>
                        /// <para>The state of the Cloud Assistant plug-in. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>NotInstalled: The plug-in is not installed.</description></item>
                        /// <item><description>Installed: The one-time plug-in is installed.</description></item>
                        /// <item><description>Running: The long-running plug-in is running.</description></item>
                        /// <item><description>Stopped: The long-running plug-in is not running.</description></item>
                        /// <item><description>Crashed: The plug-in is abnormal.</description></item>
                        /// <item><description>Removed: The plug-in is uninstalled.</description></item>
                        /// <item><description>Unknown: The state of the plug-in is unknown.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Running</para>
                        /// </summary>
                        [NameInMap("PluginStatus")]
                        [Validation(Required=false)]
                        public string PluginStatus { get; set; }

                        /// <summary>
                        /// <para>The version of the plug-in.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1.1</para>
                        /// </summary>
                        [NameInMap("PluginVersion")]
                        [Validation(Required=false)]
                        public string PluginVersion { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
