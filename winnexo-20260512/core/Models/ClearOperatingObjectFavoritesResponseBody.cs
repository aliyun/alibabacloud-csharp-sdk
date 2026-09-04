// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ClearOperatingObjectFavoritesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. SUCCESS indicates success. In case of failure, the corresponding error type is returned, such as ERR_BAD_REQUEST, ERR_VALIDATION_FAILED, or ERR_INTERNAL_SERVER_ERROR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The graph name. You can call listGraphs to obtain the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crm</para>
        /// </summary>
        [NameInMap("graphName")]
        [Validation(Required=false)]
        public string GraphName { get; set; }

        /// <summary>
        /// <para>The status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The object type, such as customer. This parameter has a value when type is set to mention.</para>
        /// 
        /// <b>Example:</b>
        /// <para>contract</para>
        /// </summary>
        [NameInMap("objectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>The digital employee name (operating object name, optional).</para>
        /// 
        /// <b>Example:</b>
        /// <para>customer_assistant</para>
        /// </summary>
        [NameInMap("operatingObjectName")]
        [Validation(Required=false)]
        public string OperatingObjectName { get; set; }

        /// <summary>
        /// <para>The number of remaining followed objects within the specified scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("remainingCount")]
        [Validation(Required=false)]
        public long? RemainingCount { get; set; }

        /// <summary>
        /// <para>The number of physical follow records that were actually deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("removedCount")]
        [Validation(Required=false)]
        public long? RemovedCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the remaining record count has been verified as zero within the same transaction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("verified")]
        [Validation(Required=false)]
        public bool? Verified { get; set; }

    }

}
