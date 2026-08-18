// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DeleteRoutineEnvironmentVariablesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The environment name.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>staging</c>: staging environment</description></item>
        /// <item><description><c>production</c>: production environment</description></item>
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
        /// <para>The list of environment variable keys to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;LOG_LEVEL&quot;]</para>
        /// </summary>
        [NameInMap("EnvironmentVariableKeys")]
        [Validation(Required=false)]
        public string EnvironmentVariableKeysShrink { get; set; }

        /// <summary>
        /// <para>The name of the Routine function.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-routine</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
