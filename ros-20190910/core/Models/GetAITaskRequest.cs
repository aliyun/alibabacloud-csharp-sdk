// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetAITaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("OutputOption")]
        [Validation(Required=false)]
        public string OutputOption { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>t-asasas*****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
