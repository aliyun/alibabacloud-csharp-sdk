// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ProvisionExternalApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the external application that was created by another Alibaba Cloud account and can be installed by the current account. The application IDs returned by <c>ListApplications</c> for the current account are not applicable. <c>ListExternalApplications</c> and <c>ListApplicationProvisionInfos</c> only query installed records and cannot discover external application IDs that have not been installed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403550611646604****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The permission scopes granted to the application. You can specify multiple scopes separated by semicolons (;).</para>
        /// <remarks>
        /// <para>For supported permission scopes, refer to &quot;OAuth Scopes&quot; in <a href="https://help.aliyun.com/document_detail/93693.html">OAuth application overview</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>openid;aliuid</para>
        /// </summary>
        [NameInMap("Scopes")]
        [Validation(Required=false)]
        public string Scopes { get; set; }

    }

}
