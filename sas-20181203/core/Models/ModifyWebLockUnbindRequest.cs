// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyWebLockUnbindRequest : TeaModel {
        /// <summary>
        /// <para>The UUID of the server for which you want to disable web tamper proofing.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeWebLockBindList~~">DescribeWebLockBindList</a> operation to query the UUIDs of servers.</para>
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
