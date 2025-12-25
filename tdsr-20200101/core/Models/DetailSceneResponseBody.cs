// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class DetailSceneResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DetailSceneResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DetailSceneResponseBodyAccessDeniedDetail : TeaModel {
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        [NameInMap("Captures")]
        [Validation(Required=false)]
        public List<DetailSceneResponseBodyCaptures> Captures { get; set; }
        public class DetailSceneResponseBodyCaptures : TeaModel {
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyun.com/test1.jpg">http://www.aliyun.com/test1.jpg</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com/xxx/xxx.jpg">www.example.com/xxx/xxx.jpg</a></para>
        /// </summary>
        [NameInMap("CoverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        [NameInMap("FloorPlans")]
        [Validation(Required=false)]
        public List<DetailSceneResponseBodyFloorPlans> FloorPlans { get; set; }
        public class DetailSceneResponseBodyFloorPlans : TeaModel {
            [NameInMap("ColorMapUrl")]
            [Validation(Required=false)]
            public string ColorMapUrl { get; set; }

            [NameInMap("FloorLabel")]
            [Validation(Required=false)]
            public string FloorLabel { get; set; }

            [NameInMap("FloorName")]
            [Validation(Required=false)]
            public string FloorName { get; set; }

            [NameInMap("MiniMapUrl")]
            [Validation(Required=false)]
            public string MiniMapUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1621236933677</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1621236933677</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234***</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>d989623696ab4f87a80b8d5b0b0****</para>
        /// </summary>
        [NameInMap("PreviewToken")]
        [Validation(Required=false)]
        public string PreviewToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Published")]
        [Validation(Required=false)]
        public bool? Published { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>344794c32937474a9c59eb130936****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("SourceNum")]
        [Validation(Required=false)]
        public long? SourceNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>init</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("StatusName")]
        [Validation(Required=false)]
        public string StatusName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("SubSceneNum")]
        [Validation(Required=false)]
        public long? SubSceneNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MODEL_3D</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
