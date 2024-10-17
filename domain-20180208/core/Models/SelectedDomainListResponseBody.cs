// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class SelectedDomainListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OssFileNotFound</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Module")]
        [Validation(Required=false)]
        public SelectedDomainListResponseBodyModule Module { get; set; }
        public class SelectedDomainListResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://selected-domain.oss-cn-zhangjiakou.aliyuncs.com/aliyun_selected_domain_20231109.gz?Expires=1699524493&OSSAccessKeyId=LTAI5tPMAybR4gfSEjdfAk1F&Signature=2Tpo7Eaf%2BqIop8SuMtI91m%2FAFpY%3D">http://selected-domain.oss-cn-zhangjiakou.aliyuncs.com/aliyun_selected_domain_20231109.gz?Expires=1699524493&amp;OSSAccessKeyId=LTAI5tPMAybR4gfSEjdfAk1F&amp;Signature=2Tpo7Eaf%2BqIop8SuMtI91m%2FAFpY%3D</a></para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>80011ABC-F573-4795-B0E8-377BFBBA3422</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
