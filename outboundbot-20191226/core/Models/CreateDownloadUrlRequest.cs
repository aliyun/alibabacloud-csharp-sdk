// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateDownloadUrlRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>137da36b41304bcd999a0a7895dc6881</para>
        /// </summary>
        [NameInMap("DownloadTaskId")]
        [Validation(Required=false)]
        public string DownloadTaskId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6f91885fa24b4c408d8f4eb392fd8ae6</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

    }

}
