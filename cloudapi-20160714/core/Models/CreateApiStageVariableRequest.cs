// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateApiStageVariableRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the API group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>523e8dc7bbe04613b5b1d726c2a7889d</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The ID of the runtime environment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EF60BEC-0242-43AF-BB20-270359FB54A7</para>
        /// </summary>
        [NameInMap("StageId")]
        [Validation(Required=false)]
        public string StageId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The routing model of the environment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;location&quot;: &quot;HEAD&quot;,
        ///     &quot;parameterCatalog&quot;: &quot;CUSTOM&quot;,
        ///     &quot;parameterType&quot;: &quot;String&quot;,
        ///     &quot;serviceParameterName&quot;: &quot;TestConstant&quot;,
        ///     &quot;routeMatchSymbol&quot;: &quot;IN&quot;,
        ///     &quot;routeRules&quot;: [
        ///         {
        ///             &quot;conditionValue&quot;: &quot;aaa,bbb&quot;,
        ///             &quot;resultValue&quot;: &quot;apigateway-test.com&quot;
        ///         }
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("StageRouteModel")]
        [Validation(Required=false)]
        [Obsolete]
        public string StageRouteModel { get; set; }

        /// <summary>
        /// <para>Specifies whether routing is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SupportRoute")]
        [Validation(Required=false)]
        public bool? SupportRoute { get; set; }

        /// <summary>
        /// <para>The name of the variable to be added. This parameter is case-sensitive.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>serverName</para>
        /// </summary>
        [NameInMap("VariableName")]
        [Validation(Required=false)]
        public string VariableName { get; set; }

        /// <summary>
        /// <para>The value of the variable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api.domain.com</para>
        /// </summary>
        [NameInMap("VariableValue")]
        [Validation(Required=false)]
        public string VariableValue { get; set; }

    }

}
