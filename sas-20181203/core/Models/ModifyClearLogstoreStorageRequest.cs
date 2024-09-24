// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyClearLogstoreStorageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sas_sls_storage</para>
        /// </summary>
        [NameInMap("UserLogStore")]
        [Validation(Required=false)]
        public string UserLogStore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sas-log-1234(uid)-cn-hangzhou</para>
        /// </summary>
        [NameInMap("UserProject")]
        [Validation(Required=false)]
        public string UserProject { get; set; }

    }

}
