// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteCheckPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Array of policies to delete</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PolicyIds")]
        [Validation(Required=false)]
        public List<long?> PolicyIds { get; set; }

        /// <summary>
        /// <para>Policy type for custom check rule:</para>
        /// <list type="bullet">
        /// <item><description><b>STANDARD</b>: Standard-level policy</description></item>
        /// <item><description><b>REQUIREMENT</b>: Requirement-level policy</description></item>
        /// <item><description><b>SECTION</b>: Section-level policy</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

    }

}
