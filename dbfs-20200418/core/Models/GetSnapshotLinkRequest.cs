// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class GetSnapshotLinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>sl-b3zlgraysgcs9jy********</para>
        /// </summary>
        [NameInMap("LinkId")]
        [Validation(Required=false)]
        public string LinkId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
