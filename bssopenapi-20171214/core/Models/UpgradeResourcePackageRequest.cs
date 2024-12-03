// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class UpgradeResourcePackageRequest : TeaModel {
        /// <summary>
        /// <para>The time when the resource plan takes effect. If you leave this parameter empty, the resource plan immediately takes effect by default.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-02T12:00:00Z</para>
        /// </summary>
        [NameInMap("EffectiveDate")]
        [Validation(Required=false)]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// <para>The ID of the resource plan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSSBAG-cn-0xl*****x002</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The specifications to which you want to upgrade the resource plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51200</para>
        /// </summary>
        [NameInMap("Specification")]
        [Validation(Required=false)]
        public string Specification { get; set; }

    }

}
