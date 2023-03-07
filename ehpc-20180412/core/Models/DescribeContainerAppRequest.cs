// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeContainerAppRequest : TeaModel {
        /// <summary>
        /// The ID of the containerized application.
        /// 
        /// You can call the [ListContainerApps](~~87333~~) operation to query the ID of the containerized application.
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

    }

}
