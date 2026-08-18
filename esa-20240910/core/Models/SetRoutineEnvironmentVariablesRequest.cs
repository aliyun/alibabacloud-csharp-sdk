// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class SetRoutineEnvironmentVariablesRequest : TeaModel {
        /// <summary>
        /// <para>The environment name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>staging</c>: staging environment.</description></item>
        /// <item><description><c>production</c>: production environment.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>production</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>The dictionary of environment variables. The key is the environment variable name, and the value is the environment variable value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;EnvironmentVariables&quot;: {
        ///         &quot;Env_Key_1&quot;: {
        ///             &quot;Type&quot;: &quot;plain_text&quot;,
        ///             &quot;Value&quot;: &quot;value&quot;
        ///         },
        ///         &quot;PASSWORD&quot;: {
        ///             &quot;Type&quot;: &quot;secret_text&quot;,
        ///             &quot;Value&quot;: &quot;secret-password&quot;
        ///         }
        ///     }</para>
        /// </summary>
        [NameInMap("EnvironmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, EnvironmentVariablesValue> EnvironmentVariables { get; set; }

        /// <summary>
        /// <para>The function name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>er_test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
