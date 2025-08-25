// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class AbstractEcommerceVideoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AbstractEcommerceVideoResponseBodyData Data { get; set; }
        public class AbstractEcommerceVideoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/shop-video-abs/2020-03-20-19/YVgDynxB.jpg?Expires=1584707249&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=e5Q3O%2ByA6H7UhYJeMZxz4p70de">http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/shop-video-abs/2020-03-20-19/YVgDynxB.jpg?Expires=1584707249&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=e5Q3O%2ByA6H7UhYJeMZxz4p70de</a>****</para>
            /// </summary>
            [NameInMap("VideoCoverUrl")]
            [Validation(Required=false)]
            public string VideoCoverUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/shop-video-abs/2020-03-20-19/YVgDynxB.mp4?Expires=1584707249&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=KErufmbHvTUYYLRj6i42wY7Tew">http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/shop-video-abs/2020-03-20-19/YVgDynxB.mp4?Expires=1584707249&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=KErufmbHvTUYYLRj6i42wY7Tew</a>****</para>
            /// </summary>
            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50B33B81-CCB8-42BC-8A73-AC838618936E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
