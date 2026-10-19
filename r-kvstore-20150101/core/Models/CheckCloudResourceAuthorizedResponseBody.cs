// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CheckCloudResourceAuthorizedResponseBody : TeaModel {
        /// <summary>
        /// <para>The authorization status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not authorized.</description></item>
        /// <item><description><b>1</b>: Authorized.</description></item>
        /// <item><description><b>2</b>: KMS is not activated. For more information, see <a href="https://help.aliyun.com/document_detail/153781.html">Activate KMS</a>.</description></item>
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
        /// <para>A501A191-BD70-5E50-98A9-C2A486A82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
