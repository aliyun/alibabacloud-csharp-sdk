// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListNodesByOutputRequest : TeaModel {
        /// <summary>
        /// The output name of the node. You can specify multiple output names. In this case, separate them with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public string Outputs { get; set; }

        /// <summary>
        /// The environment type. Valid values: PROD and DEV. The value PROD indicates the production environment. The value DEV indicates the development environment.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

    }

}
