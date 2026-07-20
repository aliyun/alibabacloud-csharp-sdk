// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class BatchGrantPermissionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error message. This parameter is not empty when success is false, indicating a business error. This parameter is empty when success is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>空</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The list of permissions that failed to be granted.</para>
        /// </summary>
        [NameInMap("failurePermissions")]
        [Validation(Required=false)]
        public List<FailurePermission> FailurePermissions { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The API call was successful.</description></item>
        /// <item><description>false: The API call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
