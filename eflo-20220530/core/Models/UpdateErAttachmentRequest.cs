// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class UpdateErAttachmentRequest : TeaModel {
        /// <summary>
        /// <para>The connection ID of the Lingjun HUB network instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>er-attachment-i1ioibyf</para>
        /// </summary>
        [NameInMap("ErAttachmentId")]
        [Validation(Required=false)]
        public string ErAttachmentId { get; set; }

        /// <summary>
        /// <para>Lingjun HUB Network Instance Connection Name</para>
        /// 
        /// <b>Example:</b>
        /// <para>er-attachment-wulanchabu-main</para>
        /// </summary>
        [NameInMap("ErAttachmentName")]
        [Validation(Required=false)]
        public string ErAttachmentName { get; set; }

        /// <summary>
        /// <para>Lingjun HUB ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>er-kkopgtne</para>
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
