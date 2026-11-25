// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLindormInstanceListRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page for paging in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The keyword used to perform a fuzzy search by instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("QueryStr")]
        [Validation(Required=false)]
        public string QueryStr { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/426062.html">DescribeRegions</a> operation to query the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek3b63arvg27vi</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm</b>: Lindorm single-zone instance</description></item>
        /// <item><description><b>lindorm_multizone</b>: Lindorm multi-zone instance</description></item>
        /// <item><description><b>serverless_lindorm</b>: Lindorm Serverless instance</description></item>
        /// <item><description><b>lindorm_standalone</b>: Lindorm single-node instance</description></item>
        /// <item><description><b>lts</b>: Lindorm Tunnel Service</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The data engine types supported by the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Search engine</description></item>
        /// <item><description><b>2</b>: LindormTSDB</description></item>
        /// <item><description><b>4</b>: LindormTable</description></item>
        /// <item><description><b>8</b>: File engine</description></item>
        /// </list>
        /// <remarks>
        /// <para>For example, if the value is 15 (15 = 8 + 4 + 2 + 1), the instance supports the search engine, LindormTSDB, LindormTable, and file engine. If the value is 6 (6 = 4 + 2), the instance supports LindormTSDB and LindormTable.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("SupportEngine")]
        [Validation(Required=false)]
        public int? SupportEngine { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<GetLindormInstanceListRequestTag> Tag { get; set; }
        public class GetLindormInstanceListRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. Valid values of N: 1 to 20.</para>
            /// <remarks>
            /// <para>You can specify multiple tag keys. For example, the first Key specifies the first tag key, and the second Key specifies the second tag key.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Valid values of N: 1 to 20.</para>
            /// <remarks>
            /// <para>You can specify multiple tag values. For example, the first Value specifies the first tag value, and the second Value specifies the second tag value.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.18</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
