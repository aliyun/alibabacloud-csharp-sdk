// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QuerySmarttagJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the smart tagging job. You can obtain this ID from the response to the <a href="https://help.aliyun.com/document_detail/478786.html">SubmitSmarttagJob</a> call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88c6ca184c0e47098a5b665e2****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>Additional request parameters, formatted as a JSON string. For example: <c>{&quot;labelResultType&quot;:&quot;auto&quot;}</c>. The <c>labelResultType</c> parameter supports the following values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>auto</c>: machine-generated tagging results</para>
        /// </description></item>
        /// <item><description><para><c>hmi</c>: human-in-the-loop tagging results</para>
        /// </description></item>
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
