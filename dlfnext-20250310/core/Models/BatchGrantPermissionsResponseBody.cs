// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class BatchGrantPermissionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error message returned if the request fails. If the request is successful, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>空</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The permissions failed to be granted.</para>
        /// </summary>
        [NameInMap("failurePermissions")]
        [Validation(Required=false)]
        public List<FailurePermission> FailurePermissions { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
