// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CreateCallTaskRequest : TeaModel {
        /// <summary>
        /// <para>The type of the task template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VMS_VOICE_TTS</b>: the text-to-speech (TTS) notification template.</description></item>
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
        /// <para>The called numbers.</para>
        /// <list type="bullet">
        /// <item><description>If you set DataType to LIST, the value of Data is in the LIST format.</description></item>
        /// <item><description>If you set DataType to JSON, the value of Data is in the JSON format.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;paramNames&quot;:[&quot;name1&quot;,&quot;name2&quot;,&quot;key3&quot;], &quot;calleeList&quot;:[ { &quot;callee&quot;:&quot;131222222&quot;, &quot;params&quot;:[&quot;zangsan&quot;,&quot;zhangsan01&quot;,&quot;zhangsan02&quot;] }, { &quot;callee&quot;:&quot;131222222&quot;, &quot;params&quot;:[&quot;zangsan&quot;,&quot;zhangsan01&quot;,&quot;zhangsan02&quot;] }, ] }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The type of called numbers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>LIST</b>: the called numbers that are separated by commas (,).</description></item>
        /// <item><description><b>JSON</b>: a JSON-formatted list of called numbers with template parameters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>JSON</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>This parameter is unavailable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FireTime")]
        [Validation(Required=false)]
        public string FireTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The calling number. Only virtual numbers are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05516214****</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The type of the calling number. Set the value to <b>LIST</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIST</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>This parameter is unavailable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

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
        /// <para>The template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TTS_2122****</para>
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

    }

}
