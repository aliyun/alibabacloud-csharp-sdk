// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListTenantConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The user configuration information.</para>
        /// </summary>
        [NameInMap("TenantConfigModel")]
        [Validation(Required=false)]
        public ListTenantConfigResponseBodyTenantConfigModel TenantConfigModel { get; set; }
        public class ListTenantConfigResponseBodyTenantConfigModel : TeaModel {
            /// <summary>
            /// <para>Indicates whether resource expiration reminders are enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AppInstanceGroupExpireRemind")]
            [Validation(Required=false)]
            public bool? AppInstanceGroupExpireRemind { get; set; }

        }

    }

}
