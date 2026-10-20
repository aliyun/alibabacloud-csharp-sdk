// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListNodePoolComponentInstanceNodesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Filters nodes by the specified configuration version number of the node component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("config_revision")]
        [Validation(Required=false)]
        public string ConfigRevision { get; set; }

        /// <summary>
        /// <para>The maximum number of records to return in a single response for pagination. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("max_results")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination cursor. Do not specify this parameter for the first request. For subsequent requests, specify the token returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c0a1c0f91c14c6****</para>
        /// </summary>
        [NameInMap("next_token")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Specifies the list of node names to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-hangzhou.10.91.xx.xx&quot;]</para>
        /// </summary>
        [NameInMap("node_names")]
        [Validation(Required=false)]
        public string NodeNamesShrink { get; set; }

        /// <summary>
        /// <para>Filters nodes by the specified node component version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.28.9-aliyun.1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
