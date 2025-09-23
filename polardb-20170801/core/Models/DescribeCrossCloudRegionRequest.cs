// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeCrossCloudRegionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>HuaweiCloud</para>
        /// </summary>
        [NameInMap("CloudProvider")]
        [Validation(Required=false)]
        public string CloudProvider { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-east-3</para>
        /// </summary>
        [NameInMap("CrossCloudRegionId")]
        [Validation(Required=false)]
        public string CrossCloudRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

    }

}
