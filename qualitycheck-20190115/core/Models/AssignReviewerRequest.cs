// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class AssignReviewerRequest : TeaModel {
        /// <summary>
        /// <para>baseMeAgentId</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;assignmentList&quot;:[{&quot;taskId&quot;:&quot;1C21CF1E-2917-4236-A046-20E37B293B69&quot;,&quot;fileId&quot;:&quot;7981b466fd6a4c70a7065da159739a5b&quot;},{&quot;taskId&quot;:&quot;0111DDBC-5F10-47E0-B7D4-7175F47D626F&quot;,&quot;fileId&quot;:&quot;1814eeae3cff41e989e31ab547f07561&quot;}],&quot;assignments&quot;:[{&quot;reviewer&quot;:&quot;255746168704895558&quot;},{&quot;reviewer&quot;:&quot;268370362815185444&quot;}]}</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
