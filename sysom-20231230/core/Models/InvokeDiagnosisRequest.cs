// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class InvokeDiagnosisRequest : TeaModel {
        [NameInMap("X-Debug-Id")]
        [Validation(Required=false)]
        public string XDebugId { get; set; }

        /// <summary>
        /// <para>The diagnosis channel (currently fixed to the ECS channel).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>The diagnosis parameters. Different diagnosis types require different parameters. Refer to the supplementary request parameter descriptions below for the parameters required by each diagnosis type.</para>
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
        /// <para>The diagnosis type. This parameter distinguishes between different types of diagnostics.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>memgraph</para>
        /// </summary>
        [NameInMap("service_name")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("x-sysom-invoke-source")]
        [Validation(Required=false)]
        public string XSysomInvokeSource { get; set; }

    }

}
