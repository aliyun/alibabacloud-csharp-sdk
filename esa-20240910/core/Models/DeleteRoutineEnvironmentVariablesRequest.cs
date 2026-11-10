// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DeleteRoutineEnvironmentVariablesRequest : TeaModel {
        /// <summary>
        /// <para>The environment name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>staging</c>: the staging environment.</description></item>
        /// <item><description><c>production</c>: the production environment.</description></item>
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
        /// <para>The keys of the environment variables to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;LOG_LEVEL&quot;]</para>
        /// </summary>
        [NameInMap("EnvironmentVariableKeys")]
        [Validation(Required=false)]
        public List<string> EnvironmentVariableKeys { get; set; }

        /// <summary>
        /// <para>The name of the routine.</para>
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
