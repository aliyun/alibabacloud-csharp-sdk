// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ExternalUserUpdateShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2000-01-02</para>
        /// </summary>
        [NameInMap("birthday")]
        [Validation(Required=false)]
        public string Birthday { get; set; }

        [NameInMap("cert_request_list")]
        [Validation(Required=false)]
        public string CertRequestListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:zhangsan@alibaba-inc.com">zhangsan@alibaba-inc.com</a></para>
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13438009765</para>
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("real_name")]
        [Validation(Required=false)]
        public string RealName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zhang/san</para>
        /// </summary>
        [NameInMap("real_name_en")]
        [Validation(Required=false)]
        public string RealNameEn { get; set; }

    }

}
