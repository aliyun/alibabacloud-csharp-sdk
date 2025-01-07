// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyClearLogstoreStorageRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the request source. Set the value to <b>sas</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the Logstore that stores logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas_sls_storage</para>
        /// </summary>
        [NameInMap("UserLogStore")]
        [Validation(Required=false)]
        public string UserLogStore { get; set; }

        /// <summary>
        /// <para>The name of the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas-log-1234(uid)-cn-hangzhou</para>
        /// </summary>
        [NameInMap("UserProject")]
        [Validation(Required=false)]
        public string UserProject { get; set; }

    }

}
