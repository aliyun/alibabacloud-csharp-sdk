// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySendDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the delivery receipt. The delivery receipt ID is the value of the BizId parameter that is returned when you call the SendSms or SendBatchSms operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>134523^435****</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The page number of the first page.</para>
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
        /// <para>The number of items displayed per page.</para>
        /// <para>Valid values: 1 to 50.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The mobile numbers of the recipients. Format:</para>
        /// <list type="bullet">
        /// <item><description>If you send messages in the Chinese mainland, specify an 11-digit mobile number, for example, 1390000\<em>\</em>\<em>\</em>.</description></item>
        /// <item><description>If you send messages to countries or regions outside the Chinese mainland, specify this parameter in the \<Area code>\<Mobile number> format. Example: 8520000\<em>\</em>\<em>\</em>.</description></item>
        /// </list>
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
        /// <para>The date when the message was sent. You can query messages that were sent within the last 30 days.</para>
        /// <para>Format: yyyyMMdd. Example: 20181225.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20181228</para>
        /// </summary>
        [NameInMap("SendDate")]
        [Validation(Required=false)]
        public string SendDate { get; set; }

    }

}
