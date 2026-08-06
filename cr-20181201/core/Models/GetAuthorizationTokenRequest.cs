// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetAuthorizationTokenRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the temporary credential in hours. Valid values: 1 to 24. When you use STS to call this operation, the actual validity period is the minimum of the STS token validity period and this parameter value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExpiresInHours")]
        [Validation(Required=false)]
        public int? ExpiresInHours { get; set; }

        /// <summary>
        /// <para>The repository instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-kmsiwlxxdcvaduwb</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
