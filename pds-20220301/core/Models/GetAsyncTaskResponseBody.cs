// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetAsyncTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the asynchronous task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>000e89fb-cf8f-11e9-8ab4-b6e980803a3b</para>
        /// </summary>
        [NameInMap("async_task_id")]
        [Validation(Required=false)]
        public string AsyncTaskId { get; set; }

        /// <summary>
        /// <para>The custom category of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>album</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The total amount of work that is done in the asynchronous task, such as the number of files that are packaged for package download on the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("consumed_process")]
        [Validation(Required=false)]
        public long? ConsumedProcess { get; set; }

        /// <summary>
        /// <para>The time when the task was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. Example: 2019-03-28T13:03:29.298Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-20T06:51:27.292Z</para>
        /// </summary>
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para><warning>This parameter is no longer used. We recommend that you use error_code instead.</warning></para>
        /// <para>The error code returned if the asynchronous task failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("err_code")]
        [Validation(Required=false)]
        public long? ErrCode { get; set; }

        /// <summary>
        /// <para>The error code returned if the asynchronous task failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the asynchronous task failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request has been failed due to some unknown error. Please try again later.</para>
        /// </summary>
        [NameInMap("error_message")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("failed_process")]
        [Validation(Required=false)]
        public long? FailedProcess { get; set; }

        /// <summary>
        /// <para>The time when the task was complete. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. Example: 2019-03-28T13:03:29.298Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-20T06:51:27.292Z</para>
        /// </summary>
        [NameInMap("finished_at")]
        [Validation(Required=false)]
        public string FinishedAt { get; set; }

        /// <summary>
        /// <para><warning>This parameter is no longer used. We recommend that you use error_message instead.</warning></para>
        /// <para>The error message returned if the asynchronous task failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request has been failed due to some unknown error. Please try again later.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("skipped_process")]
        [Validation(Required=false)]
        public long? SkippedProcess { get; set; }

        /// <summary>
        /// <para>The time when the task was started. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. Example: 2019-03-28T13:03:29.298Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-20T06:51:27.292Z</para>
        /// </summary>
        [NameInMap("started_at")]
        [Validation(Required=false)]
        public string StartedAt { get; set; }

        /// <summary>
        /// <para>The state of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Failed</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>PartialSucceed</description></item>
        /// <item><description>Succeed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Succeed</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para><warning>This parameter is no longer used. We recommend that you use state instead.</warning></para>
        /// <para>The state of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Failed</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>PartialSucceed</description></item>
        /// <item><description>Succeed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Succeed</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total amount of work to be done in the asynchronous task, such as the number of files to be packaged for package download on the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("total_process")]
        [Validation(Required=false)]
        public long? TotalProcess { get; set; }

        /// <summary>
        /// <para>The extracted files.</para>
        /// </summary>
        [NameInMap("uncompress_file_list")]
        [Validation(Required=false)]
        public List<UncompressedFileInfo> UncompressFileList { get; set; }

        /// <summary>
        /// <para>The download URL of the data generated by the asynchronous task, such as the download URL of the packaged files generated by the task of package download on the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx">https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&amp;OSSAccessKeyId=xxx&amp;Signature=xxx</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
