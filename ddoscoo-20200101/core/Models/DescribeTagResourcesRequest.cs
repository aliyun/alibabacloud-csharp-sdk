// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The query token. Set the value to the value of <b>NextToken</b> that is returned in the last call.</para>
        /// <remarks>
        /// <para>You do not need to configure this parameter if you call this operation for the first time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RGuYpqDdKhzXb8C3.D1BwQgc1tMBsoxdGiEKHHUUCf****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. Set the value to <b>cn-hangzhou</b>, which indicates an Anti-DDoS Proxy (Chinese Mainland) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs in Resource Management.</para>
        /// <para>If you do not configure this parameter, the instance belongs to the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the Anti-DDoS Proxy (Chinese Mainland) instances that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-mp91j1ao****</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The type of the resource to which the tag belongs. Set the value to <b>INSTANCE</b>, which indicates an Anti-DDoS Pro instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>An array consisting of tags that you want to query. Each tag consists of a tag <b>key</b> and a tag <b>value</b>.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeTagResourcesRequestTags> Tags { get; set; }
        public class DescribeTagResourcesRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag that you want to query.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>You must specify at least one of the <b>ResourceIds.N</b> and <b>Tags.N.Key</b> parameters.</para>
            /// </description></item>
            /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/159785.html">DescribeTagKeys</a> operation to query all tag keys.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>testkey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag that you want to query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testvalue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
