// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetCardSmsDetailsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123456^0</para>
        /// </summary>
        [NameInMap("BizCardId")]
        [Validation(Required=false)]
        public string BizCardId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12346^0</para>
        /// </summary>
        [NameInMap("BizDigitId")]
        [Validation(Required=false)]
        public string BizDigitId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234576^0</para>
        /// </summary>
        [NameInMap("BizSmsId")]
        [Validation(Required=false)]
        public string BizSmsId { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
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
