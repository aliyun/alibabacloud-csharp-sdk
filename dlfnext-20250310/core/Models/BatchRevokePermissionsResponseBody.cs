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
        /// <item><description><para>A business error message is returned if \<c>success\\</c> is \<c>false\\</c>.</para>
        /// </description></item>
        /// <item><description><para>This parameter is empty if \<c>success\\</c> is \<c>true\\</c>.</para>
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
        /// <para>The permissions failed to be revoked.</para>
        /// </summary>
        [NameInMap("failurePermissions")]
        [Validation(Required=false)]
        public List<FailurePermission> FailurePermissions { get; set; }

        /// <summary>
        /// <para>Indicates whether the call succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
