// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ListCallTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The task information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCallTaskResponseBodyData> Data { get; set; }
        public class ListCallTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The type of the task template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VMS_VOICE_TTS</b>: the TTS notification template.</description></item>
            /// <item><description><b>VMS_VOICE_CODE</b>: the voice notification template.</description></item>
            /// <item><description><b>VMS_TTS</b>: the voice verification code template.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VMS_VOICE_TTS</para>
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <para>The time when the task was completed. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1614330986000</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The number of tasks that were complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CompletedCount")]
            [Validation(Required=false)]
            public long? CompletedCount { get; set; }

            /// <summary>
            /// <para>The task progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26%</para>
            /// </summary>
            [NameInMap("CompletedRate")]
            [Validation(Required=false)]
            public int? CompletedRate { get; set; }

            /// <summary>
            /// <para>This parameter is unavailable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            /// <summary>
            /// <para>The type of the called number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LIST</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <para>The time when the scheduled task was started. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1614330978000</para>
            /// </summary>
            [NameInMap("FireTime")]
            [Validation(Required=false)]
            public string FireTime { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123879546214</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The calling number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0571000****</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// <para>The task state. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: The task was in the initial state.</description></item>
            /// <item><description><b>RELEASE</b>: The task was being parsed.</description></item>
            /// <item><description><b>RUNNING</b>: The task was running.</description></item>
            /// <item><description><b>STOP</b>: The task was manually suspended.</description></item>
            /// <item><description><b>SYSTEM_STOP</b>: The task was suspended by the system.</description></item>
            /// <item><description><b>CANCEL</b>: The task was manually canceled.</description></item>
            /// <item><description><b>SYSTEM_CANCEL</b>: The task was canceled by the system.</description></item>
            /// <item><description><b>DONE</b>: The task was complete.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DONE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>This parameter is unavailable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StopTime")]
            [Validation(Required=false)]
            public string StopTime { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The ID of the voice template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TTS_2100****</para>
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test Template</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The total number of called numbers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

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
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5B0F201F-DCDA-45C2-AA92-1AE177F94991</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
