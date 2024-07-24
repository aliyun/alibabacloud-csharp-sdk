// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetCustomizationConfigListResponseBody : TeaModel {
        /// <summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-01-08</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cdae396590bb479a9ec40f3476e274fc</para>
                /// </summary>
                [NameInMap("ModeCustomizationId")]
                [Validation(Required=false)]
                public string ModeCustomizationId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public long? ModelId { get; set; }

                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ModelStatus")]
                [Validation(Required=false)]
                public int? ModelStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public int? TaskType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>106C6CA0-282D-4AF7-85F0-D2D24F4CE647</para>
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
