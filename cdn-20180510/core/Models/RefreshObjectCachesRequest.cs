// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class RefreshObjectCachesRequest : TeaModel {
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ObjectPath")]
        [Validation(Required=false)]
        public string ObjectPath { get; set; }

        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
