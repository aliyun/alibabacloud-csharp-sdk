// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetAccessPageSessionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a-062wec3cwmayw****</para>
        /// </summary>
        [NameInMap("AccessPageId")]
        [Validation(Required=false)]
        public string AccessPageId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8141B1A674D48ACB8E5D2D6CE53FDB2F3CF8710A5F8F78578D5254BC6F******</para>
        /// </summary>
        [NameInMap("AccessPageToken")]
        [Validation(Required=false)]
        public string AccessPageToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Banca******</para>
        /// </summary>
        [NameInMap("ExternalUserId")]
        [Validation(Required=false)]
        public string ExternalUserId { get; set; }

    }

}
