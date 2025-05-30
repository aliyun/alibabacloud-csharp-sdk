// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class FinishGuidTaskRequest : TeaModel {
        /// <summary>
        /// <para>The name of the task type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>guide_sub_task_config_add_collection</para>
        /// </summary>
        [NameInMap("TaskTypeName")]
        [Validation(Required=false)]
        public string TaskTypeName { get; set; }

    }

}
