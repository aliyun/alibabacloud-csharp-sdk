// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ProvisionExternalApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403550611646604****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The permissions that are granted to the application. Separate multiple permissions with a semicolon (;).</para>
        /// <remarks>
        /// <para> For more information about the supported permissions, see <a href="https://help.aliyun.com/document_detail/93693.html">Overview</a>.</para>
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
