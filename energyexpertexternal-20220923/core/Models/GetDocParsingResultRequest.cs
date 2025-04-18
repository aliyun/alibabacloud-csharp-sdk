// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetDocParsingResultRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description>The document parsing result supports two formats: markdown and json.</description></item>
        /// <item><description>By default, the result is returned in markdown format.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>md</para>
        /// </summary>
        [NameInMap("returnFormat")]
        [Validation(Required=false)]
        public string ReturnFormat { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Task ID.</description></item>
        /// <item><description>The taskId is obtained from the SubmitDocParsingTaskAdvance or SubmitDocParsingTask interfaces.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2c22388d-e2ed-44fe-99e6-99922f15e7bb</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
