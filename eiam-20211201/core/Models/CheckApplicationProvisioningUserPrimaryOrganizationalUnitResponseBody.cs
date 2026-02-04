// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CheckApplicationProvisioningUserPrimaryOrganizationalUnitResponseBody : TeaModel {
        [NameInMap("CheckApplicationProvisioningUserPrimaryOuResult")]
        [Validation(Required=false)]
        public CheckApplicationProvisioningUserPrimaryOrganizationalUnitResponseBodyCheckApplicationProvisioningUserPrimaryOuResult CheckApplicationProvisioningUserPrimaryOuResult { get; set; }
        public class CheckApplicationProvisioningUserPrimaryOrganizationalUnitResponseBodyCheckApplicationProvisioningUserPrimaryOuResult : TeaModel {
            /// <summary>
            /// <para>是否授权</para>
            /// </summary>
            [NameInMap("AllowAuthorization")]
            [Validation(Required=false)]
            public bool? AllowAuthorization { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 实例Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 实例Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
