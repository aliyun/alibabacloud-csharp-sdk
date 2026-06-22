// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class Script : TeaModel {
        /// <summary>
        /// <para>The execution failure strategy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>FAILED_CONTINUE</c>: If the script fails, cluster creation or scaling continues.</para>
        /// </description></item>
        /// <item><description><para><c>FAILED_BLOCK</c>: If the script fails, cluster creation or scaling is blocked.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FAILED_CONTINUE</para>
        /// </summary>
        [NameInMap("ExecutionFailStrategy")]
        [Validation(Required=false)]
        public string ExecutionFailStrategy { get; set; }

        /// <summary>
        /// <para>The execution timing for the script. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>BEFORE_INSTALL</c>: The script runs before applications are installed.</para>
        /// </description></item>
        /// <item><description><para><c>AFTER_STARTED</c>: The script runs after applications start.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BEFORE_INSTALL</para>
        /// </summary>
        [NameInMap("ExecutionMoment")]
        [Validation(Required=false)]
        public string ExecutionMoment { get; set; }

        /// <summary>
        /// <para>Specifies the nodes on which the script runs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodeSelector")]
        [Validation(Required=false)]
        public NodeSelector NodeSelector { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <remarks>
        /// <para>This parameter is deprecated. Scripts run in the order they are defined.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        [Obsolete]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The optional script execution arguments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-host 10.0.10.5 -m 30</para>
        /// </summary>
        [NameInMap("ScriptArgs")]
        [Validation(Required=false)]
        public string ScriptArgs { get; set; }

        /// <summary>
        /// <para>The required script name. The name must be 1 to 64 characters long and start with a letter or a Chinese character. It cannot start with <c>http://</c> or <c>https://</c>. It can contain Chinese characters, letters, numbers, underscores (<c>_</c>), or hyphens (<c>-</c>).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>脚本名-1</para>
        /// </summary>
        [NameInMap("ScriptName")]
        [Validation(Required=false)]
        public string ScriptName { get; set; }

        /// <summary>
        /// <para>The required path to the script in Object Storage Service (OSS). The path must start with <c>oss://</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://bucket1/update_hosts.sh</para>
        /// </summary>
        [NameInMap("ScriptPath")]
        [Validation(Required=false)]
        public string ScriptPath { get; set; }

    }

}
