// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class UpgradeCDCVersionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2.343</para>
        /// </summary>
        [NameInMap("CdcDbVersion")]
        [Validation(Required=false)]
        public string CdcDbVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>polarx-cdc-kernel-5.4.19-20240928_17274884</para>
        /// </summary>
        [NameInMap("CdcMinorVersion")]
        [Validation(Required=false)]
        public string CdcMinorVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pxc-hzrp****3p72fi</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pxc-shrvdc****wtf5uk-cdc</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SwitchMode")]
        [Validation(Required=false)]
        public string SwitchMode { get; set; }

    }

}
