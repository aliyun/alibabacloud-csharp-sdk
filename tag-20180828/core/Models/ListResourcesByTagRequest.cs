// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListResourcesByTagRequest : TeaModel {
        [NameInMap("TagFilter")]
        [Validation(Required=false)]
        public ListResourcesByTagRequestTagFilter TagFilter { get; set; }
        public class ListResourcesByTagRequestTagFilter : TeaModel {
            /// <summary>
            /// <para>The tag key. This parameter specifies a filter condition for the query.</para>
            /// <para>The tag key can be a maximum of 128 characters in length. It cannot contain <c>http://</c> or <c>https://</c> and cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. This parameter specifies a filter condition for the query.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
        /// <item><description>EQUAL: exact match for resources to which the specified tag is added. This is the default value.</description></item>
        /// <item><description>NOT: exact match for resources to which the specified tag is not added.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EQUAL</para>
        /// </summary>
        [NameInMap("FuzzyType")]
        [Validation(Required=false)]
        public string FuzzyType { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the information of tags added to the resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>False: does not return the information of tags added to the resources. This is the default value.</description></item>
        /// <item><description>True: returns the information of all tags added to the resources.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IncludeAllTags")]
        [Validation(Required=false)]
        public bool? IncludeAllTags { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Default value: 50. Maximum value: 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResult")]
        [Validation(Required=false)]
        public int? MaxResult { get; set; }

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
        /// <para>The region ID.</para>
        /// <para>For more information about region IDs, see <a href="https://help.aliyun.com/document_detail/2330902.html">Endpoints</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The resource type. This parameter specifies a filter condition for the query.</para>
        /// <list type="bullet">
        /// <item><description>If you set the FuzzyType parameter to EQUAL, you can set this parameter to a value obtained from the response of the <a href="https://help.aliyun.com/document_detail/2330915.html">ListSupportResourceTypes</a> operation.</description></item>
        /// <item><description>If you set the FuzzyType parameter to NOT, you can set this parameter to a resource type provided in <b>Types of resources that support queries based on the NOT operator</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN::VPC::VPC</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
