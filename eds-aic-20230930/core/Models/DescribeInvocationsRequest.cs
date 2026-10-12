// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeInvocationsRequest : TeaModel {
        /// <summary>
        /// <para>The list of cloud phone instance IDs. You can query the execution results of up to 50 instances in a single request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The command execution ID. You can use this ID and the cloud phone instance ID to query the result of a command execution.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-4e98eeb5****</para>
        /// </summary>
        [NameInMap("InvocationId")]
        [Validation(Required=false)]
        public string InvocationId { get; set; }

    }

}
