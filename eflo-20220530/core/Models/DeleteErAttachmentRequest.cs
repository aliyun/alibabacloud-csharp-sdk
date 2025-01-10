// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class DeleteErAttachmentRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the network connection instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>er-attachment-5n3nsmvl</para>
        /// </summary>
        [NameInMap("ErAttachmentId")]
        [Validation(Required=false)]
        public string ErAttachmentId { get; set; }

        /// <summary>
        /// <para>Lingjun HUB Id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>er-opy1wrfv</para>
        /// </summary>
        [NameInMap("ErId")]
        [Validation(Required=false)]
        public string ErId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
