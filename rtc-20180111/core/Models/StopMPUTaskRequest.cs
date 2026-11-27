// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class StopMPUTaskRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Only a single ID can be passed.</para>
        /// <remarks>
        /// <para>You can create and query the application ID in the <a href="https://rtc.console.aliyun.com/manage/list#/manage/list">console</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAppId</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The task ID. Only a single ID can be passed. The value must be the same as the TaskId parameter of <a href="https://help.aliyun.com/document_detail/93183.html">StartMpuTask</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourTaskId</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
