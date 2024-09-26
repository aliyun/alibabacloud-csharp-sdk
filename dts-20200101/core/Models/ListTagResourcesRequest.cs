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
        /// <para> If a query does not return all results, you can specify the returned <b>NextToken</b> parameter in the next query to obtain more results.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>212db86sca4384811e0b5e8707ec2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the region where the data migration, data synchronization, or change tracking instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dtsntk10k6r12v****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid value: <b>ALIYUN::DTS::INSTANCE</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN::DTS::INSTANCE</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>N specifies the serial number of the tag. For example, Tag.1.Key specifies the key of the first tag and Tag.2.Key specifies the key of the second tag. You can specify 1 to 20 tag keys at a time.</description></item>
            /// <item><description>You must specify at least one of the <b>ResourceId.N</b> and Tag.N.Key parameters. The parameters cannot be empty strings.</description></item>
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
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>N specifies the serial number of the tag. For example, Tag.1.Value specifies the value of the first tag and Tag.2.Value specifies the value of the second tag. You can specify 1 to 20 tag values at a time.</description></item>
            /// <item><description>This parameter can be an empty string.</description></item>
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
