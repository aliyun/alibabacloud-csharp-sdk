// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckScopeConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success. Any other value indicates failure. You can use this field to determine the cause of the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCheckScopeConfigResponseBodyData Data { get; set; }
        public class GetCheckScopeConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The automatic scan configuration as a JSON string. The following fields are included:</para>
            /// <list type="bullet">
            /// <item><description><b>autoInclude</b>: specifies whether to enable automatic scanning. Valid values: <b>true</b>: enabled. <b>false</b>: disabled.</description></item>
            /// <item><description><b>autoRule</b>: the enablement configuration.</description></item>
            /// <item><description><b>ruleOperator</b>: the enablement configuration rule. The value is <b>include</b>.</description></item>
            /// <item><description><b>operator</b>: the logical operator. The value is <b>or</b>.</description></item>
            /// <item><description><b>rule</b>: the rule.</description></item>
            /// <item><description><b>condition</b>: the rule condition. Valid values: <b>vendor</b>: vendor. <b>assetType</b>: level-1 asset type. <b>assetSubType</b>: level-2 asset type.<remarks>
            /// <para>For more information, see the <a href="~~GetCloudAssetCriteria~~">GetCloudAssetCriteria</a> operation.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{\&quot;autoInclude\&quot;:true,\&quot;autoRule\&quot;:{\&quot;ruleOperator\&quot;:\&quot;include\&quot;,\&quot;operator\&quot;:\&quot;or\&quot;,\&quot;rule\&quot;:[{\&quot;condition\&quot;:\&quot;assetSubType\&quot;,\&quot;ruleOperator\&quot;:\&quot;include\&quot;,\&quot;value\&quot;:[{\&quot;vendor\&quot;:\&quot;0\&quot;,\&quot;assetType\&quot;:\&quot;0\&quot;,\&quot;assetSubType\&quot;:\&quot;100\&quot;}]}]}}&quot;</para>
            /// </summary>
            [NameInMap("AutoConfig")]
            [Validation(Required=false)]
            public string AutoConfig { get; set; }

            /// <summary>
            /// <para>The automatic scan configuration type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: automatic scanning is disabled</description></item>
            /// <item><description><b>1</b>: automatically scan newly added cloud assets</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoType")]
            [Validation(Required=false)]
            public int? AutoType { get; set; }

            /// <summary>
            /// <para>The ID of the configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>97a1fed216908e417407344e1505xxxx</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-16 18:17:16</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-09 10:19:57</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The scan scope configuration type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: scan by instance</description></item>
            /// <item><description><b>3</b>: scan all</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7BC55C8F-226E-5AF5-9A2C-2EC43864****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
