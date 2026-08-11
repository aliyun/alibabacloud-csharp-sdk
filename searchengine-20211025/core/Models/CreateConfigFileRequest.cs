// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateConfigFileRequest : TeaModel {
        /// <summary>
        /// <para>The directory name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/schemas/device_event_xt_schema.json</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The OSS storage address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://xxx/xxxx/xxx</para>
        /// </summary>
        [NameInMap("ossPath")]
        [Validation(Required=false)]
        public string OssPath { get; set; }

        /// <summary>
        /// <para>The parent file path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("parentFullPath")]
        [Validation(Required=false)]
        public string ParentFullPath { get; set; }

    }

}
