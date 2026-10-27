// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSoarPlaybookTaskDetailRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the playbook.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/3000306.html">DescribePlaybooks</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("PlaybookId")]
        [Validation(Required=false)]
        public long? PlaybookId { get; set; }

        /// <summary>
        /// <para>The ID of the vulnerability passed when creating the policy task.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeVulList~~">DescribeVulList</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public long? RecordId { get; set; }

        /// <summary>
        /// <para>The UUID of the playbook task execution.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2627455.html">DescribeSoarRecords</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a15e37da-abe0-4d87-acd2-024e875a****</para>
        /// </summary>
        [NameInMap("RequestUuid")]
        [Validation(Required=false)]
        public string RequestUuid { get; set; }

    }

}
