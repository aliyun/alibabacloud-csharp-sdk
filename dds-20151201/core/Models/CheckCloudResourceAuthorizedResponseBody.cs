// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CheckCloudResourceAuthorizedResponseBody : TeaModel {
        /// <summary>
        /// <para>The authorization status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not authorized.</description></item>
        /// <item><description><b>1</b>: Authorized.</description></item>
        /// <item><description><b>2</b>: The user has not enabled KMS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AuthorizationState")]
        [Validation(Required=false)]
        public int? AuthorizationState { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A0181AC4-F186-46ED-87CA-100C70B86729</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the role that is authorized to access Alibaba Cloud resources.</para>
        /// <remarks>
        /// <para>The response includes this parameter only when the return value of <b>AuthorizationState</b> is <b>1</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::140****:role/aliyunrdsinstanceencryptiondefaultrole</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

    }

}
