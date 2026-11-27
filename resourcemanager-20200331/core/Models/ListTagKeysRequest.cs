// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListTagKeysRequest : TeaModel {
        /// <summary>
        /// <para>The tag key for fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>team</para>
        /// </summary>
        [NameInMap("KeyFilter")]
        [Validation(Required=false)]
        public string KeyFilter { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return for a single request. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cm****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The resource type. Valid value: Account, which indicates a member of the resource directory.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Account</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
