// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateAppInstanceTicketRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>WS20250801154628000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>d566aaf2-7c88-40a4-982f-6abef0be13c9</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

    }

}
