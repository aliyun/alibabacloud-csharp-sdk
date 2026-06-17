// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CheckKMSAuthorizedResponseBody : TeaModel {
        /// <summary>
        /// <para>The authorization status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Unauthorized.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Authorized.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AuthorizationState")]
        [Validation(Required=false)]
        public int? AuthorizationState { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7E6A8FD-C50B-46B2-BA85-D8B8D3******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Global Resource Descriptor of the role. It specifies the role. For more information, see <a href="https://help.aliyun.com/document_detail/93689.html">RAM role overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1406926*****:role/aliyunrdsinstanceencryptiondefaultrole</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

    }

}
