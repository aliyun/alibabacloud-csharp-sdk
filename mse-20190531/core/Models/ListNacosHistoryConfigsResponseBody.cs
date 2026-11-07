// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListNacosHistoryConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The configuration items.</para>
        /// </summary>
        [NameInMap("HistoryItems")]
        [Validation(Required=false)]
        public List<ListNacosHistoryConfigsResponseBodyHistoryItems> HistoryItems { get; set; }
        public class ListNacosHistoryConfigsResponseBodyHistoryItems : TeaModel {
            /// <summary>
            /// <para>The tags of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gateway</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The ID of the data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.yaml</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>The name of the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <para>The configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23fdsf</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The timestamp when the configuration was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1643440066000</para>
            /// </summary>
            [NameInMap("LastModifiedTime")]
            [Validation(Required=false)]
            public long? LastModifiedTime { get; set; }

            /// <summary>
            /// <para>The format of the configuration file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yaml</para>
            /// </summary>
            [NameInMap("OpType")]
            [Validation(Required=false)]
            public string OpType { get; set; }

            /// <summary>
            /// <para>The user who modified this version</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("SrcUser")]
            [Validation(Required=false)]
            public string SrcUser { get; set; }

        }

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
        /// <para>The message that is returned for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request is processed successfully.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53338ECA-F880-54D8-A9B3-5606355A1B89</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
        /// </description></item>
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
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
