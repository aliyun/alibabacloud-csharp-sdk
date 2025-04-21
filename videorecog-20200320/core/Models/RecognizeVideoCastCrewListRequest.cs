// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videorecog20200320.Models
{
    public class RecognizeVideoCastCrewListRequest : TeaModel {
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<RecognizeVideoCastCrewListRequestParams> Params { get; set; }
        public class RecognizeVideoCastCrewListRequestParams : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cast</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://shanghai.oss-cn-shanghai.aliyuncs.com/download/xxxx.mp4">https://shanghai.oss-cn-shanghai.aliyuncs.com/download/xxxx.mp4</a></para>
        /// </summary>
        [NameInMap("VideoUrl")]
        [Validation(Required=false)]
        public string VideoUrl { get; set; }

    }

}
