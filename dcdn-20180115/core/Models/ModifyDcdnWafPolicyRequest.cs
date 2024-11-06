// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class ModifyDcdnWafPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the protection policy that you want to modify. You can specify only one ID in each request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000001</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        /// <summary>
        /// <para>The new name of the protection policy.</para>
        /// <remarks>
        /// <para>You must specify PolicyName or PolicyStatus.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>policy_test</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The new status of the protection policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify PolicyName or PolicyStatus.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("PolicyStatus")]
        [Validation(Required=false)]
        public string PolicyStatus { get; set; }

    }

}
