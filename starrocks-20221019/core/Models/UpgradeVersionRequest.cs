// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class UpgradeVersionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a fast restart.</para>
        /// </summary>
        [NameInMap("FastMode")]
        [Validation(Required=false)]
        public bool? FastMode { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether this upgrade is a minor version upgrade. Default value: true.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: minor version upgrade.</description></item>
        /// <item><description>false: major engine version upgrade.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Minor")]
        [Validation(Required=false)]
        public bool? Minor { get; set; }

        /// <summary>
        /// <para>The target version number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.3.2-1.77-1.6.4</para>
        /// </summary>
        [NameInMap("TargetVersion")]
        [Validation(Required=false)]
        public string TargetVersion { get; set; }

    }

}
