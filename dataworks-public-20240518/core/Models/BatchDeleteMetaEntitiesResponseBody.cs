// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class BatchDeleteMetaEntitiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1FC02D76-4A94-5D97-B52C-00A031B95359</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array of deletion results, one for each requested entity. Each result indicates whether the deletion was successful and includes an error message upon failure.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<MetaEntityWriteResult> Results { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. This parameter returns true even if the deletion of some entities fails. To check the status of each individual deletion, see the Success and ErrorMessage fields in the Results array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
