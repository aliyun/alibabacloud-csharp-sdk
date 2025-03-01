// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeRatePlanInstanceStatusRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID, obtained from the <a href="~~ListUserRatePlanInstances~~">ListUserRatePlanInstances</a> API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xcdn-91fknmb80f0g***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
