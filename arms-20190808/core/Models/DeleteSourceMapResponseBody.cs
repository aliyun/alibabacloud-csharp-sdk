// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteSourceMapResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the SourceMap files are deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>success: The SourceMap files are deleted.</description></item>
        /// <item><description>false: The SourceMap files fail to be deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A9C645C-C83F-4C9D-8CCB-29BEC9E1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
