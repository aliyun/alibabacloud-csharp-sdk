// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudGetRecordUrlResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CloudGetRecordUrlResponseBodyData Data { get; set; }
        public class CloudGetRecordUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>试听或下载地址，默认120分钟过期（可配置），过期后，需重新请求接口</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://voice-1.aliyun.cn/31102016/record/7000000/7000000-2016103111%204742-01087120766-01087120766--record-sip-1-1477885662.222.mp3?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Date=20161114T100003Z&X-Amz-SignedHeaders=host&X-Amz-Expires=119&X-Amz-Credential=AKIAOTCJOBZFUWFI7FSA%2F20161114%2Fcn-north-1%2Fs3%2Faws4_request&X-Amz-Signature=0cda4389ecc743acc71d76a320705afd0c175c5ad2286305675c4dee5189b9c8">http://voice-1.aliyun.cn/31102016/record/7000000/7000000-2016103111%204742-01087120766-01087120766--record-sip-1-1477885662.222.mp3?X-Amz-Algorithm=AWS4-HMAC-SHA256&amp;X-Amz-Date=20161114T100003Z&amp;X-Amz-SignedHeaders=host&amp;X-Amz-Expires=119&amp;X-Amz-Credential=AKIAOTCJOBZFUWFI7FSA%2F20161114%2Fcn-north-1%2Fs3%2Faws4_request&amp;X-Amz-Signature=0cda4389ecc743acc71d76a320705afd0c175c5ad2286305675c4dee5189b9c8</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6086693B-2250-17CE-A41F-06259AB6DB1B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
