// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PolardbAI20251013.Models
{
    public class ListMultimodalSearchTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;Data&quot;: {</para>
        /// <h1>分页信息,</h1>
        /// <para>  &quot;Total&quot;: 5,
        ///   &quot;PageNumber&quot;: 1,
        ///   &quot;PageSize&quot;: 50,</para>
        /// <h1>数据列表</h1>
        /// <para>  &quot;Items&quot;: [
        ///     # 每个JSONObject为一个视频/图片的元信息
        ///     {
        ///       # 用户oss图片地址
        ///       &quot;OssUri&quot;: &quot;&quot;,
        ///       # 缩略图
        ///       &quot;ThumbnailUrl&quot;: &quot;&quot;,
        ///       # 原图，点击查看
        ///       &quot;DownloadUrl&quot;: &quot;&quot;,
        ///       # 文件类型（视频/图片）
        ///       &quot;FileType&quot;: &quot;&quot;,
        ///       # 文件名
        ///       &quot;FileName&quot;: &quot;&quot;,
        ///     }, {}, ..
        ///   ]
        /// },
        /// &quot;Success&quot;: true,
        /// &quot;RequestId&quot;: &quot;***&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>错误码</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>错误信息</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>983863E2-****-1D15-A4AE-3468CD75383D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
