// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class SearchFormDatasResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<SearchFormDatasResponseBodyData> Data { get; set; }
        public class SearchFormDatasResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-01-24 11:22:01</para>
            /// </summary>
            [NameInMap("CreatedTimeGMT")]
            [Validation(Required=false)]
            public string CreatedTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>012345</para>
            /// </summary>
            [NameInMap("CreatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1002</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public long? DataId { get; set; }

            [NameInMap("FormData")]
            [Validation(Required=false)]
            public Dictionary<string, object> FormData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FINST-BNKJDRF</para>
            /// </summary>
            [NameInMap("FormInstanceId")]
            [Validation(Required=false)]
            public string FormInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FORM-EF6Y93URN24F1SCX15VA2P918LPEIJ2H3UFORCJ1</para>
            /// </summary>
            [NameInMap("FormUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("InstanceValue")]
            [Validation(Required=false)]
            public string InstanceValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FORM-EF6Y93URN24F1SCX15VA2P918LPEIJ2H3UFORCJ1</para>
            /// </summary>
            [NameInMap("ModelUuid")]
            [Validation(Required=false)]
            public string ModelUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-01-24 11:22:01</para>
            /// </summary>
            [NameInMap("ModifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>012345</para>
            /// </summary>
            [NameInMap("ModifierUserId")]
            [Validation(Required=false)]
            public string ModifierUserId { get; set; }

            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public SearchFormDatasResponseBodyDataModifyUser ModifyUser { get; set; }
            public class SearchFormDatasResponseBodyDataModifyUser : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>012345</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public SearchFormDatasResponseBodyDataModifyUserUserName UserName { get; set; }
                public class SearchFormDatasResponseBodyDataModifyUserUserName : TeaModel {
                    [NameInMap("NameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>EngilishName</para>
                    /// </summary>
                    [NameInMap("NameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ZH-CN</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("Originator")]
            [Validation(Required=false)]
            public SearchFormDatasResponseBodyDataOriginator Originator { get; set; }
            public class SearchFormDatasResponseBodyDataOriginator : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>012345</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public SearchFormDatasResponseBodyDataOriginatorUserName UserName { get; set; }
                public class SearchFormDatasResponseBodyDataOriginatorUserName : TeaModel {
                    [NameInMap("NameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>EngilishName</para>
                    /// </summary>
                    [NameInMap("NameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ZH-CN</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

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
            /// <para>231008101012015353</para>
            /// </summary>
            [NameInMap("SerialNo")]
            [Validation(Required=false)]
            public string SerialNo { get; set; }

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
        public int? TotalCount { get; set; }

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
