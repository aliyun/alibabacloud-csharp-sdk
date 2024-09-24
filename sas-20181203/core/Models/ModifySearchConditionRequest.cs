// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifySearchConditionRequest : TeaModel {
        /// <summary>
        /// <para>The filter condition. The value of this parameter is in the JSON format and is case-sensitive. The value contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>filterParams</b>: the filter-related parameters. The value is in the JSON format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>label</b>: the display name of the filter condition in the console.</para>
        /// </description></item>
        /// <item><description><para><b>value</b>: the settings of the filter condition. The value is in the JSON format. The value contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: the name of the field for filtering. For more information, see the value description of name.</description></item>
        /// <item><description><b>value</b>: the value of the field for filtering.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>LogicalExp</b>: the logical relationship among multiple filter conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OR</b></description></item>
        /// <item><description><b>AND</b></description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> Value description of <b>name</b>:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If <b>Type</b> is set to <b>ecs</b>, you can call the <a href="~~DescribeCriteria~~">DescribeCriteria</a> operation to query the supported filter conditions.</para>
        /// </description></item>
        /// <item><description><para>If <b>Type</b> is set to <b>cloud_product</b>, you can call the <a href="~~GetCloudAssetCriteria~~">GetCloudAssetCriteria</a> operation to query the supported filter conditions.</para>
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
        /// <para>The source IP address of the request. You do not need to specify this parameter. It is automatically obtained by the system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27.223.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The type of the asset. Default value: <b>ecs</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ecs</b>: host</description></item>
        /// <item><description><b>cloud_product</b>: Alibaba Cloud service</description></item>
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
