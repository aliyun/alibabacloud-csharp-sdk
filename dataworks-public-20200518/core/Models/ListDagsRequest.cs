// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDagsRequest : TeaModel {
        /// <summary>
        /// The sequence number that uniquely identifies the data backfill operation. You can call the [GetDag](https://help.aliyun.com/document_detail/189753.html) operation to query the sequence number.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OpSeq")]
        [Validation(Required=false)]
        public long? OpSeq { get; set; }

        /// <summary>
        /// The environment of the workspace. Valid values: PROD and DEV. The value PROD indicates the production environment, and the value DEV indicates the development environment.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

    }

}
