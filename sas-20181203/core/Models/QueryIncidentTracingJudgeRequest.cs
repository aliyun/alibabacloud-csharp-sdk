// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryIncidentTracingJudgeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the event that you want to query.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2621307.html">DescribeCloudSiemEvents</a> operation to query the event ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d1d7a612-0dc2-413a-aa8e-9c7c88d8d12a</para>
        /// </summary>
        [NameInMap("IncidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

    }

}
