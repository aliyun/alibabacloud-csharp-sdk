// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateCheckScopeConfigRequest : TeaModel {
        /// <summary>
        /// <para>The JSON string of the automatic scan configuration. The following fields are included:</para>
        /// <list type="bullet">
        /// <item><description><b>autoInclude</b>: specifies whether to enable automatic scanning. Valid values: <b>true</b>: enabled. <b>false</b>: disabled.</description></item>
        /// <item><description><b>autoRule</b>: the configuration for enabling automatic scanning.</description></item>
        /// <item><description><b>ruleOperator</b>: the rule operator for the configuration. Set the value to <b>include</b>.</description></item>
        /// <item><description><b>operator</b>: the logical operator. Set the value to <b>or</b>.</description></item>
        /// <item><description><b>rule</b>: the rule.</description></item>
        /// <item><description><b>condition</b>: the rule condition. Valid values: <b>vendor</b>: vendor, <b>assetType</b>: primary asset type, <b>assetSubType</b>: secondary asset type.<remarks>
        /// <para>For specific meanings, refer to the <a href="~~GetCloudAssetCriteria~~">GetCloudAssetCriteria</a> operation.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required when AutoType is set to 1 (automatic scan enabled). Provide a valid JSON configuration string. This parameter is not required when AutoType is set to 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\&quot;autoInclude\&quot;:true,\&quot;autoRule\&quot;:{\&quot;ruleOperator\&quot;:\&quot;include\&quot;,\&quot;operator\&quot;:\&quot;or\&quot;,\&quot;rule\&quot;:[{\&quot;condition\&quot;:\&quot;assetSubType\&quot;,\&quot;ruleOperator\&quot;:\&quot;include\&quot;,\&quot;value\&quot;:[{\&quot;vendor\&quot;:\&quot;0\&quot;,\&quot;assetType\&quot;:\&quot;0\&quot;,\&quot;assetSubType\&quot;:\&quot;100\&quot;}]}]}}&quot;</para>
        /// </summary>
        [NameInMap("AutoConfig")]
        [Validation(Required=false)]
        public string AutoConfig { get; set; }

        /// <summary>
        /// <para>The type of the automatic scan configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Automatic scan is disabled.</description></item>
        /// <item><description><b>1</b>: Automatically scan newly added cloud assets.</description></item>
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

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that corresponds to the member accounts in the resource folder.</para>
        /// <remarks>
        /// <para>Invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>127608589417****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The type of the scan scope configuration. Valid values:</para>
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
