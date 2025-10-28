// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class RetryChangeOrderTaskRequest : TeaModel {
        /// <summary>
        /// <para>The retry status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RetryStatus")]
        [Validation(Required=false)]
        public bool? RetryStatus { get; set; }

        /// <summary>
        /// <para>The ID of the process.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>823-bhjf-23u4-eiuf*</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
