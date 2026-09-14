// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetComputeResourceAuthUserMappingsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the compute resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000</para>
        /// </summary>
        [NameInMap("ComputeResourceId")]
        [Validation(Required=false)]
        public long? ComputeResourceId { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace to which the data source belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
