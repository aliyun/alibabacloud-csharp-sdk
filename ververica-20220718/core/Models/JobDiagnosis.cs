// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class JobDiagnosis : TeaModel {
        /// <summary>
        /// <para>The diagnostic task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ba30cd99-37a5-4a20-8cd9-ed4b*****</para>
        /// </summary>
        [NameInMap("diagnoseId")]
        [Validation(Required=false)]
        public string DiagnoseId { get; set; }

        /// <summary>
        /// <para>The time when the deployment is diagnosed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1740389560871</para>
        /// </summary>
        [NameInMap("diagnoseTime")]
        [Validation(Required=false)]
        public long? DiagnoseTime { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-namespace-*****</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The severity level of the risk.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RISK_LEVEL_HIGH</description></item>
        /// <item><description>RISK_LEVEL_MID</description></item>
        /// <item><description>RISK_LEVEL_LOW</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RISK_LEVEL_LOW</para>
        /// </summary>
        [NameInMap("riskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <para>The diagnostic details.</para>
        /// </summary>
        [NameInMap("symptoms")]
        [Validation(Required=false)]
        public JobDiagnosisSymptoms Symptoms { get; set; }

        /// <summary>
        /// <para>The workspace to which the deployment belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a14bd5d90a****</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
