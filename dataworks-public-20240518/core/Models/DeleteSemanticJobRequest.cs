// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DeleteSemanticJobRequest : TeaModel {
        /// <summary>
        /// <para>The name of the task to delete. Use the Data.Name value from the CreateSemanticJob response or the Name value from a ListSemanticJobs list item.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>semantic-job-demo</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
