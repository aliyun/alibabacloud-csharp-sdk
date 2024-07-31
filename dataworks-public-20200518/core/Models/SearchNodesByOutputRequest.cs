// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class SearchNodesByOutputRequest : TeaModel {
        /// <summary>
        /// The output names of the node. If you specify multiple output names, separate them with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public string Outputs { get; set; }

        /// <summary>
        /// The environment of Operation Center. Valid values: PROD and DEV.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

    }

}
