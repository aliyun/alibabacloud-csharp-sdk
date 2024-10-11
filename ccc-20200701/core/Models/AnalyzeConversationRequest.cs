// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class AnalyzeConversationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>job-10963442671187****</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        [NameInMap("FieldListJson")]
        [Validation(Required=false)]
        public string FieldListJson { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9cfad875-6260-4a53-ab6e-b13e3fb31f7d</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;keywords&quot;]</para>
        /// </summary>
        [NameInMap("TaskListJson")]
        [Validation(Required=false)]
        public string TaskListJson { get; set; }

    }

}
