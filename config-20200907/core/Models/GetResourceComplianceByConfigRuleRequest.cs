// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetResourceComplianceByConfigRuleRequest : TeaModel {
        /// <summary>
        /// <para>The compliance evaluation result of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>COMPLIANT: The resource is evaluated as compliant.</description></item>
        /// <item><description>NON_COMPLIANT: The resource is evaluated as non-compliant.</description></item>
        /// <item><description>NOT_APPLICABLE: The rule does not apply to the resources.</description></item>
        /// <item><description>INSUFFICIENT_DATA: No data is available.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLIANT</para>
        /// </summary>
        [NameInMap("ComplianceType")]
        [Validation(Required=false)]
        public string ComplianceType { get; set; }

        /// <summary>
        /// <para>The ID of the rule.</para>
        /// <para>For more information about how to obtain the ID of a rule, see <a href="https://help.aliyun.com/document_detail/169607.html">ListConfigRules</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cr-d369626622af008e****</para>
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

    }

}
