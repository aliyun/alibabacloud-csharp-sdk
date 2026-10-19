// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyInstanceMinorVersionRequest : TeaModel {
        /// <summary>
        /// <para>The time when the upgrade is performed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediately</b>: Performs the upgrade immediately. This is the default value.</description></item>
        /// <item><description><b>MaintainTime</b>: Performs the upgrade during the maintenance window.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/473775.html">ModifyInstanceMaintainTime</a> to change the maintenance window of the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Immediately</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The minor version to which you want to upgrade. Default value: <b>latest_version</b>, which indicates the latest version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>latest_version</para>
        /// </summary>
        [NameInMap("Minorversion")]
        [Validation(Required=false)]
        public string Minorversion { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
