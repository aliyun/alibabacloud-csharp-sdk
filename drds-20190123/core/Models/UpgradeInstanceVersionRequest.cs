// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class UpgradeInstanceVersionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the PolarDB-X 1.0 instance that you want to upgrade.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drdshbgaen89****</para>
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The version number of the PolarDB-X 1.0 instance. You can leave this parameter unspecified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-drds-server-5.4.12-16348095.noarch.rpm</para>
        /// </summary>
        [NameInMap("Rpm")]
        [Validation(Required=false)]
        public string Rpm { get; set; }

    }

}
