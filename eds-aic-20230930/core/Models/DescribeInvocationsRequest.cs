// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeInvocationsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the cloud phone instances. You can specify a maximum of 50 cloud phone instances.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The ID of the execution. You can retrieve the output of a command once by using either the execution ID or the cloud phone instance ID.</para>
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
