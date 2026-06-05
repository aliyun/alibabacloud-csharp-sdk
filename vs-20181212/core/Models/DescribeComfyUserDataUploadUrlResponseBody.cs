// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeComfyUserDataUploadUrlResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-08-28T16:00Z</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss-bucket.oss-cn-shanghai-cloudspe.aliyuncs.com/path/userid/test.png?x-oss-date=20260602T093618Z&amp;x-oss-expires=29&amp;x-oss-security-token=xxxxx%2F68FY2NI6nyNgueynMjneKjKXD6l5tS5h3S2%xxxxx%xxxx%xxxxxxx%2Fb%xxxx%sdffeeeaasdf%xxx%xx%xx%xxxx%2BeASOv2N8q%xxx%2B6XBxllroojFliSTfsqGI2YMHpoRwJmyfXK32BQPb2SvQ0AM23soq%2FspAI4f9vtFG0yv9fKWMw%xxxxxxxxx%xxxxxxxx%3D%3D&amp;x-oss-signature-version=OSS4-HMAC&amp;x-oss-credential=STS.xxxxx%2F20260dfa202%2Fcn-shanghai-cloud%2Foss%2Faliyun_v4_request&amp;x-oss-signature=xxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("UploadUrl")]
        [Validation(Required=false)]
        public string UploadUrl { get; set; }

    }

}
