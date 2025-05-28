// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class DeleteReportDefinitionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123</para>
        /// </summary>
        [NameInMap("ReportTaskId")]
        [Validation(Required=false)]
        public long? ReportTaskId { get; set; }

    }

}
