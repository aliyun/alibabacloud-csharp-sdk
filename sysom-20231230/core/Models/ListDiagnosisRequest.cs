// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListDiagnosisRequest : TeaModel {
        /// <summary>
        /// <para>Current page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("current")]
        [Validation(Required=false)]
        public long? Current { get; set; }

        /// <summary>
        /// <para>Page size</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Diagnostic parameters. Different types of diagnostics require different diagnostic parameters. You can use this field to filter records whose parameters match the specified values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;key\&quot;:\&quot;region\&quot;,\&quot;value\&quot;:\&quot;cn-beijing\&quot;}]</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>Diagnostic type</para>
        /// 
        /// <b>Example:</b>
        /// <para>memgraph</para>
        /// </summary>
        [NameInMap("service_name")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>Execution status of the diagnostic task.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Ready</b>: Ready</description></item>
        /// <item><description><b>Running</b>: Running</description></item>
        /// <item><description><b>Success</b>: Execution succeeded</description></item>
        /// <item><description><b>Fail</b>: Execution failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
