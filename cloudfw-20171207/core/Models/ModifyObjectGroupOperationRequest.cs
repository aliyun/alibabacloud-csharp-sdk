// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyObjectGroupOperationRequest : TeaModel {
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ObjectList")]
        [Validation(Required=false)]
        public List<string> ObjectList { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ObjectOperation")]
        [Validation(Required=false)]
        public string ObjectOperation { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
