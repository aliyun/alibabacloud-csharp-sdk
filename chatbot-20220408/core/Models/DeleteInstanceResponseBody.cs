// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DeleteInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of business types.</para>
        /// </summary>
        [NameInMap("BizTypeList")]
        [Validation(Required=false)]
        public List<string> BizTypeList { get; set; }

        /// <summary>
        /// <para>The UTC time when the task was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-11T09:26:14Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The ID of the user who created the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9052</para>
        /// </summary>
        [NameInMap("CreateUserId")]
        [Validation(Required=false)]
        public long? CreateUserId { get; set; }

        /// <summary>
        /// <para>The username of the user who created the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xuqiang_test</para>
        /// </summary>
        [NameInMap("CreateUserName")]
        [Validation(Required=false)]
        public string CreateUserName { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>检查待发布模块是否空闲发生错误，faq</para>
        /// </summary>
        [NameInMap("Error")]
        [Validation(Required=false)]
        public string Error { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8521</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

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
        /// <para>The task ID. This parameter is an alias for <c>Id</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8521</para>
        /// </summary>
        [NameInMap("Response")]
        [Validation(Required=false)]
        public long? Response { get; set; }

        /// <summary>
        /// <para>The task status. For more information about possible states, see the GetInstancePublishTaskState API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE_RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
