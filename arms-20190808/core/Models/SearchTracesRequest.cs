// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchTracesRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1595210400000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("ExclusionFilters")]
        [Validation(Required=false)]
        public List<SearchTracesRequestExclusionFilters> ExclusionFilters { get; set; }
        public class SearchTracesRequestExclusionFilters : TeaModel {
            /// <summary>
            /// <para>The key that is used to filter the query results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http.status_code</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the key that is used to filter the query results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>404</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The minimum amount of time consumed by traces. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinDuration")]
        [Validation(Required=false)]
        public long? MinDuration { get; set; }

        /// <summary>
        /// <para>The name of the traced span.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/demo/queryNotExistDB/11</para>
        /// </summary>
        [NameInMap("OperationName")]
        [Validation(Required=false)]
        public string OperationName { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b590lhguqs@9781be0f44dXXXX</para>
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to sort the query results in chronological order or reverse chronological order. Default value: <c>false</c>.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: sorts the query results in reverse chronological order.</description></item>
        /// <item><description><c>false</c>: sorts the query results in chronological order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// <para>The IP address of the host where the application resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.20.XX.XX</para>
        /// </summary>
        [NameInMap("ServiceIp")]
        [Validation(Required=false)]
        public string ServiceIp { get; set; }

        /// <summary>
        /// <para>The name of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arms-k8s-demo-subcomponent</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1595174400000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<SearchTracesRequestTag> Tag { get; set; }
        public class SearchTracesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The following system preset fields are provided:</para>
            /// <list type="bullet">
            /// <item><description>serverApp: the name of the server application.</description></item>
            /// <item><description>clientApp: the name of the client application.</description></item>
            /// <item><description>service: the name of the operation.</description></item>
            /// <item><description>rpc: the type of the call.</description></item>
            /// <item><description>msOfSpan: the duration exceeds a specific value.</description></item>
            /// <item><description>clientIp: the IP address of the client.</description></item>
            /// <item><description>serverIp: the IP address of the server.</description></item>
            /// <item><description>isError: specifies whether the call is abnormal.</description></item>
            /// <item><description>hasTprof: contains only thread profiling.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>http.status_code</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
