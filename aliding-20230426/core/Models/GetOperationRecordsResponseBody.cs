// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetOperationRecordsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetOperationRecordsResponseBodyResult> Result { get; set; }
        public class GetOperationRecordsResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>return</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>同意</para>
            /// </summary>
            [NameInMap("ActionExit")]
            [Validation(Required=false)]
            public string ActionExit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-02-01</para>
            /// </summary>
            [NameInMap("ActiveTimeGMT")]
            [Validation(Required=false)]
            public string ActiveTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>act-xxaanfaf</para>
            /// </summary>
            [NameInMap("ActivityId")]
            [Validation(Required=false)]
            public string ActivityId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public long? DataId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://oss.com/Signature.pdf">https://oss.com/Signature.pdf</a></para>
            /// </summary>
            [NameInMap("DigitalSign")]
            [Validation(Required=false)]
            public string DigitalSign { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://oss.com/a.pdf">https://oss.com/a.pdf</a></para>
            /// </summary>
            [NameInMap("Files")]
            [Validation(Required=false)]
            public string Files { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-01</para>
            /// </summary>
            [NameInMap("OperateTimeGMT")]
            [Validation(Required=false)]
            public string OperateTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>remove</para>
            /// </summary>
            [NameInMap("OperateType")]
            [Validation(Required=false)]
            public string OperateType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("OperatorDisplayName")]
            [Validation(Required=false)]
            public string OperatorDisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>李四</para>
            /// </summary>
            [NameInMap("OperatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>无冬</para>
            /// </summary>
            [NameInMap("OperatorNickName")]
            [Validation(Required=false)]
            public string OperatorNickName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://oss.com/a.jpeg">https://oss.com/a.jpeg</a></para>
            /// </summary>
            [NameInMap("OperatorPhotoUrl")]
            [Validation(Required=false)]
            public string OperatorPhotoUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>良好</para>
            /// </summary>
            [NameInMap("OperatorStatus")]
            [Validation(Required=false)]
            public string OperatorStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>manager123</para>
            /// </summary>
            [NameInMap("OperatorUserId")]
            [Validation(Required=false)]
            public string OperatorUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f30233fb-72e1-4af4-8cb8-c7e0ea9ee530</para>
            /// </summary>
            [NameInMap("ProcessInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>确认同意</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>请购类型</para>
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>同步</para>
            /// </summary>
            [NameInMap("TaskExecuteType")]
            [Validation(Required=false)]
            public string TaskExecuteType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-01</para>
            /// </summary>
            [NameInMap("TaskHoldTimeGMT")]
            [Validation(Required=false)]
            public long? TaskHoldTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task-123</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>append task</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i18n</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

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
