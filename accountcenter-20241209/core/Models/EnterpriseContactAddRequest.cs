// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AccountCenter20241209.Models
{
    public class EnterpriseContactAddRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AsyncEmailVerify")]
        [Validation(Required=false)]
        public bool? AsyncEmailVerify { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AsyncMobileVerify")]
        [Validation(Required=false)]
        public bool? AsyncMobileVerify { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:xxx@xxx.xx">xxx@xxx.xx</a></para>
        /// </summary>
        [NameInMap("ContactEmail")]
        [Validation(Required=false)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("ContactMobile")]
        [Validation(Required=false)]
        public string ContactMobile { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ContactPosition")]
        [Validation(Required=false)]
        public string ContactPosition { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("EmailCode")]
        [Validation(Required=false)]
        public string EmailCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("MobileCode")]
        [Validation(Required=false)]
        public string MobileCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("OrientedEcId")]
        [Validation(Required=false)]
        public string OrientedEcId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("OrientedLeId")]
        [Validation(Required=false)]
        public string OrientedLeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("OrientedNbId")]
        [Validation(Required=false)]
        public string OrientedNbId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SharedContact")]
        [Validation(Required=false)]
        public bool? SharedContact { get; set; }

    }

}
