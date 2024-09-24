// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyWebLockRefreshRequest : TeaModel {
        /// <summary>
        /// <para>The UUID of the server for which you want to refresh the status of the web tamper proofing feature.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeWebLockBindList~~">DescribeWebLockBindList</a> operation to query the servers for which the web tamper proofing feature is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>55c0f41b-3093-47a7-8eae-02d3a584****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
