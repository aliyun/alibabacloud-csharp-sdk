// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCastersRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <list type="bullet">
        /// <item><description>If the production studio was created by calling the <a href="https://help.aliyun.com/document_detail/2848012.html">CreateCaster</a> operation, check the value of the response parameter CasterId to obtain the ID.</description></item>
        /// <item><description>If the production studio was created by using the ApsaraVideo Live console, obtain the ID on the <b>Production Studio Management</b> page. To go to the page, log on to the ApsaraVideo Live console and click Production Studios in the left-side navigation pane.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You can find the ID of the production studio in the Instance ID/Name column.</para>
        /// </description></item>
        /// <item><description><para>If you leave this parameter empty, the data of all production studios is returned.</para>
        /// </description></item>
        /// </list>
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
        /// <item><description>0: the subscription billing method</description></item>
        /// <item><description>1: the pay-as-you-go billing method</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public int? ChargeType { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T11:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The type of the production studio. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: general mode</description></item>
        /// <item><description>3: lightweight carousel playback mode</description></item>
        /// <item><description>4: virtual studio</description></item>
        /// <item><description>6: playlist mode</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NormType")]
        [Validation(Required=false)]
        public string NormType { get; set; }

        /// <summary>
        /// <para>Specifies whether to sort the production studios in ascending order based on the modification time.</para>
        /// <remarks>
        /// <para> If you leave this parameter empty, the default value is used. Default value: false.</para>
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
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of templates to return on each page. If you leave this parameter empty, the default value is used. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/2381067.html">Resource groups</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzw******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T09:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the production studio. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: idle</description></item>
        /// <item><description>1: streaming</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeCastersRequestTag> Tag { get; set; }
        public class DescribeCastersRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
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
