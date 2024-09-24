// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeletePlayInfoRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletePhysicalFiles")]
        [Validation(Required=false)]
        public bool? DeletePhysicalFiles { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://ice-test001.oss-cn-shanghai.aliyuncs.com/%E6%8E%A5%E5%8F%A3%E6%B5%8B%E8%AF%95/%E5%B0%8F%E7%8C%AA%E4%BD%A9%E5%A5%87640*360.mp4">https://ice-test001.oss-cn-shanghai.aliyuncs.com/%E6%8E%A5%E5%8F%A3%E6%B5%8B%E8%AF%95/%E5%B0%8F%E7%8C%AA%E4%BD%A9%E5%A5%87640*360.mp4</a></para>
        /// </summary>
        [NameInMap("FileURLs")]
        [Validation(Required=false)]
        public string FileURLs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1d3518e0027d71ed80cd909598416303</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

    }

}
