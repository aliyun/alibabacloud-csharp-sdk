// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DeleteRumSymbolFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The actual number of objects that were successfully deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("deletedObjectCount")]
        [Validation(Required=false)]
        public int? DeletedObjectCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of file paths requested for deletion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("requestedFileCount")]
        [Validation(Required=false)]
        public int? RequestedFileCount { get; set; }

        /// <summary>
        /// <para>The total number of deduplicated objects to be deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("requestedObjectCount")]
        [Validation(Required=false)]
        public int? RequestedObjectCount { get; set; }

        /// <summary>
        /// <para>Indicates whether all delete operations succeeded. The value is true only if all deduplicated objects to be deleted are successfully deleted. If a partial deletion failure or exception occurs, the API directly returns an error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
