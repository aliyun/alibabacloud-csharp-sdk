// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetUserProvisioningRdAccountStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-003qew84****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The ID of the member in the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1743382******</para>
        /// </summary>
        [NameInMap("RdMemberId")]
        [Validation(Required=false)]
        public string RdMemberId { get; set; }

    }

}
