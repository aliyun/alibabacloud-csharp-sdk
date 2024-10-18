// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetTaskCopiesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{}]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetTaskCopiesResponseBodyData> Data { get; set; }
        public class GetTaskCopiesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>[ &quot;actxxx&quot; ]</para>
            /// </summary>
            [NameInMap("ActionExecutorId")]
            [Validation(Required=false)]
            public List<string> ActionExecutorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[ &quot;name&quot; ]</para>
            /// </summary>
            [NameInMap("ActionExecutorName")]
            [Validation(Required=false)]
            public List<string> ActionExecutorName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>APP_XCxxx</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>g02fbs08xxx</para>
            /// </summary>
            [NameInMap("CarbonActivityId")]
            [Validation(Required=false)]
            public string CarbonActivityId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-01-01</para>
            /// </summary>
            [NameInMap("CreateTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("CurrentActivityInstances")]
            [Validation(Required=false)]
            public List<GetTaskCopiesResponseBodyDataCurrentActivityInstances> CurrentActivityInstances { get; set; }
            public class GetTaskCopiesResponseBodyDataCurrentActivityInstances : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>act-xxaanfaf</para>
                /// </summary>
                [NameInMap("ActivityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("ActivityInstanceStatus")]
                [Validation(Required=false)]
                public string ActivityInstanceStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>act-12345</para>
                /// </summary>
                [NameInMap("ActivityName")]
                [Validation(Required=false)]
                public string ActivityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>redirect task</para>
                /// </summary>
                [NameInMap("ActivityNameInEnglish")]
                [Validation(Required=false)]
                public string ActivityNameInEnglish { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("DataMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> DataMap { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>edit</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-01-01</para>
            /// </summary>
            [NameInMap("FinishTimeGMT")]
            [Validation(Required=false)]
            public string FinishTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>formxxxx</para>
            /// </summary>
            [NameInMap("FormInstanceId")]
            [Validation(Required=false)]
            public string FormInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>uuid</para>
            /// </summary>
            [NameInMap("FormUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("InstanceValue")]
            [Validation(Required=false)]
            public string InstanceValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-01-01</para>
            /// </summary>
            [NameInMap("ModifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>guyagsd</para>
            /// </summary>
            [NameInMap("OriginatorAvatar")]
            [Validation(Required=false)]
            public string OriginatorAvatar { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>guyagsd</para>
            /// </summary>
            [NameInMap("OriginatorDisplayName")]
            [Validation(Required=false)]
            public string OriginatorDisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("OriginatorId")]
            [Validation(Required=false)]
            public string OriginatorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>同意</para>
            /// </summary>
            [NameInMap("ProcessApprovedResult")]
            [Validation(Required=false)]
            public string ProcessApprovedResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>同意</para>
            /// </summary>
            [NameInMap("ProcessApprovedResultText")]
            [Validation(Required=false)]
            public string ProcessApprovedResultText { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>code</para>
            /// </summary>
            [NameInMap("ProcessCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>processxxxx</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public long? ProcessId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>instancexxxx</para>
            /// </summary>
            [NameInMap("ProcessInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>同意</para>
            /// </summary>
            [NameInMap("ProcessInstanceStatus")]
            [Validation(Required=false)]
            public string ProcessInstanceStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>同意</para>
            /// </summary>
            [NameInMap("ProcessInstanceStatusText")]
            [Validation(Required=false)]
            public string ProcessInstanceStatusText { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>名称</para>
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>标题</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0</para>
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
