// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class UpdateInstanceNetworkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the retention period of the classic network endpoint. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ClassicExpiredDays")]
        [Validation(Required=false)]
        public int? ClassicExpiredDays { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB-X 1.0 instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drds******</para>
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain the classic network endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RetainClassic")]
        [Validation(Required=false)]
        public bool? RetainClassic { get; set; }

        /// <summary>
        /// <para>The network type of the PolarDB-X 1.0 instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>vpc: Virtual Private Cloud (VPC)</description></item>
        /// <item><description>classic: classic network</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>classic</para>
        /// </summary>
        [NameInMap("SrcInstanceNetworkType")]
        [Validation(Required=false)]
        public string SrcInstanceNetworkType { get; set; }

    }

}
