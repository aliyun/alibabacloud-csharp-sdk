// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class GetAvailabilityMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The following limits are imposed on the ID:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The call was successful.</description></item>
        /// <item><description><b>3xx</b>: The call was redirected.</description></item>
        /// <item><description><b>4xx</b>: The call failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data entries returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetAvailabilityMetricResponseBodyData> Data { get; set; }
        public class GetAvailabilityMetricResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>017f39b8-dfa4-4e16-a84b-1dcee4b1****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>Indicates whether an auto scaling policy is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: An auto scaling policy is enabled.</description></item>
            /// <item><description><b>0</b>: No auto scaling policy is enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("EnableAutoscale")]
            [Validation(Required=false)]
            public long? EnableAutoscale { get; set; }

            /// <summary>
            /// <para>The number of abnormal instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ErrorInstances")]
            [Validation(Required=false)]
            public long? ErrorInstances { get; set; }

            /// <summary>
            /// <para>The expected number of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public long? Instances { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The current number of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Runnings")]
            [Validation(Required=false)]
            public long? Runnings { get; set; }

        }

        /// <summary>
        /// <para>The additional information that is returned. The following limits are imposed on the ID:</para>
        /// <list type="bullet">
        /// <item><description>success: If the call is successful, <b>success</b> is returned.</description></item>
        /// <item><description>An error code: If the call fails, an error code is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3A92C4EA-4C53-5A1C-8AEB-F2DB11982D5F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the list of applications was obtained. The following limits are imposed on the ID:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The namespaces were obtained.</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
