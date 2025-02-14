// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSoarPlaybookTaskDetailRequest : TeaModel {
        /// <summary>
        /// <para>Playbook ID.</para>
        /// <remarks>
        /// <para>You can obtain this parameter by calling the <a href="https://help.aliyun.com/document_detail/2627461.html">DescribePlaybooks</a> interface.</para>
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
        /// <para>The vulnerability ID passed when creating the policy task.</para>
        /// <remarks>
        /// <para>You can obtain this parameter by calling the <a href="~~DescribeVulList~~">DescribeVulList</a> interface.</para>
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
        /// <para>UUID of the playbook task execution.</para>
        /// <remarks>
        /// <para>You can obtain this parameter by calling the <a href="https://help.aliyun.com/document_detail/2627455.html">DescribeSoarRecords</a> interface.</para>
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
