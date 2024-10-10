// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateWebApplicationTrafficConfigInput : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Anonymous</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("DisableURLInternet")]
        [Validation(Required=false)]
        public bool? DisableURLInternet { get; set; }

        [NameInMap("RevisionsTrafficWeight")]
        [Validation(Required=false)]
        public Dictionary<string, float?> RevisionsTrafficWeight { get; set; }

        [NameInMap("WebAclConfig")]
        [Validation(Required=false)]
        public WebAclConfig WebAclConfig { get; set; }

    }

}
