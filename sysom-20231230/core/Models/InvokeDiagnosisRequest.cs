// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class InvokeDiagnosisRequest : TeaModel {
        /// <summary>
        /// <para>Diagnosis channel (currently fixed as the ECS channel).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>Diagnosis parameters. Different types of diagnoses require different diagnosis parameters. For the parameters required by each diagnosis type, refer to the supplementary request parameter description below.</para>
        /// <remarks>
        /// <para>Notice: Please pass a JSON-formatted string.</notice></para>
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
        /// <para>Diagnosis type, used to distinguish different types of diagnoses.</para>
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
