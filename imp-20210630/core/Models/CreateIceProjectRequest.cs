/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class CreateIceProjectRequest : TeaModel {
        /// <summary>
        /// appId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 回放地址的地址
        /// </summary>
        [NameInMap("UrlRegionId")]
        [Validation(Required=false)]
        public string UrlRegionId { get; set; }

        /// <summary>
        /// 工程标题
        /// </summary>
        [NameInMap("ProjectTitle")]
        [Validation(Required=false)]
        public string ProjectTitle { get; set; }

        /// <summary>
        /// 封面
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// 唯一ID，比如直播uuid
        /// </summary>
        [NameInMap("LiveId")]
        [Validation(Required=false)]
        public string LiveId { get; set; }

    }

}
