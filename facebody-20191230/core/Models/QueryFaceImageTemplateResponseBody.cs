// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class QueryFaceImageTemplateResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryFaceImageTemplateResponseBodyData Data { get; set; }
        public class QueryFaceImageTemplateResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<QueryFaceImageTemplateResponseBodyDataElements> Elements { get; set; }
            public class QueryFaceImageTemplateResponseBodyDataElements : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-01-29 10:19:05</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("FaceInfos")]
                [Validation(Required=false)]
                public List<QueryFaceImageTemplateResponseBodyDataElementsFaceInfos> FaceInfos { get; set; }
                public class QueryFaceImageTemplateResponseBodyDataElementsFaceInfos : TeaModel {
                    [NameInMap("FaceRect")]
                    [Validation(Required=false)]
                    public QueryFaceImageTemplateResponseBodyDataElementsFaceInfosFaceRect FaceRect { get; set; }
                    public class QueryFaceImageTemplateResponseBodyDataElementsFaceInfosFaceRect : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>94</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>89</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>254</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public string X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>318</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public string Y { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>6cd509ea-54fa-4730-8e9d-c94cadcda048</para>
                    /// </summary>
                    [NameInMap("TemplateFaceID")]
                    [Validation(Required=false)]
                    public string TemplateFaceID { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6cd509ea-54fa-4730-8e9d-c94cadcda048</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/MergeImageFace/MergeImageFace-1.png">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/MergeImageFace/MergeImageFace-1.png</a></para>
                /// </summary>
                [NameInMap("TemplateURL")]
                [Validation(Required=false)]
                public string TemplateURL { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-01-29 10:19:05</para>
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
        /// <para>7C29675C-751F-4D2F-86FB-2BD8D69AC860</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
