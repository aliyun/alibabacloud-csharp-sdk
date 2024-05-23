// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20171016.Models
{
    public class CreateDrdsDBRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Encode")]
        [Validation(Required=false)]
        public string Encode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RdsInstances")]
        [Validation(Required=false)]
        public string RdsInstances { get; set; }

    }

}
