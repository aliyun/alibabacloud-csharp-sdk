// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteMediaInfosRequest : TeaModel {
        /// <summary>
        /// ICE 媒资ID
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

        /// <summary>
        /// 待注册的媒资在相应系统中的地址
        /// </summary>
        [NameInMap("InputURLs")]
        [Validation(Required=false)]
        public string InputURLs { get; set; }

    }

}
