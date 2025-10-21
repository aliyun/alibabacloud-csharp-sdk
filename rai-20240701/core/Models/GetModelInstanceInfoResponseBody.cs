// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class GetModelInstanceInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>00000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>opencompass-vllm07-acc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eas-m-12345678</para>
        /// </summary>
        [NameInMap("EasServiceId")]
        [Validation(Required=false)]
        public string EasServiceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rai_content_detection_model</para>
        /// </summary>
        [NameInMap("EasServiceName")]
        [Validation(Required=false)]
        public string EasServiceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1634122349000</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        [NameInMap("HarmfulCategoryConfigInfoList")]
        [Validation(Required=false)]
        public List<GetModelInstanceInfoResponseBodyHarmfulCategoryConfigInfoList> HarmfulCategoryConfigInfoList { get; set; }
        public class GetModelInstanceInfoResponseBodyHarmfulCategoryConfigInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            [NameInMap("CategoryLabel")]
            [Validation(Required=false)]
            public string CategoryLabel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CategoryType")]
            [Validation(Required=false)]
            public int? CategoryType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InputOutputType")]
            [Validation(Required=false)]
            public int? InputOutputType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SecurityLevel")]
            [Validation(Required=false)]
            public int? SecurityLevel { get; set; }

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
        /// <para>False</para>
        /// </summary>
        [NameInMap("IsSupportImage")]
        [Validation(Required=false)]
        public bool? IsSupportImage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("IsSupportText")]
        [Validation(Required=false)]
        public bool? IsSupportText { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("ModelCallName")]
        [Validation(Required=false)]
        public string ModelCallName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ModelCategoryId")]
        [Validation(Required=false)]
        public long? ModelCategoryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ModelInstanceId")]
        [Validation(Required=false)]
        public long? ModelInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ModelSource")]
        [Validation(Required=false)]
        public int? ModelSource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MzJiMDI5MDliODc0MTlkYmI0ZDhlYmExYjczYTIyZTE3Zm********</para>
        /// </summary>
        [NameInMap("ModelToken")]
        [Validation(Required=false)]
        public string ModelToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://12345*****.cn-shanghai.aliyuncs.com/api/predict/echo">http://12345*****.cn-shanghai.aliyuncs.com/api/predict/echo</a></para>
        /// </summary>
        [NameInMap("ModelUrl")]
        [Validation(Required=false)]
        public string ModelUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://12345*****.vpc.cn-shanghai.aliyuncs.com/api/predict/demo">http://12345*****.vpc.cn-shanghai.aliyuncs.com/api/predict/demo</a></para>
        /// </summary>
        [NameInMap("ModelVpcUrl")]
        [Validation(Required=false)]
        public string ModelVpcUrl { get; set; }

        [NameInMap("PromptAttackInfoList")]
        [Validation(Required=false)]
        public List<GetModelInstanceInfoResponseBodyPromptAttackInfoList> PromptAttackInfoList { get; set; }
        public class GetModelInstanceInfoResponseBodyPromptAttackInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            [NameInMap("CategoryLabel")]
            [Validation(Required=false)]
            public string CategoryLabel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SecurityLevel")]
            [Validation(Required=false)]
            public int? SecurityLevel { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
