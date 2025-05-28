// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class DeleteUserFromWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC4E1E63-B337-44F8-8C22-6F00DF67E2C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returns the result of the API execution. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: Execution succeeded</description></item>
        /// <item><description>false: Execution failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Value range:</para>
        /// <list type="bullet">
        /// <item><description>true: The request succeeded - false: The request failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
