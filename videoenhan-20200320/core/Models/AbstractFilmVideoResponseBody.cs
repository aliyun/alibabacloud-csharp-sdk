// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class AbstractFilmVideoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AbstractFilmVideoResponseBodyData Data { get; set; }
        public class AbstractFilmVideoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/film-summary/EA61D012-5F89-4102-931E-419158BE2ADA_gb27k00.mp4?Expires=1584707613&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=weTexlBR1wmQlAhuU2JXaE7AyJ">http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/film-summary/EA61D012-5F89-4102-931E-419158BE2ADA_gb27k00.mp4?Expires=1584707613&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=weTexlBR1wmQlAhuU2JXaE7AyJ</a>****</para>
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
        /// <para>9A5B872B-1BF0-4D84-90DA-A2EE1F072B82</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
