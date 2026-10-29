// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Httpdns20160201.Models
{
    public class CreateSdnsRuleCategoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the policy created and saved in this request. This ID is consistent with the ID in the list and details, and is used for querying, updating, enabling, disabling, and deleting the policy. The ID is saved as a string to avoid precision loss of large integers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789012345678</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The ID of the request. This ID is used to troubleshoot call issues and is not the policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50F9C40E-188D-4208-BE2C-74271337****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
