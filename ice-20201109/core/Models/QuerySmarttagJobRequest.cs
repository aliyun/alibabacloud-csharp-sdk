// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QuerySmarttagJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the smart tagging job that you want to query. You can obtain the job ID from the response parameters of the SubmitSmarttagJob operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88c6ca184c0e47098a5b665e2****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The extra parameters that you want to query in the request. The value is a JSON string. Example: {&quot;labelResultType&quot;:&quot;auto&quot;}. The value of labelResultType is of the STRING type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>auto: machine tagging</description></item>
        /// <item><description>hmi: tagging by human and machine</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;labelResultType&quot;:&quot;auto&quot;}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

    }

}
