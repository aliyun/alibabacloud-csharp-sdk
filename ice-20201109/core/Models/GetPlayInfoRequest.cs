// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetPlayInfoRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the playback URL, in seconds. The value defaults to 3600, which is also the minimum.</para>
        /// </summary>
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public long? AuthTimeout { get; set; }

        /// <summary>
        /// <para>The InputURL used to register the media asset. For more information, see <a href="https://help.aliyun.com/document_detail/441152.html">RegisterMediaInfo</a>.</para>
        /// <remarks>
        /// <para>Specify at least one of MediaId and InputURL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4</a>  or  vod://<b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("InputURL")]
        [Validation(Required=false)]
        public string InputURL { get; set; }

        /// <summary>
        /// <para>The media asset ID.</para>
        /// <remarks>
        /// <para>Specify at least one of MediaId and InputURL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>86434e152b7d4f20be480574439fe***</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

    }

}
