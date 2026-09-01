// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpdateKnowledgeSpaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the knowledge space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pks-xxxxxx</para>
        /// </summary>
        [NameInMap("KnowledgeSpaceId")]
        [Validation(Required=false)]
        public string KnowledgeSpaceId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD35F3-F3-44CA-AFFF-BAF869******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the asynchronous workflow task. This value is empty if no actual model change occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52*****03</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public int? TaskId { get; set; }

    }

}
