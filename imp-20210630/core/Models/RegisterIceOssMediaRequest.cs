// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class RegisterIceOssMediaRequest : TeaModel {
        /// <summary>
        /// 工程ID
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// appId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 回放cdn域名
        /// </summary>
        [NameInMap("PlaybackUrlDomain")]
        [Validation(Required=false)]
        public string PlaybackUrlDomain { get; set; }

        /// <summary>
        /// oss bucket
        /// </summary>
        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        /// <summary>
        /// oss域名
        /// </summary>
        [NameInMap("OssEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        /// <summary>
        /// 回放地址的区域ID
        /// </summary>
        [NameInMap("UrlRegionId")]
        [Validation(Required=false)]
        public string UrlRegionId { get; set; }

        /// <summary>
        /// 待注册的媒资在相应系统中的地址
        /// </summary>
        [NameInMap("MediaUrl")]
        [Validation(Required=false)]
        public string MediaUrl { get; set; }

        /// <summary>
        /// 来源的服务
        /// </summary>
        [NameInMap("FromType")]
        [Validation(Required=false)]
        public string FromType { get; set; }

        /// <summary>
        /// 媒资标题
        /// </summary>
        [NameInMap("MediaTitle")]
        [Validation(Required=false)]
        public string MediaTitle { get; set; }

        /// <summary>
        /// 唯一ID，比如直播uuid
        /// </summary>
        [NameInMap("LiveId")]
        [Validation(Required=false)]
        public string LiveId { get; set; }

    }

}
