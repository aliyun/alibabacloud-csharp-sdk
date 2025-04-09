// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class GetAnnotationMissionTagInfoListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAnnotationMissionTagInfoListResponseBodyData Data { get; set; }
        public class GetAnnotationMissionTagInfoListResponseBodyData : TeaModel {
            [NameInMap("AnnotationMissionTagInfoList")]
            [Validation(Required=false)]
            public List<GetAnnotationMissionTagInfoListResponseBodyDataAnnotationMissionTagInfoList> AnnotationMissionTagInfoList { get; set; }
            public class GetAnnotationMissionTagInfoListResponseBodyDataAnnotationMissionTagInfoList : TeaModel {
                [NameInMap("AnnotationMissionTagInfoDescription")]
                [Validation(Required=false)]
                public string AnnotationMissionTagInfoDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>e1ee87ea-ebad-4079-aebb-1c56a4ef0c06</para>
                /// </summary>
                [NameInMap("AnnotationMissionTagInfoId")]
                [Validation(Required=false)]
                public string AnnotationMissionTagInfoId { get; set; }

                [NameInMap("AnnotationMissionTagInfoName")]
                [Validation(Required=false)]
                public string AnnotationMissionTagInfoName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Delete")]
                [Validation(Required=false)]
                public bool? Delete { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3c3b8d1d-deff-48d9-9318-addc80ae5b1e</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DING_ORG_dingbd9daecdb7aaed3bffe93478753d9884</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CDR \&quot;job-efbaeefc-4d45-4e79-83f7-b33b0769c969\&quot; doesn\&quot;t exists.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CDR \&quot;job-efbaeefc-4d45-4e79-83f7-b33b0769c969\&quot; doesn\&quot;t exists.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
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
