// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyControlPolicyPriorityRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the access control policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3770d603-3534-4878-b845-f00095ee****</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// <para>The priority of the access control policy. Valid values: 1 to the number of policies in the same direction and of the same IP version. You can call DescribeControlPolicy to query the number of policies in the same direction and determine the valid upper limit. If the value exceeds the range, the ErrorParametersNewOrder (-200119) error is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

    }

}
