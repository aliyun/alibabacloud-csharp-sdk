// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetCardSmsDetailsRequest : TeaModel {
        /// <summary>
        /// <para>Card SMS sending ID, which is the BizCardId field in the response when calling SendCardSms or SendBatchCardSms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456^0</para>
        /// </summary>
        [NameInMap("BizCardId")]
        [Validation(Required=false)]
        public string BizCardId { get; set; }

        /// <summary>
        /// <para>Digital SMS sending ID, which is the BizDigitalId field in the response when calling SendCardSms or SendBatchCardSms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12346^0</para>
        /// </summary>
        [NameInMap("BizDigitId")]
        [Validation(Required=false)]
        public string BizDigitId { get; set; }

        /// <summary>
        /// <para>Text SMS sending ID, which is the BizSmsId field in the response when calling SendCardSms or SendBatchCardSms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234576^0</para>
        /// </summary>
        [NameInMap("BizSmsId")]
        [Validation(Required=false)]
        public string BizSmsId { get; set; }

        /// <summary>
        /// <para>For paginated viewing of sending records, specify the current page number of the sending records.</para>
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
        /// <para>For paginated viewing of sending records, specify the number of card SMS records to display per page.</para>
        /// <para>The value range is 1~50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Domestic phone number that received the SMS. Format: 11-digit phone number, for example, 1390000****.</para>
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
        /// <para>Card SMS sending date, supports querying records from the last 30 days.</para>
        /// <para>Format: yyyyMMdd, for example, 20240112.</para>
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
