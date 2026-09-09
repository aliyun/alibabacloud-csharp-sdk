// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateApiKeyRequest : TeaModel {
        /// <summary>
        /// <para>The list of Logstores to which data can be written.</para>
        /// </summary>
        [NameInMap("allowedStores")]
        [Validation(Required=false)]
        public List<string> AllowedStores { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
