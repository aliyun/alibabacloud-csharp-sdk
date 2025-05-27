// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AccountCenter20241209.Models
{
    public class EnterpriseRegisterAccountRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>资方支付平台</para>
        /// </summary>
        [NameInMap("Alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        [NameInMap("EncryptPassword")]
        [Validation(Required=false)]
        public string EncryptPassword { get; set; }

        [NameInMap("EncryptTicket")]
        [Validation(Required=false)]
        public string EncryptTicket { get; set; }

        [NameInMap("LoginEmail")]
        [Validation(Required=false)]
        public string LoginEmail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>668514d8083f058f78f7199a</para>
        /// </summary>
        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("OrientedEcId")]
        [Validation(Required=false)]
        public string OrientedEcId { get; set; }

        [NameInMap("OrientedLeId")]
        [Validation(Required=false)]
        public string OrientedLeId { get; set; }

        [NameInMap("OrientedNbId")]
        [Validation(Required=false)]
        public string OrientedNbId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A93073FC-1E86-58BA-AB83-54DA6BDB4F03</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShowCompleteInfo")]
        [Validation(Required=false)]
        public bool? ShowCompleteInfo { get; set; }

        [NameInMap("SiteNick")]
        [Validation(Required=false)]
        public string SiteNick { get; set; }

    }

}
