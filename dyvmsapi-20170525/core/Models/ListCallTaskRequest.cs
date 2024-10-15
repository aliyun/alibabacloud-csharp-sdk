// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ListCallTaskRequest : TeaModel {
        /// <summary>
        /// <para>The type of the task template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VMS_VOICE_TTS</b>: the text-to-speech (TTS) notification template.</description></item>
        /// <item><description><b>VMS_VOICE_CODE</b>: the voice notification template.</description></item>
        /// <item><description><b>VMS_TTS</b>: the voice verification code template.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VMS_VOICE_CODE</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The task state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>INIT</b>: The task is in the initial state.</description></item>
        /// <item><description><b>RELEASE</b>: The task is being parsed.</description></item>
        /// <item><description><b>RUNNING</b>: The task is running.</description></item>
        /// <item><description><b>STOP</b>: The task is suspended.</description></item>
        /// <item><description><b>SYSTEM_STOP</b>: The task is suspended by the system.</description></item>
        /// <item><description><b>CANCEL</b>: The task is canceled.</description></item>
        /// <item><description><b>SYSTEM_CANCEL</b>: The task is canceled by the system.</description></item>
        /// <item><description><b>DONE</b>: The task is complete.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DONE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>151001****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

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
        /// <para>The template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test Template</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
