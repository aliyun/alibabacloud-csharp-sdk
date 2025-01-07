// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SaveWhiteListStrategyAssetsRequest : TeaModel {
        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform. This parameter is in the JSON format. The value is case-sensitive. The value contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>status</b>: the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: the delete operation.</description></item>
        /// <item><description><b>1</b>: the add operation.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>target</b>: the UUID of the server.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to obtain the value of <b>target</b> from the response parameter Uuid.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;status&quot;:0,&quot;target&quot;:&quot;c98dcd24-fa57-4759-b5ec-f8a4ffeed****&quot;}]</para>
        /// </summary>
        [NameInMap("Operations")]
        [Validation(Required=false)]
        public string Operations { get; set; }

        /// <summary>
        /// <para>The type of the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: learning policy.</description></item>
        /// <item><description><b>2</b>: application policy.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RelationType")]
        [Validation(Required=false)]
        public int? RelationType { get; set; }

        /// <summary>
        /// <para>The source IP address of the request. You do not need to specify this parameter. It is automatically obtained by the system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>115.193.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The ID of the policy.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeWhiteListStrategyList~~">DescribeWhiteListStrategyList</a> operation to query the ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2730</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

    }

}
