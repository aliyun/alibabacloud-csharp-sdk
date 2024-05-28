// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antirisk20221128.Models
{
    public class ListChannelRiskDetailsRequest : TeaModel {
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("end")]
        [Validation(Required=false)]
        public string End { get; set; }

        [NameInMap("isAllChannel")]
        [Validation(Required=false)]
        public string IsAllChannel { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public string Start { get; set; }

    }

}
