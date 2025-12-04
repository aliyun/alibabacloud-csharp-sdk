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
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of instances to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The keyword contained in the names of Lindorm instances you want to query. Fuzzy queries based on the keyword is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("QueryStr")]
        [Validation(Required=false)]
        public string QueryStr { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the instances that you want to query is located. You can call the <a href="https://help.aliyun.com/document_detail/426062.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
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
        /// <para>The series of instances that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm</b>: The instance is a single-zone Lindorm instance.</description></item>
        /// <item><description><b>lindorm_multizone</b>: The instance is a multi-zone Lindorm instance.</description></item>
        /// <item><description><b>serverless_lindorm</b>: The instance is a Lindorm Serverless instance.</description></item>
        /// <item><description><b>lindorm_standalone</b>: The instance is a single-node Lindorm instance.</description></item>
        /// <item><description><b>lts</b>: The instance is an LTS instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The engine supported by the instances that you want to query. The engines are indicated by different numbers:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: LindormSearch.</description></item>
        /// <item><description><b>2</b>: LindormTSDB</description></item>
        /// <item><description><b>4</b>: LindormTable</description></item>
        /// <item><description><b>8</b>: LindormDFS</description></item>
        /// </list>
        /// <remarks>
        /// <para> The value of this parameter is the sum of all numbers that indicate the engines supported by the instance. For example, if you set the value of this parameter to 15, which is the sum of 1, 2, 4, and 8, this operation queries instances that support all four engines. If you set the value of this parameter to 6, which is the sum of 2 and 4, this operation queries instances that support LindormTSDB and LindormTable.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("SupportEngine")]
        [Validation(Required=false)]
        public int? SupportEngine { get; set; }

        /// <summary>
        /// <para>The list of tags associated with the specified instances.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<GetLindormInstanceListRequestTag> Tag { get; set; }
        public class GetLindormInstanceListRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the instances you want to query. You can specify 1 to 20 tag keys.</para>
            /// <remarks>
            /// <para>You can specify the keys of multiple tags. For example, you can specify the key of the first tag in the first key-value pair contained in the value of this parameter and specify the key of the second tag in the second key-value pair.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the instances you want to query. You can specify 1 to 20 tag values.</para>
            /// <remarks>
            /// <para>You can specify the values of multiple tags. For example, you can specify the value of the first tag in the first key-value pair contained in the value of this parameter and specify the value of the second tag in the second key-value pair.</para>
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
