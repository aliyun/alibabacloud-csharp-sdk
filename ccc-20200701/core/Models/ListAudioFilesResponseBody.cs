// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListAudioFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAudioFilesResponseBodyData Data { get; set; }
        public class ListAudioFilesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of audio files.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListAudioFilesResponseBodyDataList> List { get; set; }
            public class ListAudioFilesResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Audio file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-file.wav</para>
                /// </summary>
                [NameInMap("AudioFileName")]
                [Validation(Required=false)]
                public string AudioFileName { get; set; }

                /// <summary>
                /// <para>Audio resource ID, which is the UUID of the audio file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d5cd7a94-3b6a-47d2-b7fd-0b1cd839bf77</para>
                /// </summary>
                [NameInMap("AudioResourceId")]
                [Validation(Required=false)]
                public string AudioResourceId { get; set; }

                /// <summary>
                /// <para>Audio content threat review result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("AuditResult")]
                [Validation(Required=false)]
                public string AuditResult { get; set; }

                /// <summary>
                /// <para>The creation time of the audio resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-05 17:35:45.0</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>Instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Display name of the audio resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>欢迎语</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The key of the audio resource file in OSS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccc-test/test-file.wav</para>
                /// </summary>
                [NameInMap("OssFileKey")]
                [Validation(Required=false)]
                public string OssFileKey { get; set; }

                /// <summary>
                /// <para>The status of the audio file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Completed</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Last modified time of the audio resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-08 15:34:49.0</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public string UpdatedTime { get; set; }

                /// <summary>
                /// <para>The usage of the audio file. The default value is General (used in scenarios such as IVR). Other optional values include HoldMusic (hold music during call waiting).</para>
                /// 
                /// <b>Example:</b>
                /// <para>General</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

            }

            /// <summary>
            /// <para>The page number, ranging from 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The paging size, ranging from 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53223330-EBF1-586B-A2CB-93C3B711FDA0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
