// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class QueryGateVerifyBillingPublicResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If OK is returned, the request is successful.</description></item>
        /// <item><description>For more information about other error codes, see <a href="https://help.aliyun.com/document_detail/85198.html">API response codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The billing information about each verification service.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryGateVerifyBillingPublicResponseBodyData Data { get; set; }
        public class QueryGateVerifyBillingPublicResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The fees generated for all verification services. Unitrogen: CNY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("AmountSum")]
            [Validation(Required=false)]
            public string AmountSum { get; set; }

            /// <summary>
            /// <para>The details of fees.</para>
            /// </summary>
            [NameInMap("SceneBillingList")]
            [Validation(Required=false)]
            public List<QueryGateVerifyBillingPublicResponseBodyDataSceneBillingList> SceneBillingList { get; set; }
            public class QueryGateVerifyBillingPublicResponseBodyDataSceneBillingList : TeaModel {
                /// <summary>
                /// <para>The billable items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>74</para>
                /// </summary>
                [NameInMap("Add")]
                [Validation(Required=false)]
                public string Add { get; set; }

                /// <summary>
                /// <para>The fees generated for the verification service. Unitrogen: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.48</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Aliyun</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The verification method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Verification of local phone number</para>
                /// </summary>
                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                /// <summary>
                /// <para>The service code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FC100000038194004</para>
                /// </summary>
                [NameInMap("SceneCode")]
                [Validation(Required=false)]
                public string SceneCode { get; set; }

                /// <summary>
                /// <para>The service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud Communications</para>
                /// </summary>
                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

                /// <summary>
                /// <para>The unit price. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.02</para>
                /// </summary>
                [NameInMap("SinglePrice")]
                [Validation(Required=false)]
                public string SinglePrice { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
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
        /// <para>8906582E-6722</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
