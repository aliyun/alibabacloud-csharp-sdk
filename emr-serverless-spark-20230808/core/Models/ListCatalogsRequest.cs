// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListCatalogsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dev</para>
        /// </summary>
        [NameInMap("environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
