// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetDockerhubImageRiskRankInfoRequest : TeaModel {
        /// <summary>
        /// <para>The image dimension types to be aggregated.</para>
        /// <remarks>
        /// <para>This parameter is required. You must specify at least one valid value. If no value is specified or all specified values are invalid, the API returns HTTP 400 with the error code -101.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public List<string> Types { get; set; }

    }

}
