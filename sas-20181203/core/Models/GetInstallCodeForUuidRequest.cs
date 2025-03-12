// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetInstallCodeForUuidRequest : TeaModel {
        /// <summary>
        /// <para>The UUID of the server for which the client installation code is to be queried.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> API to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eae0b46e-2155-422e-9565-ecc52c69****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
