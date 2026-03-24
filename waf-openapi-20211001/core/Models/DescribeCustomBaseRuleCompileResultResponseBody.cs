// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeCustomBaseRuleCompileResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58FDF266-3D56-5DE8-91E0-96A26BAB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The compilation result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>success</b>: The rule is successfully compiled.</para>
        /// </description></item>
        /// <item><description><para><b>compiling</b>: The rule is being compiled.</para>
        /// </description></item>
        /// <item><description><para><b>failed</b>: The rule failed to be compiled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

    }

}
