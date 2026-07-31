// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class RunSemanticJobRequest : TeaModel {
        /// <summary>
        /// <para>The name of the job to run. Use the Data.Name value returned by CreateSemanticJob or the Name field from the ListSemanticJobs response. The Source, ResourceGroupId, and reference files of the job are determined by the definition saved at creation time.</para>
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
