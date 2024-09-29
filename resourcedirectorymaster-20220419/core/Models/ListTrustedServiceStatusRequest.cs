// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class ListTrustedServiceStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the management account or delegated administrator account.</para>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to the ID of a management account, the trusted services that are enabled within the management account are queried. The default value of this parameter is the ID of an management account.</description></item>
        /// <item><description>If you set this parameter to the ID of a delegated administrator account, the trusted services that are enabled within the delegated administrator account are queried.</description></item>
        /// </list>
        /// <para>For more information about trusted services and delegated administrator accounts, see <a href="https://help.aliyun.com/document_detail/208133.html">Overview of trusted services</a> and <a href="https://help.aliyun.com/document_detail/208117.html">Delegated administrator accounts</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>177242285274****</para>
        /// </summary>
        [NameInMap("AdminAccountId")]
        [Validation(Required=false)]
        public string AdminAccountId { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
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
