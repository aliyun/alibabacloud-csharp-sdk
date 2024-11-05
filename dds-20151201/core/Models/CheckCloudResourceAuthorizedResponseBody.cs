// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CheckCloudResourceAuthorizedResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether KMS keys are authorized to ApsaraDB for MongoDB instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: KMS keys are not authorized.</description></item>
        /// <item><description><b>1</b>: KMS keys are authorized.</description></item>
        /// <item><description><b>2</b>: KMS is not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AuthorizationState")]
        [Validation(Required=false)]
        public int? AuthorizationState { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A0181AC4-F186-46ED-87CA-100C70B86729</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The role information of the authorized Alibaba Resource Name (ARN).</para>
        /// <remarks>
        /// <para> This parameter is returned only when the value of the <b>AuthorizationState</b> parameter is <b>1</b>.</para>
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
