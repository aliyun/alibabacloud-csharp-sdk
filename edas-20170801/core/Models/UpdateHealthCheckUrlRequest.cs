// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateHealthCheckUrlRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c627c157-560d-43ff-***************</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The health check URL of the application. The URL must start with <c>http://</c>, and can be up to 255 characters in length. Example: <c>http://127.0.0.1:8080/_ehc.html</c>. If this parameter is not specified, the health check URL of the application is not changed.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://127.0.0.1:8080/_ehc.html">http://127.0.0.1:8080/_ehc.html</a></para>
        /// </summary>
        [NameInMap("hcURL")]
        [Validation(Required=false)]
        public string HcURL { get; set; }

    }

}
