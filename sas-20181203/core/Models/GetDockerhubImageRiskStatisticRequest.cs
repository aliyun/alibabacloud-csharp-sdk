// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetDockerhubImageRiskStatisticRequest : TeaModel {
        /// <summary>
        /// <para>The image risk types to query. This parameter is required. You must specify at least one valid value. If this parameter is not specified or all specified values are invalid, the API returns HTTP 400 and the error code -101.</para>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public List<string> Types { get; set; }

    }

}
