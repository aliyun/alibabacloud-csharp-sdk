// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DeleteAIDBClusterDatasetResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pcs-2zeei***</para>
        /// </summary>
        [NameInMap("DataServiceId")]
        [Validation(Required=false)]
        public string DataServiceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pds-xxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD35F3-F3-44CA-AFFF-BAF869******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
