// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetCorpTasksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{}]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetCorpTasksResponseBodyData> Data { get; set; }
        public class GetCorpTasksResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-01-01</para>
            /// </summary>
            [NameInMap("ActiveTimeGMT")]
            [Validation(Required=false)]
            public string ActiveTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("ActualActionerId")]
            [Validation(Required=false)]
            public string ActualActionerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>APP_XCxxx</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-01-01</para>
            /// </summary>
            [NameInMap("CreateTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-01-01</para>
            /// </summary>
            [NameInMap("FinishTimeGMT")]
            [Validation(Required=false)]
            public string FinishTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:123456@li.com">123456@li.com</a></para>
            /// </summary>
            [NameInMap("OriginatorEmail")]
            [Validation(Required=false)]
            public string OriginatorEmail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("OriginatorId")]
            [Validation(Required=false)]
            public string OriginatorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>名称</para>
            /// </summary>
            [NameInMap("OriginatorName")]
            [Validation(Required=false)]
            public string OriginatorName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("OriginatorNameInEnglish")]
            [Validation(Required=false)]
            public string OriginatorNameInEnglish { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>昵称</para>
            /// </summary>
            [NameInMap("OriginatorNickName")]
            [Validation(Required=false)]
            public string OriginatorNickName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>nick en</para>
            /// </summary>
            [NameInMap("OriginatorNickNameEn")]
            [Validation(Required=false)]
            public string OriginatorNickNameEn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>english nick</para>
            /// </summary>
            [NameInMap("OriginatorNickNameInEnglish")]
            [Validation(Required=false)]
            public string OriginatorNickNameInEnglish { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>originatorPhotoexample</para>
            /// </summary>
            [NameInMap("OriginatorPhoto")]
            [Validation(Required=false)]
            public string OriginatorPhoto { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>agree</para>
            /// </summary>
            [NameInMap("OutResult")]
            [Validation(Required=false)]
            public string OutResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>结果名称</para>
            /// </summary>
            [NameInMap("OutResultName")]
            [Validation(Required=false)]
            public string OutResultName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>instancexxxx</para>
            /// </summary>
            [NameInMap("ProcessInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>taskId</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>标题</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>title</para>
            /// </summary>
            [NameInMap("TitleInEnglish")]
            [Validation(Required=false)]
            public string TitleInEnglish { get; set; }

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
        /// <para>10</para>
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
