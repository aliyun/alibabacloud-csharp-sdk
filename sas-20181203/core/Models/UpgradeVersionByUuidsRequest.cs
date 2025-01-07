// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpgradeVersionByUuidsRequest : TeaModel {
        /// <summary>
        /// <para>The version to which you want to upgrade the client.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.9</para>
        /// </summary>
        [NameInMap("UpgradeVersion")]
        [Validation(Required=false)]
        public string UpgradeVersion { get; set; }

        /// <summary>
        /// <para>The UUIDs of the assets on which you want to run the detection task.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
