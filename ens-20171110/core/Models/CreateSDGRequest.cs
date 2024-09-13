// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateSDGRequest : TeaModel {
        /// <summary>
        /// The description of the SDG.
        /// 
        /// >  We recommend that you specify this parameter in details for subsequent queries.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the SDG from which you want to create an SDG.
        /// 
        /// > 
        /// 
        /// *   The first time you create an SDG, the **FromSDGId** parameter is empty.
        /// 
        /// *   If the value of the **FromSDGId** parameter is invalid or does not correspond to an original disk, an error is reported.
        /// 
        /// *   If the value of the **FromSDGId** parameter is not empty, you have created an SDG, and the operation is performed on the existing SDG.
        /// </summary>
        [NameInMap("FromSDGId")]
        [Validation(Required=false)]
        public string FromSDGId { get; set; }

        /// <summary>
        /// The ID of the AIC instance. You can call the [DescribeARMServerInstances](~~DescribeARMServerInstances~~) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The maximum capacity of the SDG. Unit: GB.
        /// 
        /// > 
        /// 
        /// *   To save costs, we recommend that you specify this parameter based on your business requirements.
        /// 
        /// *   The first time that you create an SDG, the **Size** parameter is required.
        /// 
        /// *   When the amount of data increases, you can pass a new **Size** parameter for resizing. If the value of the new **Size** parameter is greater than the value of the old **Size** parameter, the disk size of the SDG is increased to the size that is specified by the new **Size** parameter. If the value of the new **Size** parameter is empty or smaller than that of the old **Size** parameter, no operation is performed.
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public string Size { get; set; }

    }

}
