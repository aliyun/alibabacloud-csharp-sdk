// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetUploadLinkResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned Data.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyuncs.com/test.mp3">http://www.aliyuncs.com/test.mp3</a></para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>An ID assigned by the backend to uniquely identify a request. It can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E37E2B77-A664-5278-8219-23BBC0EB2A35</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
