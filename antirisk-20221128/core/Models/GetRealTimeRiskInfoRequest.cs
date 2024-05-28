/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antirisk20221128.Models
{
    public class GetRealTimeRiskInfoRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("atoken")]
        [Validation(Required=false)]
        public string Atoken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        [NameInMap("extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

    }

}
