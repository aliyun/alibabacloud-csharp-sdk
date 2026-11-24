// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class UpdateRepoBuildRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The build rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crbr-ly77w5i3t31f****</para>
        /// </summary>
        [NameInMap("BuildRuleId")]
        [Validation(Required=false)]
        public string BuildRuleId { get; set; }

        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Specifies whether the contact is updated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The update is successful.</description></item>
        /// <item><description><c>false</c>: The update failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC648259-91A7-4502-BED3-EDF64361FA83</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
