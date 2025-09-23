// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoseg20200320.Models
{
    public class SegmentVideoBodyRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/videoseg/SegmentVideoBody/SegmentVideoBody1.mp4">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/videoseg/SegmentVideoBody/SegmentVideoBody1.mp4</a></para>
        /// </summary>
        [NameInMap("VideoUrl")]
        [Validation(Required=false)]
        public string VideoUrl { get; set; }

    }

}
