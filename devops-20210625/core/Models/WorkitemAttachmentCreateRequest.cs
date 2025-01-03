// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class WorkitemAttachmentCreateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1106473328927498/1106473328927498/5ec071g0e5ij85fche8cddchje.xlsx</para>
        /// </summary>
        [NameInMap("fileKey")]
        [Validation(Required=false)]
        public string FileKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx.tgz</para>
        /// </summary>
        [NameInMap("originalFilename")]
        [Validation(Required=false)]
        public string OriginalFilename { get; set; }

    }

}
