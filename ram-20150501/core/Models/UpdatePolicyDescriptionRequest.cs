// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class UpdatePolicyDescriptionRequest : TeaModel {
        /// <summary>
        /// <para>The description of the policy.</para>
        /// <para>The value of the parameter must be 1 to 1,024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test policy.</para>
        /// </summary>
        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        /// <summary>
        /// <para>The name of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestPolicy</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

    }

}
