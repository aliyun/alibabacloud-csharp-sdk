// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eais20190624.Models
{
    public class DeleteEaiAllRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>i-bp1fvhi60e1zizsp****</para>
        /// </summary>
        [NameInMap("ClientInstanceId")]
        [Validation(Required=false)]
        public string ClientInstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eais-hza1ahi0uuw0re33****</para>
        /// </summary>
        [NameInMap("ElasticAcceleratedInstanceId")]
        [Validation(Required=false)]
        public string ElasticAcceleratedInstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
