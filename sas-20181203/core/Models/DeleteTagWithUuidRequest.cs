// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteTagWithUuidRequest : TeaModel {
        /// <summary>
        /// <para>The label name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// <para>The list of server UUIDs.</para>
        /// <remarks>
        /// <para>If UuidList is specified, Security Center deletes the label only from the servers included in UuidList. If UuidList is empty, Security Center deletes the label from all servers.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>111-xx,aa-bb</para>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public string UuidList { get; set; }

    }

}
