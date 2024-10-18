// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class GetJobLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.manager</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B745C159-3155-4B94-95D0-4B73D4D2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The error output log that is encoded in Base64.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aG9zdG5hbWU=</para>
        /// </summary>
        [NameInMap("StderrLog")]
        [Validation(Required=false)]
        public string StderrLog { get; set; }

        /// <summary>
        /// <para>The size of the error output file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StderrLogSize")]
        [Validation(Required=false)]
        public string StderrLogSize { get; set; }

        /// <summary>
        /// <para>The standard output log that is encoded in Base64.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aG9zdG5hbWU=</para>
        /// </summary>
        [NameInMap("StdoutLog")]
        [Validation(Required=false)]
        public string StdoutLog { get; set; }

        /// <summary>
        /// <para>The size of the standard output file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4096</para>
        /// </summary>
        [NameInMap("StdoutLogSize")]
        [Validation(Required=false)]
        public string StdoutLogSize { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
