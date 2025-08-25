// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class QueryFaceVideoTemplateResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryFaceVideoTemplateResponseBodyData Data { get; set; }
        public class QueryFaceVideoTemplateResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<QueryFaceVideoTemplateResponseBodyDataElements> Elements { get; set; }
            public class QueryFaceVideoTemplateResponseBodyDataElements : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-09-06 15:17:19</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("FaceInfos")]
                [Validation(Required=false)]
                public List<QueryFaceVideoTemplateResponseBodyDataElementsFaceInfos> FaceInfos { get; set; }
                public class QueryFaceVideoTemplateResponseBodyDataElementsFaceInfos : TeaModel {
                    [NameInMap("TemplateFaceID")]
                    [Validation(Required=false)]
                    public string TemplateFaceID { get; set; }

                    [NameInMap("TemplateFaceURL")]
                    [Validation(Required=false)]
                    public string TemplateFaceURL { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3bf2418c-7adf-4002-a9d6-2f7cf1889c0d</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://vibktprfx-prod-prod-aic-gd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/image-face-fusion/OriginUrl/user/2021-09-06/e4d6ecf6-8dc8-4dac-acb5-56a737ccbc06?Expires=1630914551&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=kBcLm66y7%2FZ3eIMgwXJg1zNP7k">http://vibktprfx-prod-prod-aic-gd-cn-shanghai.oss-cn-shanghai.aliyuncs.com/image-face-fusion/OriginUrl/user/2021-09-06/e4d6ecf6-8dc8-4dac-acb5-56a737ccbc06?Expires=1630914551&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=kBcLm66y7%2FZ3eIMgwXJg1zNP7k</a>****</para>
                /// </summary>
                [NameInMap("TemplateURL")]
                [Validation(Required=false)]
                public string TemplateURL { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-09-06 15:18:15</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A06E3D21-890D-500B-97DA-D8B99D2DDDC4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
