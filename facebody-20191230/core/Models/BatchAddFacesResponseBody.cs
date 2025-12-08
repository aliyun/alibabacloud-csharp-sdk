// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class BatchAddFacesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchAddFacesResponseBodyData Data { get; set; }
        public class BatchAddFacesResponseBodyData : TeaModel {
            [NameInMap("FailedFaces")]
            [Validation(Required=false)]
            public List<BatchAddFacesResponseBodyDataFailedFaces> FailedFaces { get; set; }
            public class BatchAddFacesResponseBodyDataFailedFaces : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ClientError.IllegalArgument</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://viapi-test.oss-cn-shanghai.aliyuncs.com/test/imgsearch/demo/xxxx.png">https://viapi-test.oss-cn-shanghai.aliyuncs.com/test/imgsearch/demo/xxxx.png</a></para>
                /// </summary>
                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>not found the db=test</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            [NameInMap("InsertedFaces")]
            [Validation(Required=false)]
            public List<BatchAddFacesResponseBodyDataInsertedFaces> InsertedFaces { get; set; }
            public class BatchAddFacesResponseBodyDataInsertedFaces : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>16350536</para>
                /// </summary>
                [NameInMap("FaceId")]
                [Validation(Required=false)]
                public string FaceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://viapi-test.oss-cn-shanghai.aliyuncs.com/test/imgsearch/demo/xxxx.png">https://viapi-test.oss-cn-shanghai.aliyuncs.com/test/imgsearch/demo/xxxx.png</a></para>
                /// </summary>
                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>99.79581</para>
                /// </summary>
                [NameInMap("QualitieScore")]
                [Validation(Required=false)]
                public float? QualitieScore { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C46A46D0-3263-181A-A1EE-0901E4595390</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
