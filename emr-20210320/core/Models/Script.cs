// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class Script : TeaModel {
        /// <summary>
        /// <para>执行失败策略。</para>
        /// 
        /// <b>Example:</b>
        /// <para>FAILED_CONTINUE</para>
        /// </summary>
        [NameInMap("ExecutionFailStrategy")]
        [Validation(Required=false)]
        public string ExecutionFailStrategy { get; set; }

        /// <summary>
        /// <para>脚本的执行时机。</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEFORE_INSTALL</para>
        /// </summary>
        [NameInMap("ExecutionMoment")]
        [Validation(Required=false)]
        public string ExecutionMoment { get; set; }

        /// <summary>
        /// <para>节点选择器。</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodeSelector")]
        [Validation(Required=false)]
        public NodeSelector NodeSelector { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>脚本执行优先级。取值范围：1~100。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        [Obsolete]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>脚本执行参数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>-host 10.0.10.5 -m 30</para>
        /// </summary>
        [NameInMap("ScriptArgs")]
        [Validation(Required=false)]
        public string ScriptArgs { get; set; }

        /// <summary>
        /// <para>脚本名称。长度为1~64个字符，必须以大小字母或中文开头，不能以http://和https://开头。可以包含中文、英文、数字、下划线（_）、或者短划线（-）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>脚本名-1</para>
        /// </summary>
        [NameInMap("ScriptName")]
        [Validation(Required=false)]
        public string ScriptName { get; set; }

        /// <summary>
        /// <para>脚本所在OSS路径。</para>
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
