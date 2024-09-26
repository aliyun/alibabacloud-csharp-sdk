// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListSaasInfoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSaasInfoResponseBodyData> Data { get; set; }
        public class ListSaasInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>GLOBAL_SERVICE</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GLOBAL SERVICE</para>
            /// </summary>
            [NameInMap("EnName")]
            [Validation(Required=false)]
            public string EnName { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://pre-alime4service.console.aliyun.com/?productCode=p_beebot_public&switchAgent=1204001&saasCode=Robot&saasToken=06614fdb-c72f-436e-8003-dfe8a2854a15&saasName=123#/robot">https://pre-alime4service.console.aliyun.com/?productCode=p_beebot_public&amp;switchAgent=1204001&amp;saasCode=Robot&amp;saasToken=06614fdb-c72f-436e-8003-dfe8a2854a15&amp;saasName=123#/robot</a></para>
            /// </summary>
            [NameInMap("ServiceUrl")]
            [Validation(Required=false)]
            public string ServiceUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://alime.console.aliyun.com/?productCode=p_beebot_public&switchAgent=1204001&saasCode=Robot&saasToken=06614fdb-c72f-436e-8003-dfe8a2854a15&saasName=123#/robot">https://alime.console.aliyun.com/?productCode=p_beebot_public&amp;switchAgent=1204001&amp;saasCode=Robot&amp;saasToken=06614fdb-c72f-436e-8003-dfe8a2854a15&amp;saasName=123#/robot</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A629A28F-F25E-5572-A679-FA46FB0151D6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>06614fdb-c72f-436e-8003-dfe8a2854a15</para>
        /// </summary>
        [NameInMap("SaasToken")]
        [Validation(Required=false)]
        public string SaasToken { get; set; }

    }

}
