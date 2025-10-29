// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CodeConfiguration : TeaModel {
        /// <summary>
        /// <para>代码包的CRC-64校验值。如果提供了checksum，则函数计算会校验代码包的checksum是否和提供的一致</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456789</para>
        /// </summary>
        [NameInMap("checksum")]
        [Validation(Required=false)]
        public string Checksum { get; set; }

        /// <summary>
        /// <para>在运行时中运行的命令（例如：[&quot;python&quot;]）</para>
        /// 
        /// <b>Example:</b>
        /// <para>python,main.py</para>
        /// </summary>
        [NameInMap("command")]
        [Validation(Required=false)]
        public List<string> Command { get; set; }

        /// <summary>
        /// <para>代码运行时的编程语言，如 python3、nodejs 等</para>
        /// 
        /// <b>Example:</b>
        /// <para>python3.12</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-agent-code-bucket</para>
        /// </summary>
        [NameInMap("ossBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>agent-code-v1.0.zip</para>
        /// </summary>
        [NameInMap("ossObjectName")]
        [Validation(Required=false)]
        public string OssObjectName { get; set; }

        /// <summary>
        /// <para>智能体代码ZIP包的Base64编码</para>
        /// 
        /// <b>Example:</b>
        /// <para>UEsDBAoAAAAAANF</para>
        /// </summary>
        [NameInMap("zipFile")]
        [Validation(Required=false)]
        public string ZipFile { get; set; }

    }

}
