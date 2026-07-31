// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeRatePlanInstanceStatusRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call the <a href="~~ListUserRatePlanInstances~~">ListUserRatePlanInstances</a> operation to obtain the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xcdn-91fknmb80f0g***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The resource owner account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700594193617909</para>
        /// </summary>
        [NameInMap("ResourceOwner")]
        [Validation(Required=false)]
        public long? ResourceOwner { get; set; }

    }

}
