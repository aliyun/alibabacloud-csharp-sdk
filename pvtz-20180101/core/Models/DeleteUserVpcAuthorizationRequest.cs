// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DeleteUserVpcAuthorizationRequest : TeaModel {
        /// <summary>
        /// <para>The authorization scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NORMAL: general authorization</description></item>
        /// <item><description>NORMAL: cloud service-related authorization</description></item>
        /// </list>
        /// <para>Default value: NORMAL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
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
