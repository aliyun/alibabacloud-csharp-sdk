// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class DescribeJobResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The exit code of the command.</para>
        /// <list type="bullet">
        /// <item><description>For Linux instances, this is the exit code of the shell command.</description></item>
        /// <item><description>For Windows instances, this is the exit code of the Bat or PowerShell command.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ExitCode")]
        [Validation(Required=false)]
        public long? ExitCode { get; set; }

        /// <summary>
        /// <para>The output of the command execution. If ContentEncoding is set to PlainText, the original output is returned. If ContentEncoding is set to Base64, the Base64-encoded output is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTU6MzA6MDEK</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>BABC742E-04D7-5BA5-8A5F-7D9461D37B19</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
