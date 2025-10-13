// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Metaspace20221014.Models
{
    public class GetCoordinationTicketRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>co-ik1nu2hxg5zbu****</para>
        /// </summary>
        [NameInMap("CoId")]
        [Validation(Required=false)]
        public string CoId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eab51156-7832-4922-9623-ff905****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
