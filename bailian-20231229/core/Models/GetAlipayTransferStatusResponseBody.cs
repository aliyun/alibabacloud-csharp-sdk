// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetAlipayTransferStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The tipping result data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAlipayTransferStatusResponseBodyData Data { get; set; }
        public class GetAlipayTransferStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The sub-account ID (ignored by the API).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1348393307144609</para>
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The payment details (ignored by the API).</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("alipayOrderDetail")]
            [Validation(Required=false)]
            public string AlipayOrderDetail { get; set; }

            /// <summary>
            /// <para>The Alipay order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234234</para>
            /// </summary>
            [NameInMap("alipayOrderId")]
            [Validation(Required=false)]
            public string AlipayOrderId { get; set; }

            /// <summary>
            /// <para>The code associated with the tipping.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The creator (ignored by the API).</para>
            /// 
            /// <b>Example:</b>
            /// <para>234234</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The primary account ID (ignored by the API).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1007576424487905</para>
            /// </summary>
            [NameInMap("mainAccountId")]
            [Validation(Required=false)]
            public string MainAccountId { get; set; }

            /// <summary>
            /// <para>The modifier (ignored by the API).</para>
            /// 
            /// <b>Example:</b>
            /// <para>234234</para>
            /// </summary>
            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <para>The tipping link (ignored by the API).</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.aliyun.com">https://xxx.aliyun.com</a></para>
            /// </summary>
            [NameInMap("qrURL")]
            [Validation(Required=false)]
            public string QrURL { get; set; }

            /// <summary>
            /// <para>The ownership status of the tipping application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>publish</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The tipping status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Succeeded.</description></item>
            /// <item><description>0: Deleted.</description></item>
            /// <item><description>2: Pending tipping.</description></item>
            /// <item><description>3: Canceled.</description></item>
            /// <item><description>4: Refunded.</description></item>
            /// <item><description>5: Closed.</description></item>
            /// <item><description>6: Failed.</description></item>
            /// <item><description>7: Disputed or abnormal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// <para>The transfer title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The total order amount. Unit: CNY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.22</para>
            /// </summary>
            [NameInMap("transAmount")]
            [Validation(Required=false)]
            public string TransAmount { get; set; }

            /// <summary>
            /// <para>The Alipay product wallet code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xsdfsdf</para>
            /// </summary>
            [NameInMap("walletItemCode")]
            [Validation(Required=false)]
            public string WalletItemCode { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6a71f2d9-f1c9-913b-818b-11402910xxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
