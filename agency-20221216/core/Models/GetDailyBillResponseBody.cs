// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetDailyBillResponseBody : TeaModel {
        /// <summary>
        /// <para>Result Code:</para>
        /// <list type="bullet">
        /// <item><description>200 OK</description></item>
        /// <item><description>1109 System error</description></item>
        /// <item><description>3050 Bill Type can only be DailyOrder, DailyBill or DailyInstanceBill.</description></item>
        /// <item><description>3049 Incorrect format of Spending Time.</description></item>
        /// <item><description>3048 Bill Owner can only be 1 or 2.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDailyBillResponseBodyData Data { get; set; }
        public class GetDailyBillResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The link to download CSV file, please use HTTP Protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>intl-reseller-month-bill.oss-ap-southeast-1.aliyuncs.com/statements/month/dts/1064252248461886/202104/Month%20Billing%20Invoice%20202104.pdf?Expires=1671160973&amp;OSSAccessKeyId=TMP.3KhvoD9pW264cPv8sYe8E2zJ5HLWmrijNHgKiKpXcy8yS472BcrvemgTfNrrXKu5fCCdbLr2XhmYAyYPmbCe8zJyEkmYzL&amp;Signature=hns1PgiiYl1WdI%2FdiOqbEdsgmfI%3D</para>
            /// </summary>
            [NameInMap("BillLinkCSV")]
            [Validation(Required=false)]
            public string BillLinkCSV { get; set; }

            /// <summary>
            /// <para>The link to download XLSX file, please use HTTP Protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>intl-reseller-month-bill.oss-ap-southeast-1.aliyuncs.com/statements/month/dts/1064252248461886/202104/Month%20Billing%20Invoice%20202104.pdf?Expires=1671160973&amp;OSSAccessKeyId=TMP.3KhvoD9pW264cPv8sYe8E2zJ5HLWmrijNHgKiKpXcy8yS472BcrvemgTfNrrXKu5fCCdbLr2XhmYAyYPmbCe8zJyEkmYzL&amp;Signature=hns1PgiiYl1WdI%2FdiOqbEdsgmfI%3D</para>
            /// </summary>
            [NameInMap("BillLinkXLSX")]
            [Validation(Required=false)]
            public string BillLinkXLSX { get; set; }

            /// <summary>
            /// <para>Same as inserted parameter BillOwner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BillOwner")]
            [Validation(Required=false)]
            public string BillOwner { get; set; }

            /// <summary>
            /// <para>Same as inserted parameter BillType.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DailyInstanceBillV2</para>
            /// </summary>
            [NameInMap("BillType")]
            [Validation(Required=false)]
            public string BillType { get; set; }

            /// <summary>
            /// <para>Spending Time, refer to the exact time of costuming.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20221201</para>
            /// </summary>
            [NameInMap("SpendingTime")]
            [Validation(Required=false)]
            public string SpendingTime { get; set; }

        }

        /// <summary>
        /// <para>Same as Code parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID, the unique request identifier generated by Alibaba Cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Candidate Value: True/False, which indicates whether the current API call itself is successful. It does not guarantee the success of subsequent business operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
