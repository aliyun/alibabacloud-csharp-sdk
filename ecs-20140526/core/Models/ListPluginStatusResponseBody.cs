// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ListPluginStatusResponseBody : TeaModel {
        [NameInMap("InstancePluginStatusSet")]
        [Validation(Required=false)]
        public ListPluginStatusResponseBodyInstancePluginStatusSet InstancePluginStatusSet { get; set; }
        public class ListPluginStatusResponseBodyInstancePluginStatusSet : TeaModel {
            [NameInMap("InstancePluginStatus")]
            [Validation(Required=false)]
            public List<ListPluginStatusResponseBodyInstancePluginStatusSetInstancePluginStatus> InstancePluginStatus { get; set; }
            public class ListPluginStatusResponseBodyInstancePluginStatusSetInstancePluginStatus : TeaModel {
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("PluginStatusSet")]
                [Validation(Required=false)]
                public ListPluginStatusResponseBodyInstancePluginStatusSetInstancePluginStatusPluginStatusSet PluginStatusSet { get; set; }
                public class ListPluginStatusResponseBodyInstancePluginStatusSetInstancePluginStatusPluginStatusSet : TeaModel {
                    [NameInMap("PluginStatus")]
                    [Validation(Required=false)]
                    public List<ListPluginStatusResponseBodyInstancePluginStatusSetInstancePluginStatusPluginStatusSetPluginStatus> PluginStatus { get; set; }
                    public class ListPluginStatusResponseBodyInstancePluginStatusSetInstancePluginStatusPluginStatusSetPluginStatus : TeaModel {
                        [NameInMap("FirstHeartbeatTime")]
                        [Validation(Required=false)]
                        public string FirstHeartbeatTime { get; set; }

                        [NameInMap("LastHeartbeatTime")]
                        [Validation(Required=false)]
                        public string LastHeartbeatTime { get; set; }

                        [NameInMap("PluginName")]
                        [Validation(Required=false)]
                        public string PluginName { get; set; }

                        [NameInMap("PluginStatus")]
                        [Validation(Required=false)]
                        public string PluginStatus { get; set; }

                        [NameInMap("PluginVersion")]
                        [Validation(Required=false)]
                        public string PluginVersion { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results.</para>
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
