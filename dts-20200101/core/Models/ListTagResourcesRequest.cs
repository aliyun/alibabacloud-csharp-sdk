// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The query token.</para>
        /// <remarks>
        /// <para>If a single request does not return all results, you can pass the <b>NextToken</b> value returned from the previous request in the subsequent request to continue the query.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>212db86sca4384811e0b5e8707ec2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID. Specify this parameter to indicate the region where the instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the data migration, data synchronization, or change tracking instance. You can call <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> to query instance IDs.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>N specifies the sequence number of the instance ID. For example, ResourceId.0 specifies the first instance ID, and ResourceId.1 specifies the second instance ID. You can query 1 to 50 instance IDs at a time.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You must specify at least one of this parameter and <b>Tag.N.Key</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dtsntk10k6r12v****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Set the value to <b>ALIYUN::DTS::INSTANCE</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN::DTS::INSTANCE</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tag value that corresponds to the tag key.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>N specifies the sequence number of the tag key. For example, Tag.0.Key specifies the first tag key, and Tag.1.Key specifies the second tag key. You can query 1 to 20 tag keys at a time.</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>You must specify at least one of this parameter and <b>ResourceId.N</b>. An empty string is not allowed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>testkey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>N specifies the sequence number of the tag value. For example, Tag.0.Value specifies the first tag value, and Tag.1.Value specifies the second tag value. You can query 1 to 20 tag values at a time.</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>An empty string is allowed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>testvalue1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
