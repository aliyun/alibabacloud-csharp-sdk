// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListZkTrackResponseBody : TeaModel {
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
        /// <para>The HTTP status code.</para>
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
        /// <para>ok</para>
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
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC34E4A3-5F1C-4E40-86EA-02EDF967****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
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
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The track data.</para>
        /// </summary>
        [NameInMap("Traces")]
        [Validation(Required=false)]
        public List<ListZkTrackResponseBodyTraces> Traces { get; set; }
        public class ListZkTrackResponseBodyTraces : TeaModel {
            /// <summary>
            /// <para>The access control list (ACL).</para>
            /// 
            /// <b>Example:</b>
            /// <para>world:anyone:cdrwa</para>
            /// </summary>
            [NameInMap("Acl")]
            [Validation(Required=false)]
            public string Acl { get; set; }

            /// <summary>
            /// <para>The data type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>persist</description></item>
            /// <item><description>ephemeral</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>persist</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <para>The type of the event. For trajectory of the Notify type:</para>
            /// <list type="bullet">
            /// <item><description>NodeCreated</description></item>
            /// <item><description>NodeDeleted</description></item>
            /// <item><description>NodeDataChanged</description></item>
            /// <item><description>NodeChildrenChanged</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NodeCreated</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>Indicates whether the transaction ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }

            /// <summary>
            /// <para>The logging time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-28 15:09:15,606</para>
            /// </summary>
            [NameInMap("LogDate")]
            [Validation(Required=false)]
            public string LogDate { get; set; }

            /// <summary>
            /// <para>The transaction size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MultiSize")]
            [Validation(Required=false)]
            public long? MultiSize { get; set; }

            /// <summary>
            /// <para>The type of the operation. For trajectory of the Push type:</para>
            /// <list type="bullet">
            /// <item><description>Create</description></item>
            /// <item><description>Update</description></item>
            /// <item><description>Delete</description></item>
            /// <item><description>SetAcl</description></item>
            /// <item><description>Multi</description></item>
            /// </list>
            /// <para>For trajectory of the Pull type:</para>
            /// <list type="bullet">
            /// <item><description>GetData</description></item>
            /// <item><description>GetChild</description></item>
            /// <item><description>GetStat</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Create</para>
            /// </summary>
            [NameInMap("OpType")]
            [Validation(Required=false)]
            public string OpType { get; set; }

            /// <summary>
            /// <para>The path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/path</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The returned result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0x301fdfbdbf00***</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The timestamp. It is not available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1669619383000</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// <para>The type of the trajectory. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Push</description></item>
            /// <item><description>Pull</description></item>
            /// <item><description>Notify</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Push</para>
            /// </summary>
            [NameInMap("TraceType")]
            [Validation(Required=false)]
            public string TraceType { get; set; }

            /// <summary>
            /// <para>The time to live (TTL).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public long? Ttl { get; set; }

            /// <summary>
            /// <para>Indicates whether the monitoring feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Watch")]
            [Validation(Required=false)]
            public bool? Watch { get; set; }

        }

    }

}
