// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetOtaTaskByTaskIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OtaTask.Running</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The task is running and cannot be sumitted.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The OTA version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.1-R-20220708.110604</para>
        /// </summary>
        [NameInMap("OtaVersion")]
        [Validation(Required=false)]
        public string OtaVersion { get; set; }

        /// <summary>
        /// <para>The version description that describes the content of the over-the-air update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试升级</para>
        /// </summary>
        [NameInMap("ReleaseNote")]
        [Validation(Required=false)]
        public string ReleaseNote { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task execution time in ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-04T14:36:00+08:00</para>
        /// </summary>
        [NameInMap("TaskStartTime")]
        [Validation(Required=false)]
        public string TaskStartTime { get; set; }

    }

}
