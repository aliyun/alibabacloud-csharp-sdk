// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class UpdateContactsRequest : TeaModel {
        /// <summary>
        /// <para>The email address of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:XXXX@alibaba-inc.com">XXXX@alibaba-inc.com</a></para>
        /// </summary>
        [NameInMap("ContactEmail")]
        [Validation(Required=false)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// <para>The ID of the contact to update. You can retrieve the ID by calling the ListContacts operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1194432</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public long? ContactId { get; set; }

        /// <summary>
        /// <para>The name of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <para>The mobile phone number of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192XXXXXXXX</para>
        /// </summary>
        [NameInMap("ContactPhone")]
        [Validation(Required=false)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// <para>Enables or disables email alerts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: disabled.</para>
        /// </description></item>
        /// <item><description><para>1: enabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MailStatus")]
        [Validation(Required=false)]
        public int? MailStatus { get; set; }

        /// <summary>
        /// <para>Enables or disables alerts for number status.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OpenStatusWarning")]
        [Validation(Required=false)]
        public bool? OpenStatusWarning { get; set; }

        /// <summary>
        /// <para>Enables or disables alerts for number attribution queries. Valid values: -<b>true</b>: enabled. -<b>false</b>: disabled.</para>
        /// 
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
        /// <para>Enables or disables phone call alerts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: disabled.</para>
        /// </description></item>
        /// <item><description><para>1: enabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
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
