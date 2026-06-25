// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class ListJobScriptHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of <c>200</c> indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The response data.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListJobScriptHistoryResponseBodyData Data { get; set; }
        public class ListJobScriptHistoryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The token to retrieve the next page of results. If this parameter is empty, no more data is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eCKqVlS5FKF5EWGGOo8EgQ==</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>A list of script history records.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListJobScriptHistoryResponseBodyDataRecords> Records { get; set; }
            public class ListJobScriptHistoryResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// <para>The timestamp when the script version was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-29 15:56:36</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The creator of the script version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1963096506470832</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The content of the script.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#!/bin/bash
                /// echo &quot;xxl-job: hello shell&quot;</para>
                /// <para>echo &quot;脚本位置: $0&quot;
                /// echo &quot;任务参数: $1&quot;
                /// echo &quot;分片序号 = $2&quot;
                /// echo &quot;分片总数 = $3&quot;</para>
                /// <para>echo &quot;Good bye!&quot;
                /// exit 0</para>
                /// </summary>
                [NameInMap("ScriptContent")]
                [Validation(Required=false)]
                public string ScriptContent { get; set; }

                /// <summary>
                /// <para>The script version description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>init version</para>
                /// </summary>
                [NameInMap("VersionDescription")]
                [Validation(Required=false)]
                public string VersionDescription { get; set; }

            }

            /// <summary>
            /// <para>The total count of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public string Total { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>not support query script history, please upgrade engine version to 2.2.2+</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>A unique ID for the request. Use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5EF879D0-3B43-5AD1-9BF7-52418F9C5E73</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
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
