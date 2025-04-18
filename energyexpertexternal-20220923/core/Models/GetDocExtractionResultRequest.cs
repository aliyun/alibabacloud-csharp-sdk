// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetDocExtractionResultRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description>Task ID.</description></item>
        /// <item><description>taskId is obtained from the SubmitDocExtractionTaskAdvance and SubmitDocExtractionTask interfaces.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>97693b4c-17a8-4198-aa28-798d3c855577mhrv</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
