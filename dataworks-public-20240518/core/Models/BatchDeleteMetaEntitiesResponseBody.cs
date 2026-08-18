// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class BatchDeleteMetaEntitiesResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1FC02D76-4A94-5D97-B52C-00A031B95359</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of entity deletion results, which returns the success status and failure reason for each entity.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<MetaEntityWriteResult> Results { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. When some entities fail, this field still returns true. Check Results[].Success and Results[].ErrorMessage for individual results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
