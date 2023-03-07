// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DeleteJobTemplatesRequest : TeaModel {
        /// <summary>
        /// The list of job templates. A maximum of 20 job templates can be deleted.
        /// 
        /// Format: `[{"Id": "0.sched****"},{"Id": "1.sched****"}]`. Separate multiple job templates with commas (,).
        /// 
        /// You can call the [ListJobTemplates](~~87248~~) operation to obtain the job template ID.
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public string Templates { get; set; }

    }

}
