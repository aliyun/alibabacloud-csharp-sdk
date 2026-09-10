// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class PostInnerUploadConvertPackageRequest : TeaModel {
        /// <summary>
        /// <para>The file content, Base64-encoded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>U0VMRUNUICogRlJPTSB0Ow==</para>
        /// </summary>
        [NameInMap("fileContentBase64")]
        [Validation(Required=false)]
        public string FileContentBase64 { get; set; }

        /// <summary>
        /// <para>The file name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_file</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The task ID that uniquely identifies a task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
