// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class BatchCreateMetaEntitiesResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9E0C8E7A-C6BE-5A73-9562-2A030A80E8C6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of entity creation results. Each entry indicates whether the creation is successful and the failure reason.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<MetaEntityWriteResult> Results { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. If some entities fail, the value is still true. Check Results[].Success and Results[].ErrorMessage for individual results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
