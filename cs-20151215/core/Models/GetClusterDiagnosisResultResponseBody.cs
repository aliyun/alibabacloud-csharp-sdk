// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetClusterDiagnosisResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The code that indicates the diagnostic result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: the diagnostic is completed.</description></item>
        /// <item><description>1: the diagnostic failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The time when the diagnostic is initiated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-05-28T11:29Z</para>
        /// </summary>
        [NameInMap("created")]
        [Validation(Required=false)]
        public string Created { get; set; }

        /// <summary>
        /// <para>The diagnostic ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6cf6b62e334e4583bdfd26707516****</para>
        /// </summary>
        [NameInMap("diagnosis_id")]
        [Validation(Required=false)]
        public string DiagnosisId { get; set; }

        /// <summary>
        /// <para>The time when the diagnostic is completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-05-28T11:29Z</para>
        /// </summary>
        [NameInMap("finished")]
        [Validation(Required=false)]
        public string Finished { get; set; }

        /// <summary>
        /// <para>The diagnostic status information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The diagnostic result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;phase&quot;:5,&quot;version&quot;:&quot;20240101&quot;}</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// <para>The status of the diagnostic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The diagnostic is created.</description></item>
        /// <item><description>1: The diagnostic is running.</description></item>
        /// <item><description>2: The diagnostic is completed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// <para>The diagnostic object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;cn-hongkong.10.0.0.246&quot;}</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>The type of the diagnostic.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>node</description></item>
        /// <item><description>ingress</description></item>
        /// <item><description>cluster</description></item>
        /// <item><description>memory</description></item>
        /// <item><description>pod</description></item>
        /// <item><description>service</description></item>
        /// <item><description>network</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Node</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
