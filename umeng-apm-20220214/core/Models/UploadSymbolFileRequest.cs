// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_apm20220214.Models
{
    public class UploadSymbolFileRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("appVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("fileType")]
        [Validation(Required=false)]
        public int? FileType { get; set; }

        [NameInMap("flutterName")]
        [Validation(Required=false)]
        public string FlutterName { get; set; }

        [NameInMap("ossUrl")]
        [Validation(Required=false)]
        public string OssUrl { get; set; }

    }

}
