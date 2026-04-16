// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListWhatAppTemplateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2983883892</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("HetuParams")]
        [Validation(Required=false)]
        public string HetuParams { get; set; }

    }

}
