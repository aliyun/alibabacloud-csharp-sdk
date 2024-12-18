// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class PutEvaluationsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the delete mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables the delete mode</description></item>
        /// <item><description>false (default): disables the delete mode</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only when you manually trigger or periodically trigger custom rules to evaluate resources. If you enable the delete mode, the evaluation results that are not updated during the current evaluation are automatically deleted.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteMode")]
        [Validation(Required=false)]
        public bool? DeleteMode { get; set; }

        /// <summary>
        /// <para>The evaluation results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;accountId&quot;:120886317861****,&quot;annotation&quot;:&quot;The flow log is not enabled.&quot;,&quot;complianceResourceId&quot;:&quot;flowlog-o6wdfo1yvgo4i8****&quot;,&quot;complianceResourceType&quot;:&quot;ACS::CEN::Flowlog&quot;,&quot;complianceRegionId&quot;:&quot;cn-shanghai&quot;,&quot;complianceType&quot;:&quot;NON_COMPLIANT&quot;,&quot;orderingTimestamp&quot;:1588907220408}]</para>
        /// </summary>
        [NameInMap("Evaluations")]
        [Validation(Required=false)]
        public string Evaluations { get; set; }

        /// <summary>
        /// <para>The callback token. When Cloud Config triggers a custom rule to evaluate resources, the token information is sent to Function Compute as an input parameter. The token must be specified when you submit the evaluation results.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>=lAUbfkWp7GL9AFoQEIStinqBMc4FC8sHvip/1F1npkWUDNS2GEm6xwL6Zl/fSr0bbkWY+aiCLjTJxnp4H/yp/8p/Q8VCAtqG5uhRii4sfnYRnTPnE****</para>
        /// </summary>
        [NameInMap("ResultToken")]
        [Validation(Required=false)]
        public string ResultToken { get; set; }

    }

}
