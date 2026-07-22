// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifySlsDispatchConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4CD646BA-490F-5584-9272-B6FFE3BB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task ID. Modifying log configurations is an asynchronous task. This field indicates the unique identifier of the task. You can use this ID to query the status of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d8c995ec-40a5-4382-a3f3-57713096****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
