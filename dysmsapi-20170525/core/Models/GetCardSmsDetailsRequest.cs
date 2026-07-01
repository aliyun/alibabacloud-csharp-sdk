// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetCardSmsDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The card SMS sending ID. When you send a card SMS by calling the <a href="https://help.aliyun.com/document_detail/434120.html">SendCardSms</a> or <a href="https://help.aliyun.com/document_detail/434119.html">SendBatchCardSms</a> operation, obtain the BizCardId field from the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456^0</para>
        /// </summary>
        [NameInMap("BizCardId")]
        [Validation(Required=false)]
        public string BizCardId { get; set; }

        /// <summary>
        /// <para>The digital SMS sending ID. When you send a card SMS by calling the <a href="https://help.aliyun.com/document_detail/434120.html">SendCardSms</a> or <a href="https://help.aliyun.com/document_detail/434119.html">SendBatchCardSms</a> operation, obtain the BizDigitalId field from the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12346^0</para>
        /// </summary>
        [NameInMap("BizDigitId")]
        [Validation(Required=false)]
        public string BizDigitId { get; set; }

        /// <summary>
        /// <para>The text SMS sending ID. When you send a card SMS by calling the <a href="https://help.aliyun.com/document_detail/434120.html">SendCardSms</a> or <a href="https://help.aliyun.com/document_detail/434119.html">SendBatchCardSms</a> operation, obtain the BizSmsId field from the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234576^0</para>
        /// </summary>
        [NameInMap("BizSmsId")]
        [Validation(Required=false)]
        public string BizSmsId { get; set; }

        /// <summary>
        /// <para>The current page number when you paginate sending records.</para>
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
        /// <para>The number of card SMS records to display on each page when you paginate sending records.</para>
        /// <para>Valid values: 1 to 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The domestic mobile phone number that received the SMS. Format: an 11-digit mobile phone number. For example, 1390000****.</para>
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
        /// <para>The card SMS sending date. Records from the last 30 days can be queried.</para>
        /// <para>Format: yyyyMMdd. For example, 20240112.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20240112</para>
        /// </summary>
        [NameInMap("SendDate")]
        [Validation(Required=false)]
        public string SendDate { get; set; }

    }

}
