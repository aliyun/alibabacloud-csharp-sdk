// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class MakeSuperResolutionImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public MakeSuperResolutionImageResponseBodyData Data { get; set; }
        public class MakeSuperResolutionImageResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://ivpd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/upload/ai-gateway_prod/ds%253D20191121/sisrx2_157433961551387538.jpg?Expires=1574598816&OSSAccessKeyId=LTAI4FeJ8qKkYn6SrHhQ****&Signature=8phY6dOz4U889nHfHC1g51nwAi">http://ivpd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/upload/ai-gateway_prod/ds%253D20191121/sisrx2_157433961551387538.jpg?Expires=1574598816&amp;OSSAccessKeyId=LTAI4FeJ8qKkYn6SrHhQ****&amp;Signature=8phY6dOz4U889nHfHC1g51nwAi</a>****</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>47DD87F1-D077-499A-8D96-C82F006A6839</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
