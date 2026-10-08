// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The token used to return more results. You do not need to specify this parameter for the first query. If a query does not return all results, pass in the token returned from the previous query to continue the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>212db86sca4384811e0b5e8707ec21345</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query available region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of instance IDs. You can query tags for multiple instances at a time. Valid values of the number of instances: <b>1</b> to <b>50</b>.</para>
        /// <remarks>
        /// <para>You must specify at least one of the <b>ResourceId</b> and <b>Tag.Key</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxx</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>INSTANCE</b>: regular ApsaraDB RDS instance.</description></item>
        /// <item><description><b>CUSTOM</b>: RDS Custom instance.</description></item>
        /// <item><description><b>CUSTOMDEPLOYMENTSET</b>: RDS Custom deployment set.</description></item>
        /// <item><description><b>CUSTOMDISK</b>: RDS Custom cloud disk.</description></item>
        /// <item><description><b>CUSTOMSNAPSHOT</b>: RDS Custom snapshot.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can query N tag keys at a time. Valid values of N: <b>1</b> to <b>20</b>. Empty strings are not allowed.</para>
            /// <remarks>
            /// <para>You must specify at least one of the <b>ResourceId</b> and <b>Tag.Key</b> parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>testkey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value that corresponds to the tag key. You can query N tag values at a time. Valid values of N: <b>1</b> to <b>20</b>. Empty strings are allowed.</para>
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
