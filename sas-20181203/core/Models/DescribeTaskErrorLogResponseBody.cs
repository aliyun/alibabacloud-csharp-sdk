// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTaskErrorLogResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the error logs.</para>
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<DescribeTaskErrorLogResponseBodyLogs> Logs { get; set; }
        public class DescribeTaskErrorLogResponseBodyLogs : TeaModel {
            /// <summary>
            /// <para>The text content of the log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mv: cannot move \&quot;CentOS-Base.repo\&quot; to \&quot;CentOS-Base.repo.backup\&quot;: Permission denied</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F929E952-EBFC-56C3-BD35-BF8B59024C69</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
