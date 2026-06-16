// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CodeConfiguration : TeaModel {
        /// <summary>
        /// <para>The CRC-64 checksum of the code package. If you provide <c>checksum</c>, Function Compute verifies that the code package\&quot;s computed checksum matches this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456789</para>
        /// </summary>
        [NameInMap("checksum")]
        [Validation(Required=false)]
        public string Checksum { get; set; }

        /// <summary>
        /// <para>The command and arguments to run in the runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python,main.py</para>
        /// </summary>
        [NameInMap("command")]
        [Validation(Required=false)]
        public List<string> Command { get; set; }

        /// <summary>
        /// <para>The programming language for the function\&quot;s runtime, such as python3 or nodejs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python3.12</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket that contains the function\&quot;s code package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent-code-bucket</para>
        /// </summary>
        [NameInMap("ossBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <para>The name of the OSS object for the function\&quot;s code package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-code-v1.0.zip</para>
        /// </summary>
        [NameInMap("ossObjectName")]
        [Validation(Required=false)]
        public string OssObjectName { get; set; }

        /// <summary>
        /// <para>The base64-encoded content of the agent\&quot;s code package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UEsDBAoAAAAAANF</para>
        /// </summary>
        [NameInMap("zipFile")]
        [Validation(Required=false)]
        public string ZipFile { get; set; }

    }

}
