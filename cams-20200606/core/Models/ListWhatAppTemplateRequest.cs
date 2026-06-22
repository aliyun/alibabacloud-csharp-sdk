// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListWhatAppTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The space ID of the ISV sub-customer or the instance ID of the direct customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2983883892</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>This parameter is reserved for internal use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("HetuParams")]
        [Validation(Required=false)]
        public string HetuParams { get; set; }

    }

}
