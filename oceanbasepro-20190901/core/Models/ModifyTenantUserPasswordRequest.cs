// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyTenantUserPasswordRequest : TeaModel {
        /// <summary>
        /// 加密方式。
        /// </summary>
        [NameInMap("EncryptionType")]
        [Validation(Required=false)]
        public string EncryptionType { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// ```
        /// http(s)://[Endpoint]/?Action=ModifyTenantUserPassword
        /// &UserName=pay_test
        /// &TenantId=ob2mr3oae0****
        /// &UserPassword=!Aliyun4Oceanbase
        /// &InstanceId=ob317v4uif****
        /// &Common request parameters
        /// ```
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// The ID of the OceanBase cluster.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// You can call this operation to change the logon password of a specified account in a tenant.
        /// </summary>
        [NameInMap("UserPassword")]
        [Validation(Required=false)]
        public string UserPassword { get; set; }

    }

}
