// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetCustomizationConfigListResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates that the request succeeded. Other values indicate failure. Use this field to identify the cause of a failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomizationConfigListResponseBodyData Data { get; set; }
        public class GetCustomizationConfigListResponseBodyData : TeaModel {
            [NameInMap("ModelCustomizationDataSetPo")]
            [Validation(Required=false)]
            public List<GetCustomizationConfigListResponseBodyDataModelCustomizationDataSetPo> ModelCustomizationDataSetPo { get; set; }
            public class GetCustomizationConfigListResponseBodyDataModelCustomizationDataSetPo : TeaModel {
                [NameInMap("AsrVersion")]
                [Validation(Required=false)]
                public int? AsrVersion { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("ModeCustomizationId")]
                [Validation(Required=false)]
                public string ModeCustomizationId { get; set; }

                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public long? ModelId { get; set; }

                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                [NameInMap("ModelStatus")]
                [Validation(Required=false)]
                public int? ModelStatus { get; set; }

                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public int? TaskType { get; set; }

            }

        }

        /// <summary>
        /// <para>If an error occurs, this field contains error details. If the request succeeds, the value is \<c>successful\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>106C6CA0-282D-4AF7-85F0-D2D24F4CE647</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. Use this field to check the request status. A value of \<c>true\\</c> means success. A value of \<c>false\\</c> or \<c>null\\</c> means failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
