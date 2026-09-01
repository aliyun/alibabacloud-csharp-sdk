// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateCheckScopeConfigRequest : TeaModel {
        /// <summary>
        /// <para>The automatic scan configuration as a JSON string. The following fields are included:</para>
        /// <list type="bullet">
        /// <item><description><b>autoInclude</b>: specifies whether to enable automatic scan. Valid values: <b>true</b>: enabled. <b>false</b>: disabled.</description></item>
        /// <item><description><b>autoRule</b>: the enablement configuration.</description></item>
        /// <item><description><b>ruleOperator</b>: the enablement configuration rule. Set the value to <b>include</b>.</description></item>
        /// <item><description><b>operator</b>: the logical operator. Set the value to <b>or</b>.</description></item>
        /// <item><description><b>rule</b>: the rule.</description></item>
        /// <item><description><b>condition</b>: the rule condition. Valid values: <b>vendor</b>: vendor. <b>assetType</b>: level-1 asset type. <b>assetSubType</b>: level-2 asset type.<remarks>
        /// <para>For more information, refer to the <a href="~~GetCloudAssetCriteria~~">GetCloudAssetCriteria</a> operation.</para>
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
        /// <item><description><b>0</b>: disable automatic scan</description></item>
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
        /// <remarks>
        /// <para>Call the <a href="~~GetCheckScopeConfig~~">GetCheckScopeConfig</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>00cfa8161da093089e6804ba6a33****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

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

}
