// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class SearchFormDataSecondGenerationResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<SearchFormDataSecondGenerationResponseBodyData> Data { get; set; }
        public class SearchFormDataSecondGenerationResponseBodyData : TeaModel {
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
            /// <para>1023</para>
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
            public SearchFormDataSecondGenerationResponseBodyDataModifyUser ModifyUser { get; set; }
            public class SearchFormDataSecondGenerationResponseBodyDataModifyUser : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public SearchFormDataSecondGenerationResponseBodyDataModifyUserName Name { get; set; }
                public class SearchFormDataSecondGenerationResponseBodyDataModifyUserName : TeaModel {
                    [NameInMap("NameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>English</para>
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
            public SearchFormDataSecondGenerationResponseBodyDataOriginator Originator { get; set; }
            public class SearchFormDataSecondGenerationResponseBodyDataOriginator : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public SearchFormDataSecondGenerationResponseBodyDataOriginatorName Name { get; set; }
                public class SearchFormDataSecondGenerationResponseBodyDataOriginatorName : TeaModel {
                    [NameInMap("NameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>English</para>
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
            /// <para>sagc1b3090d</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

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
