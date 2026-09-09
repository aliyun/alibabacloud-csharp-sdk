// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class InvokeDiagnosisRequest : TeaModel {
        /// <summary>
        /// <para>The diagnostic channel. Currently fixed to the ECS channel.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>The diagnostic parameters. Different diagnostic types require different parameters. For the parameters required by each diagnostic type, see the supplementary description of request parameters below.</para>
        /// <remarks>
        /// <para>Notice: Pass a JSON-formatted string.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;instance&quot;: &quot;i-wz9gdv7qmdhusamc4dl01&quot;,
        ///     &quot;uid&quot;: &quot;xxxxxxxxxxxxxx&quot;,
        ///     &quot;region&quot;: &quot;cn-shenzhen&quot;
        /// }</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The diagnostic type. Specifies the type of diagnostic to perform.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>memgraph</para>
        /// </summary>
        [NameInMap("service_name")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
