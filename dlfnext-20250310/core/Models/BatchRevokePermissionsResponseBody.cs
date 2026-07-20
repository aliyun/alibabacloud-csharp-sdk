// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class BatchRevokePermissionsResponseBody : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>If success is false, a business error message is returned.</para>
        /// </description></item>
        /// <item><description><para>If success is true, an empty value is returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>空</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The results of permissions that failed to be revoked in batches.</para>
        /// </summary>
        [NameInMap("failurePermissions")]
        [Validation(Required=false)]
        public List<FailurePermission> FailurePermissions { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The API call is successful.</description></item>
        /// <item><description>false: The API call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
