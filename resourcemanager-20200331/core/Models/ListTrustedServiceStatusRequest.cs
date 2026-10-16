// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListTrustedServiceStatusRequest : TeaModel {
        /// <summary>
        /// <para>The management account or delegated administrator account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Management account (default): Queries the list of trusted services enabled by the management account.</description></item>
        /// <item><description>Delegated administrator account: Queries the list of trusted services enabled by the delegated administrator account.</description></item>
        /// </list>
        /// <para>For more information about trusted services and delegated administrator accounts, see <a href="https://help.aliyun.com/document_detail/208133.html">Overview of trusted services</a> and <a href="https://help.aliyun.com/document_detail/208117.html">Manage delegated administrator accounts</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>177242285274****</para>
        /// </summary>
        [NameInMap("AdminAccountId")]
        [Validation(Required=false)]
        public string AdminAccountId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
