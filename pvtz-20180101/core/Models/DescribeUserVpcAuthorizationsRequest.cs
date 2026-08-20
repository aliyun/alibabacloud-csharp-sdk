// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeUserVpcAuthorizationsRequest : TeaModel {
        /// <summary>
        /// <para>The authorization type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>NORMAL: A regular authorization.</para>
        /// </description></item>
        /// <item><description><para>CLOUD_PRODUCT: An authorization for an Alibaba Cloud service.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that owns the authorized resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>141339776561****</para>
        /// </summary>
        [NameInMap("AuthorizedUserId")]
        [Validation(Required=false)]
        public long? AuthorizedUserId { get; set; }

        /// <summary>
        /// <para>The page number. The value starts from 1. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The maximum value is 100. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
