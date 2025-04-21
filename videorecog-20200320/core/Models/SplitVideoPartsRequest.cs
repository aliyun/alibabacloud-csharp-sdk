// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videorecog20200320.Models
{
    public class SplitVideoPartsRequest : TeaModel {
        [NameInMap("MaxTime")]
        [Validation(Required=false)]
        public int? MaxTime { get; set; }

        [NameInMap("MinTime")]
        [Validation(Required=false)]
        public int? MinTime { get; set; }

        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://viapi-test.oss-cn-shanghai.aliyuncs.com/test-team/ocr/xxxx.mp4">https://viapi-test.oss-cn-shanghai.aliyuncs.com/test-team/ocr/xxxx.mp4</a></para>
        /// </summary>
        [NameInMap("VideoUrl")]
        [Validation(Required=false)]
        public string VideoUrl { get; set; }

    }

}
