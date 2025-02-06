// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LinkFace20180720.Models
{
    public class QueryFaceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryFaceResponseBodyData Data { get; set; }
        public class QueryFaceResponseBodyData : TeaModel {
            [NameInMap("GroupIds")]
            [Validation(Required=false)]
            public List<string> GroupIds { get; set; }

            [NameInMap("UserFaceMetas")]
            [Validation(Required=false)]
            public List<QueryFaceResponseBodyDataUserFaceMetas> UserFaceMetas { get; set; }
            public class QueryFaceResponseBodyDataUserFaceMetas : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>“”</para>
                /// </summary>
                [NameInMap("ClientTag")]
                [Validation(Required=false)]
                public string ClientTag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://linkface-test.oss-cn-shanghai.aliyuncs.com/4B79F609E129C592CDD2C36FE090864A.jpg?Expires=1531389394&OSSAccessKeyId=LTAIOK0Fpx51OQDq&Signature=Dl4RikFib3FPA7gj6ZP0x">http://linkface-test.oss-cn-shanghai.aliyuncs.com/4B79F609E129C592CDD2C36FE090864A.jpg?Expires=1531389394&amp;OSSAccessKeyId=LTAIOK0Fpx51OQDq&amp;Signature=Dl4RikFib3FPA7gj6ZP0x</a></para>
                /// </summary>
                [NameInMap("FaceUrl")]
                [Validation(Required=false)]
                public string FaceUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("UserInfo")]
                [Validation(Required=false)]
                public string UserInfo { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2DDC7526-5F3F-4002-B4C4-DBC118BE6DC5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
