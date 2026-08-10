// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class ListOpenedAccessLogInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4DB64811-70A1-41C9-A0CE-CD8B260ED551</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The log analysis configurations of Anti-DDoS Origin instances.</para>
        /// </summary>
        [NameInMap("SlsConfigStatus")]
        [Validation(Required=false)]
        public List<ListOpenedAccessLogInstancesResponseBodySlsConfigStatus> SlsConfigStatus { get; set; }
        public class ListOpenedAccessLogInstancesResponseBodySlsConfigStatus : TeaModel {
            /// <summary>
            /// <para>Indicates whether log analysis is enabled for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The instance ID of Anti-DDoS Origin.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddosbgp-cn-m7r1zce2****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <para>The number of results returned, which is the number of Anti-DDoS Origin instances that have log analysis enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
