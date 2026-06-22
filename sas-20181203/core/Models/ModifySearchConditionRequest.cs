// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifySearchConditionRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions. This parameter is in JSON format. Pay attention to the letter case when you specify this parameter. The following fields are included:</para>
        /// <list type="bullet">
        /// <item><description><para><b>filterParams</b>: The filter parameters. This parameter is in JSON format. The following fields are included:</para>
        /// <list type="bullet">
        /// <item><description><para><b>label</b>: The display name for the search in the console.</para>
        /// </description></item>
        /// <item><description><para><b>value</b>: The filter parameter condition. This parameter is in JSON format. The following fields are included:</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: The filter condition field. For more information about the valid values of this field, see the description below.</description></item>
        /// <item><description><b>value</b>: The value that corresponds to the filter condition field.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>LogicalExp</b>: The logical relationship between multiple filter conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OR</b>: or</description></item>
        /// <item><description><b>AND</b>: and<remarks>
        /// <para>Valid values of <b>name</b>:</para>
        /// <list type="bullet">
        /// <item><description>If <b>Type</b> is set to <b>ecs</b>, call the <a href="~~DescribeCriteria~~">DescribeCriteria</a> operation to query the supported search conditions.</description></item>
        /// <item><description>If <b>Type</b> is set to <b>cloud_product</b>, call the <a href="~~GetCloudAssetCriteria~~">GetCloudAssetCriteria</a> operation to query the supported search conditions.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;filterParams&quot;: [
        ///         {
        ///             &quot;label&quot;: &quot;UUID：xxx&quot;,
        ///             &quot;value&quot;: &quot;{\&quot;name\&quot;:\&quot;uuidList\&quot;,\&quot;value\&quot;:\&quot;xxx\&quot;}&quot;
        ///         }
        ///     ],
        ///     &quot;LogicalExp&quot;: &quot;OR&quot;
        /// }</para>
        /// </summary>
        [NameInMap("FilterConditions")]
        [Validation(Required=false)]
        public string FilterConditions { get; set; }

        /// <summary>
        /// <para>The name of the common filter condition.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The source IP address of the request. You do not need to specify this parameter. The system automatically obtains the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27.223.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The asset type. Default value: <b>ecs</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ecs</b>: host asset</description></item>
        /// <item><description><b>cloud_product</b>: cloud service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
