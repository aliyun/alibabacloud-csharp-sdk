// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeListFaceVerifyInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>List of face verification records.</para>
        /// </summary>
        [NameInMap("FaceVerifyInfos")]
        [Validation(Required=false)]
        public List<DescribeListFaceVerifyInfosResponseBodyFaceVerifyInfos> FaceVerifyInfos { get; set; }
        public class DescribeListFaceVerifyInfosResponseBodyFaceVerifyInfos : TeaModel {
            /// <summary>
            /// <para>Business code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CLOUD_FACE</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>Name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>赵四</para>
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// <para>ID number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500382199805086199</para>
            /// </summary>
            [NameInMap("CertNo")]
            [Validation(Required=false)]
            public string CertNo { get; set; }

            /// <summary>
            /// <para>ID of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha8ff58e964152c4c4d21005fb98ecb</para>
            /// </summary>
            [NameInMap("CertifyId")]
            [Validation(Required=false)]
            public string CertifyId { get; set; }

            /// <summary>
            /// <para>Creation time of the face recognition record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-02T11:16:06Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Scene ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000010145</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public long? SceneId { get; set; }

            /// <summary>
            /// <para>Verification status:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Verification passed.</description></item>
            /// <item><description><b>2</b>: Verification failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>Number of items per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ItemsPerPage")]
        [Validation(Required=false)]
        public int? ItemsPerPage { get; set; }

        /// <summary>
        /// <para>Pagination parameter: current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>ID of the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CC27D8E-24BF-5056-B14E-9F26719C9A8D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of verifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
