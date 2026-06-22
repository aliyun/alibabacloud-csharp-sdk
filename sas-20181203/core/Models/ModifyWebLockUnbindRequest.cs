// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyWebLockUnbindRequest : TeaModel {
        /// <summary>
        /// <para>The UUID of the server from which you want to remove the protection directories.</para>
        /// <remarks>
        /// <para>Call <a href="~~DescribeWebLockBindList~~">DescribeWebLockBindList</a> to obtain the UUID of the server.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8d217d3f-6999-43a6-a435-c7a6854180e9</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
