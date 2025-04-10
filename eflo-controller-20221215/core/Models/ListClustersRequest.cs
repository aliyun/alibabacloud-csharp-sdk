// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListClustersRequest : TeaModel {
        /// <summary>
        /// <para>Number of items per page for paginated queries, with a default value of 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>Query token, which is the value of the NextToken parameter returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a3f2224a5ec7224116c4f5246120abe4</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Resource group ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2bg6wyoox6jq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>tag info</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListClustersRequestTags> Tags { get; set; }
        public class ListClustersRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of tag object</para>
            /// 
            /// <b>Example:</b>
            /// <para>key_aa</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag object</para>
            /// 
            /// <b>Example:</b>
            /// <para>value_aa</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
