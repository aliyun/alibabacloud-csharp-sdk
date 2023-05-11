// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetThingTemplateRequest : TeaModel {
        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("CategoryKey")]
        [Validation(Required=false)]
        public string CategoryKey { get; set; }

        /// <summary>
        /// The identifier of the category that you want to query.
        /// 
        /// You can call the [ListThingTemplates](~~150316~~) operation and view all category keys in the response.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
