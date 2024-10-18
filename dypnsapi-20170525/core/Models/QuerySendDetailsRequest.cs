// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class QuerySendDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the business, which is provided by Alibaba Cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1231891289318923^12</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The number of the page on which you are reading the text message. Pages start from page 1. The value of this parameter cannot exceed the maximum page number.</para>
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
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>186****9399</para>
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
        /// <para>The date when the text message was sent. You can query text messages that were sent within the last 30 days.</para>
        /// <para>Specify the date in the yyyyMMdd format. Example: 20181225.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20181225</para>
        /// </summary>
        [NameInMap("SendDate")]
        [Validation(Required=false)]
        public string SendDate { get; set; }

    }

}
