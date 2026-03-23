// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeImportTaskValidationResponseBody : TeaModel {
        /// <summary>
        /// <para>Job details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ValidateAction&quot;: &quot;Detail&quot;}</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>3E36DB6E-AE3B-53B6-A703-85F883FD1B2C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Job status. The parameter is invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. The values have the following meanings:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Succeeded</description></item>
        /// <item><description><b>false</b>: Failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
