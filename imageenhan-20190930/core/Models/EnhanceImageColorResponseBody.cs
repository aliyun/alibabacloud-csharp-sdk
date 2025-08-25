// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class EnhanceImageColorResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public EnhanceImageColorResponseBodyData Data { get; set; }
        public class EnhanceImageColorResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/image-recolor/2020-06-23-10/24%3A14-3cf26e84-a5d2-49b0-8332-0e139e20c49e.png?Expires=1592909654&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=fHrYvitvm0qZJ9nrWYa%2Fjd4pQS">http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/image-recolor/2020-06-23-10/24%3A14-3cf26e84-a5d2-49b0-8332-0e139e20c49e.png?Expires=1592909654&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=fHrYvitvm0qZJ9nrWYa%2Fjd4pQS</a>****</para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2F306ABD-5BC3-4FA0-89CF-0DED5B3654EB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
