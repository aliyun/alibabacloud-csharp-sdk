// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetUserAccessTokenForPartnerRequest : TeaModel {
        /// <summary>
        /// <para>The website domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcd.scd.wanwang.xin</para>
        /// </summary>
        [NameInMap("SiteHost")]
        [Validation(Required=false)]
        public string SiteHost { get; set; }

        /// <summary>
        /// <para>The credential used to connect to the cloud application.</para>
        /// <remarks>
        /// <para>This parameter is displayed for non-initial calls.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2f68fe1e-d9d5-4803-94d0-2fc81032e91d</para>
        /// </summary>
        [NameInMap("Ticket")]
        [Validation(Required=false)]
        public string Ticket { get; set; }

    }

}
