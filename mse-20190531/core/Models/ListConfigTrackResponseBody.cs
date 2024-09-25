// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListConfigTrackResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request was successfully processed.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CE3ABD2-1E04-561F-A9B4-0423D50****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request was successful.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The track data.</para>
        /// </summary>
        [NameInMap("Traces")]
        [Validation(Required=false)]
        public List<ListConfigTrackResponseBodyTraces> Traces { get; set; }
        public class ListConfigTrackResponseBodyTraces : TeaModel {
            /// <summary>
            /// <para>Indicates whether the request is sent from the client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Client")]
            [Validation(Required=false)]
            public bool? Client { get; set; }

            /// <summary>
            /// <para>The ID of the configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eir-server.properties</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>The response latency. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Delay")]
            [Validation(Required=false)]
            public string Delay { get; set; }

            /// <summary>
            /// <para>The event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>pull: configuration acquisition events</description></item>
            /// <item><description>persist: persistence events</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pull</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>The name of the configuration group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEFAULT_GROUP</para>
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <para>The logging time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-28 15:09:15</para>
            /// </summary>
            [NameInMap("LogDate")]
            [Validation(Required=false)]
            public string LogDate { get; set; }

            /// <summary>
            /// <para>The MD5 value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d21c9091c60daa0ff7ee2f420141e5a0</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>Indicates whether messages are pushed by a server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Push")]
            [Validation(Required=false)]
            public bool? Push { get; set; }

            /// <summary>
            /// <para>The source IP address of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.2</para>
            /// </summary>
            [NameInMap("RequestIp")]
            [Validation(Required=false)]
            public string RequestIp { get; set; }

            /// <summary>
            /// <para>The response node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-1973b9a0-1670834*****-reg-center-0-2</para>
            /// </summary>
            [NameInMap("ResponseIp")]
            [Validation(Required=false)]
            public string ResponseIp { get; set; }

            /// <summary>
            /// <para>The result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates the time when the metric value is collected.</para>
            /// <para>Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1659666529</para>
            /// </summary>
            [NameInMap("Ts")]
            [Validation(Required=false)]
            public string Ts { get; set; }

            /// <summary>
            /// <para>The release type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>beta: beta release</description></item>
            /// <item><description>tag: canary release</description></item>
            /// <item><description>batch: batch release</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>beta</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
