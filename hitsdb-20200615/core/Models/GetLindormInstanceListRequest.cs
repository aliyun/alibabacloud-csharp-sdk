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
        /// <para>The page number to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>A keyword for a fuzzy search on instance names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("QueryStr")]
        [Validation(Required=false)]
        public string QueryStr { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance is located. Call <a href="https://help.aliyun.com/document_detail/426062.html">DescribeRegions</a> to obtain the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
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
        /// <para>The type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>lindorm</b>: a single-zone Lindorm instance.</para>
        /// </description></item>
        /// <item><description><para><b>lindorm_multizone</b>: a multi-zone Lindorm instance.</para>
        /// </description></item>
        /// <item><description><para><b>serverless_lindorm</b>: a Lindorm Serverless instance.</para>
        /// </description></item>
        /// <item><description><para><b>lindorm_standalone</b>: a Lindorm standalone instance.</para>
        /// </description></item>
        /// <item><description><para><b>lts</b>: the Lindorm Tunnel Service (LTS) type.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The type of the engine supported by the instance that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: search engine.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: LindormTSDB.</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: LindormTable.</para>
        /// </description></item>
        /// <item><description><para><b>8</b>: file engine.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For example, a value of 15 (8 + 4 + 2 + 1) indicates that the instance supports the file engine, LindormTable, LindormTSDB, and the search engine. A value of 6 (4 + 2) indicates that the instance supports LindormTSDB and LindormTable.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("SupportEngine")]
        [Validation(Required=false)]
        public int? SupportEngine { get; set; }

        /// <summary>
        /// <para>A list of tags. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<GetLindormInstanceListRequestTag> Tag { get; set; }
        public class GetLindormInstanceListRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// <remarks>
            /// <para>You can pass in keys for multiple tags. For example, the Key in the first pair represents the key for the first tag. The Key in the second pair represents the key for the second tag.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// <remarks>
            /// <para>You can provide values for multiple tags. For example, the Value in the first pair is the value for the first tag. The Value in the second pair is the value for the second tag.</para>
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
