// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class BatchGetFormDataByIdListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[ &quot;FINST-SASNOO39NSIFF780&quot; ]</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<BatchGetFormDataByIdListResponseBodyResult> Result { get; set; }
        public class BatchGetFormDataByIdListResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-05-01 10:10:10</para>
            /// </summary>
            [NameInMap("CreateTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>012345</para>
            /// </summary>
            [NameInMap("CreatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            [NameInMap("FormData")]
            [Validation(Required=false)]
            public Dictionary<string, object> FormData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FINST-xxxx</para>
            /// </summary>
            [NameInMap("FormInstanceId")]
            [Validation(Required=false)]
            public string FormInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FORM-xxxx</para>
            /// </summary>
            [NameInMap("FormUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>21044829126</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("InstanceValue")]
            [Validation(Required=false)]
            public string InstanceValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-05-01 10:10:10</para>
            /// </summary>
            [NameInMap("ModifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public BatchGetFormDataByIdListResponseBodyResultModifyUser ModifyUser { get; set; }
            public class BatchGetFormDataByIdListResponseBodyResultModifyUser : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public BatchGetFormDataByIdListResponseBodyResultModifyUserName Name { get; set; }
                public class BatchGetFormDataByIdListResponseBodyResultModifyUserName : TeaModel {
                    [NameInMap("NameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>EnglishName</para>
                    /// </summary>
                    [NameInMap("NameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>012345</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("Originator")]
            [Validation(Required=false)]
            public BatchGetFormDataByIdListResponseBodyResultOriginator Originator { get; set; }
            public class BatchGetFormDataByIdListResponseBodyResultOriginator : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public BatchGetFormDataByIdListResponseBodyResultOriginatorName Name { get; set; }
                public class BatchGetFormDataByIdListResponseBodyResultOriginatorName : TeaModel {
                    [NameInMap("NameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>EnglishName</para>
                    /// </summary>
                    [NameInMap("NameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>012345</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public string Sequence { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SA65776</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
