// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetDocumentAnalyzeResultRequest : TeaModel {
        /// <summary>
        /// <para>Job ID, specifying which document\&quot;s parsing result to query. This is a return parameter from the \&quot;Submit Document Parsing Job\&quot; interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bfce2248-1546-4298-8bcf-70ac26e69646</para>
        /// </summary>
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

    }

}
