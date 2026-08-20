// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DeleteUserVpcAuthorizationRequest : TeaModel {
        /// <summary>
        /// <para>The authorization type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>NORMAL: Standard authorization.</para>
        /// </description></item>
        /// <item><description><para>CLOUD_PRODUCT: Cloud product authorization.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: NORMAL</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that owns the authorized resources.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>141339776561****</para>
        /// </summary>
        [NameInMap("AuthorizedUserId")]
        [Validation(Required=false)]
        public long? AuthorizedUserId { get; set; }

    }

}
