// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListMultiChannelRecordingsResponseBody : TeaModel {
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
        /// <para>Recording list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListMultiChannelRecordingsResponseBodyData> Data { get; set; }
        public class ListMultiChannelRecordingsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Agent call channel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ch-user-8526899****-8602****-1656926504363-job-25920271311543****</para>
            /// </summary>
            [NameInMap("AgentChannelId")]
            [Validation(Required=false)]
            public string AgentChannelId { get; set; }

            /// <summary>
            /// <para>Agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent@ccc-test</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>Agent name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>坐席小王</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <para>Call ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-25920271311543****</para>
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            /// <summary>
            /// <para>Recording duration, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>56321</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <para>Recording file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-25920271311543****-798f1e90-1f82-42da-914c-46580c8f4c85-1656926518491.mkv</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>OSS download URL for the recording file. Note the time-to-live (TTL) of the download URL. The download URL is valid for 1 day.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://ccc-v2-shanghai.oss-cn-shanghai.aliyuncs.com/ccc-test/job-25920271311543****-798f1e90-1f82-42da-914c-46580c8f4c85-1656926518491.mkv?Expires=1657014031&OSSAccessKeyId=****&Signature=">https://ccc-v2-shanghai.oss-cn-shanghai.aliyuncs.com/ccc-test/job-25920271311543****-798f1e90-1f82-42da-914c-46580c8f4c85-1656926518491.mkv?Expires=1657014031&amp;OSSAccessKeyId=****&amp;Signature=</a>****</para>
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            /// <summary>
            /// <para>List of call hold time segments.</para>
            /// </summary>
            [NameInMap("HoldTimeSegments")]
            [Validation(Required=false)]
            public List<ListMultiChannelRecordingsResponseBodyDataHoldTimeSegments> HoldTimeSegments { get; set; }
            public class ListMultiChannelRecordingsResponseBodyDataHoldTimeSegments : TeaModel {
                /// <summary>
                /// <para>The end time of the call hold, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1687860143925</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>Call hold start time, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1673255098049</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            /// <summary>
            /// <para>RAM account ID for the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22807673106369****</para>
            /// </summary>
            [NameInMap("RamId")]
            [Validation(Required=false)]
            public string RamId { get; set; }

            /// <summary>
            /// <para>Skill group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skillgroup@ccc-test</para>
            /// </summary>
            [NameInMap("SkillGroupId")]
            [Validation(Required=false)]
            public string SkillGroupId { get; set; }

            /// <summary>
            /// <para>Recording start time, in UNIX timestamp format, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1656926518491</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B19CD719-9F65-56A6-8B79-DA4282EA4797</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
