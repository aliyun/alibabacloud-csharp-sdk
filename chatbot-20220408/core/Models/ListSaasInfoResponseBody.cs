// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListSaasInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of SaaS integrations.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSaasInfoResponseBodyData> Data { get; set; }
        public class ListSaasInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the SaaS atomic page. Use this code to reference the page and query its information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GLOBAL_SERVICE</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The English name of the atomic page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GLOBAL SERVICE</para>
            /// </summary>
            [NameInMap("EnName")]
            [Validation(Required=false)]
            public string EnName { get; set; }

            /// <summary>
            /// <para>The Chinese name of the atomic page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>全局服务</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The URL to embed the SaaS page in an iframe.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://pre-alime4service.console.aliyun.com/?productCode=p_beebot_public&switchAgent=1204001&saasCode=Robot&saasToken=06614fdb-c72f-436e-8003-dfe8a2854a15&saasName=123#/robot">https://pre-alime4service.console.aliyun.com/?productCode=p_beebot_public&amp;switchAgent=1204001&amp;saasCode=Robot&amp;saasToken=06614fdb-c72f-436e-8003-dfe8a2854a15&amp;saasName=123#/robot</a></para>
            /// </summary>
            [NameInMap("ServiceUrl")]
            [Validation(Required=false)]
            public string ServiceUrl { get; set; }

            /// <summary>
            /// <para>The URL of the atomic page.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://alime.console.aliyun.com/?productCode=p_beebot_public&switchAgent=1204001&saasCode=Robot&saasToken=06614fdb-c72f-436e-8003-dfe8a2854a15&saasName=123#/robot">https://alime.console.aliyun.com/?productCode=p_beebot_public&amp;switchAgent=1204001&amp;saasCode=Robot&amp;saasToken=06614fdb-c72f-436e-8003-dfe8a2854a15&amp;saasName=123#/robot</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A629A28F-F25E-5572-A679-FA46FB0151D6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The SaaS integration token issued by Chatbot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06614fdb-c72f-436e-8003-dfe8a2854a15</para>
        /// </summary>
        [NameInMap("SaasToken")]
        [Validation(Required=false)]
        public string SaasToken { get; set; }

    }

}
