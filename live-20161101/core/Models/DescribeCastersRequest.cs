// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCastersRequest : TeaModel {
        /// <summary>
        /// <para>The production studio ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If you created the production studio by calling the <a href="https://help.aliyun.com/document_detail/2848012.html">CreateCaster operation</a>, check the CasterId parameter returned by the CreateCaster operation.</para>
        /// </description></item>
        /// <item><description><para>If you created the production studio in the ApsaraVideo Live console, go to <b>ApsaraVideo Live console &gt; Production Studios &gt; Cloud Production Studio</b> to view the ID.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The production studio name in the production studio list on the Cloud Production Studio page is the production studio ID.</description></item>
        /// <item><description>If this parameter is left empty, the merged data of all production studios is returned by default.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>LIVEPRODUCER_POST-cn-0pp1czt****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The name of the production studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveCaster****</para>
        /// </summary>
        [NameInMap("CasterName")]
        [Validation(Required=false)]
        public string CasterName { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: PrePaid (subscription).</para>
        /// </description></item>
        /// <item><description><para>1: PostPaid (pay-as-you-go).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public int? ChargeType { get; set; }

        /// <summary>
        /// <para>The end time. Format: yyyy-MM-ddTHH:mm:ssZ (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T11:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The specification type of the production studio. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: general mode.</para>
        /// </description></item>
        /// <item><description><para>3: lightweight playlist mode.</para>
        /// </description></item>
        /// <item><description><para>4: virtual studio mode.</para>
        /// </description></item>
        /// <item><description><para>6: playlist mode (new playlist mode production studio).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NormType")]
        [Validation(Required=false)]
        public string NormType { get; set; }

        /// <summary>
        /// <para>Specifies whether to sort the production studios in ascending order by modification time.</para>
        /// <para>Valid values: true (ascending order by modification time) | false (descending order by modification time, which is the default value).</para>
        /// <remarks>
        /// <para>If this parameter is not specified, the default value is &quot;false&quot;.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OrderByModifyAsc")]
        [Validation(Required=false)]
        public string OrderByModifyAsc { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/2381067.html">What is a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzw******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The start time. Format: yyyy-MM-ddTHH:mm:ssZ (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T09:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: idle.  </para>
        /// </description></item>
        /// <item><description><para>1: streaming.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeCastersRequestTag> Tag { get; set; }
        public class DescribeCastersRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
