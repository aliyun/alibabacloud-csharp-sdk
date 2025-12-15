// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetResourceGroupAdminSettingResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether enable the Use Creator as Administrator feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CreatorAsAdmin")]
        [Validation(Required=false)]
        public bool? CreatorAsAdmin { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>776B05B3-A0B0-464B-A191-F4E1119A94B2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
