// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videorecog20200320.Models
{
    public class EvaluateVideoQualityAdvanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>vqa_plus</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://public-vigen-video.oss-cn-shanghai.aliyuncs.com/Common/xxx/dont_delete/decaption/123.mp4">http://public-vigen-video.oss-cn-shanghai.aliyuncs.com/Common/xxx/dont_delete/decaption/123.mp4</a></para>
        /// </summary>
        [NameInMap("VideoUrl")]
        [Validation(Required=false)]
        public Stream VideoUrlObject { get; set; }

    }

}
