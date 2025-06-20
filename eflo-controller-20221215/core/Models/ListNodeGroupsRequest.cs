// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListNodeGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i119982311660892626523</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100.</para>
        /// <para>Default value:</para>
        /// <para>• If you do not configure this parameter or if you set this parameter to a value less than 20, the default value is 20.</para>
        /// <para>• If you set this parameter to a value greater than 100, the default value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a3f2224a5ec7224116c4f5246120abe4</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The node group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-ec3c96ff0aa4c60d</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

    }

}
