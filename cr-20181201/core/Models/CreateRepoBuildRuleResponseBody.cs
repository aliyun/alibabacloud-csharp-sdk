// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateRepoBuildRuleResponseBody : TeaModel {
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
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The call is successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The call failed.</para>
        /// </description></item>
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
        /// <para>4CE1F661-75DD-4EBD-A4AD-057B26834ABB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
