// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySendDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The delivery receipt ID. This is the <c>BizId</c> returned in the response when you call the <a href="https://help.aliyun.com/document_detail/419273.html">SendSms</a> or <a href="https://help.aliyun.com/document_detail/419274.html">SendBatchSms</a> operation.</para>
        /// <remarks>
        /// <para>You can specify only one <c>BizId</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>134523^435****</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The current page number for paginated results.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of delivery records to return on each page.</para>
        /// <para>Valid values: 1 to 50.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The phone number to query. The format is as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>For messages to the Chinese mainland, use an 11-digit phone number, such as 1390000\<em>\</em>\<em>\</em>.</para>
        /// </description></item>
        /// <item><description><para>For international SMS, use the format: country/region code + phone number, such as 8520000\<em>\</em>\<em>\</em>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can specify only one phone number.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1390000****</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The date when the SMS message was sent. You can query records from the past 30 days.</para>
        /// <para>Format: <b>yyyyMMdd</b>, for example, 20250601.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20250601</para>
        /// </summary>
        [NameInMap("SendDate")]
        [Validation(Required=false)]
        public string SendDate { get; set; }

    }

}
