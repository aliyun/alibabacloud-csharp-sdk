// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddFileInfoRequest : TeaModel {
        /// <summary>
        /// 应用
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 文件业务类型
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public long? BusinessType { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public long? FileType { get; set; }

        /// <summary>
        /// 文件oss地址
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// 文件标题
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        /// <summary>
        /// 媒资Id
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

    }

}
