// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class TaskSpec : TeaModel {
        [NameInMap("context")]
        [Validation(Required=false)]
        public Context Context { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-task-template</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
