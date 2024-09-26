// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSynchronizationJobsRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The tag value. You can call the <a href="https://help.aliyun.com/document_detail/191187.html">ListTagResources</a> operation to query the tag value.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>N specifies the serial number of the tag. For example, Tag.1.Value specifies the value of the first tag and Tag.2.Value specifies the value of the second tag. You can specify 1 to 20 tag values at a time.</description></item>
        /// <item><description>This parameter can be an empty string.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe63****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account. You do not need to specify this parameter because this parameter will be removed in the future.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the data synchronization task.</para>
        /// <remarks>
        /// <para> Fuzzy matching is supported.</para>
        /// </remarks>
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
        /// <para>The tag key. You can call the <a href="https://help.aliyun.com/document_detail/191187.html">ListTagResources</a> operation to query the tag key.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>N specifies the serial number of the tag. For example, Tag.1.Key specifies the key of the first tag and Tag.2.Key specifies the key of the second tag. You can specify 1 to 20 tag keys at a time.</description></item>
        /// <item><description>This parameter cannot be an empty string.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("SynchronizationJobName")]
        [Validation(Required=false)]
        public string SynchronizationJobName { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeSynchronizationJobsRequestTag> Tag { get; set; }
        public class DescribeSynchronizationJobsRequestTag : TeaModel {
            /// <summary>
            /// <para>The ID of the request.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testkey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The maximum number of entries that can be displayed on the current page.</para>
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
