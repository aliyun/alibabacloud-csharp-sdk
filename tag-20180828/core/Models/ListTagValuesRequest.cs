// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListTagValuesRequest : TeaModel {
        [NameInMap("TagFilter")]
        [Validation(Required=false)]
        public ListTagValuesRequestTagFilter TagFilter { get; set; }
        public class ListTagValuesRequestTagFilter : TeaModel {
            /// <summary>
            /// <para>The tag value.</para>
            /// <para>This parameter is used together with the <c>FuzzyType</c> parameter.</para>
            /// <remarks>
            /// <para> This parameter is available only in the China (Shenzhen) and China (Hong Kong) regions.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The type of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EQUAL: exact match. This is the default value.</description></item>
        /// <item><description>PREFIX: prefix-based fuzzy match.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is available only in the China (Shenzhen) and China (Hong Kong) regions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>EQUAL</para>
        /// </summary>
        [NameInMap("FuzzyType")]
        [Validation(Required=false)]
        public string FuzzyType { get; set; }

        /// <summary>
        /// <para>The tag key. This parameter specifies a filter condition for the query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k1</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The token that is used to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of tag values to return on each page.</para>
        /// <para>Maximum value: 1000. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The category of the tags. This parameter specifies a filter condition for the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ResourceTag: resource tags, including custom and system tags. This is the default value.</description></item>
        /// <item><description>MetaTag: preset tags.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The value of this parameter is not case-sensitive.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceTag</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>For more information about region IDs, see <a href="https://help.aliyun.com/document_detail/2330902.html">Endpoints</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The resource type. This parameter specifies a filter condition for the query.</para>
        /// <para>Format: <c>ALIYUN::${ProductCode}::${ResourceType}</c>. All letters in the value of this parameter must be in uppercase.</para>
        /// <list type="bullet">
        /// <item><description><c>ProductCode</c>: the service code. You can set this field to a value obtained from the response of the <a href="https://help.aliyun.com/document_detail/2330915.html">ListSupportResourceTypes</a> operation.</description></item>
        /// <item><description><c>ResourceType</c>: the resource type. You can set this field to a value obtained from the response of the <a href="https://help.aliyun.com/document_detail/2330915.html">ListSupportResourceTypes</a> operation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN::ECS::INSTANCE</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
