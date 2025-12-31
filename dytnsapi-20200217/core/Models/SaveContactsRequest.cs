// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class SaveContactsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dytns</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:1234@alibaba-inc.com">1234@alibaba-inc.com</a></para>
        /// </summary>
        [NameInMap("ContactEmail")]
        [Validation(Required=false)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>122354532434</para>
        /// </summary>
        [NameInMap("ContactPhone")]
        [Validation(Required=false)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MailStatus")]
        [Validation(Required=false)]
        public int? MailStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OpenStatusWarning")]
        [Validation(Required=false)]
        public bool? OpenStatusWarning { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OpentAttributionWarning")]
        [Validation(Required=false)]
        public bool? OpentAttributionWarning { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PhoneStatus")]
        [Validation(Required=false)]
        public int? PhoneStatus { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
