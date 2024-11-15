// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class IsvGetAppIdRequest : TeaModel {
        /// <summary>
        /// <para>The permission.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>whatsapp_business_messaging: sending permission on WhatsApp messages</description></item>
        /// <item><description>ads_management: management permission on advertisements</description></item>
        /// <item><description>catalog_management: management permission on catalogs</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>catalog_management</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public string Permissions { get; set; }

        /// <summary>
        /// <para>The type of the app. Valid value: WHATSAPP.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WHATSAPP</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
