// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreatePublishTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of business types.</para>
        /// </summary>
        [NameInMap("BizTypeList")]
        [Validation(Required=false)]
        public List<string> BizTypeList { get; set; }

        /// <summary>
        /// <para>The UTC time when the task was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-12T06:30:17Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The task failure information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>An error occurred while checking whether the module to be published is idle, faq</para>
        /// </summary>
        [NameInMap("Error")]
        [Validation(Required=false)]
        public string Error { get; set; }

        /// <summary>
        /// <para>The publish task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8522</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The UTC time when the task was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-12T06:30:33Z</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5CBF0581-EAE7-1DC4-95C6-A089656A1E2D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The publish task ID. This is a redundant field. Use the publish task ID from the Id field instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8522</para>
        /// </summary>
        [NameInMap("Response")]
        [Validation(Required=false)]
        public string Response { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FE_RUNNING: Publishing in progress.</description></item>
        /// <item><description>FE_SUCCESS: Published.</description></item>
        /// <item><description>FE_FAILED: Publish failed.</description></item>
        /// <item><description>FE_ABORTED: Publish canceled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FE_RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
