// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetMatchedResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The certificate IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19736665</para>
        /// </summary>
        [NameInMap("CertIds")]
        [Validation(Required=false)]
        public string CertIds { get; set; }

        /// <summary>
        /// <para>Because of the large number of matched resources, the backend uses aggregation and does not support pagination. This parameter is reserved. By default, a maximum of 2,000 entries are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Because of the large number of matched resources, the backend uses aggregation and does not support pagination. This parameter is reserved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>666</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The resource match scope. This parameter can be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>目前支持全部云产品</para>
        /// </summary>
        [NameInMap("ResourceScope")]
        [Validation(Required=false)]
        public string ResourceScope { get; set; }

    }

}
