// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ObtainCloudAccountRoleAccessCredentialRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::xxx:role/role-test</para>
        /// </summary>
        [NameInMap("cloudAccountRoleExternalId")]
        [Validation(Required=false)]
        public string CloudAccountRoleExternalId { get; set; }

    }

}
