// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class BatchCreateMetaEntitiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9E0C8E7A-C6BE-5A73-9562-2A030A80E8C6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of results for the batch creation operation. This list provides the success status and any error messages for each individual entity in the request.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<MetaEntityWriteResult> Results { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. This parameter returns <c>true</c> even if creating some entities fails. To determine the outcome for each entity, check the <c>Success</c> and <c>ErrorMessage</c> fields in the <c>Results</c> array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
