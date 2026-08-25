// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class ListVersionDistributionRequest : TeaModel {
        /// <summary>
        /// <para>The terminal type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: hardware terminal.</description></item>
        /// <item><description>2: software terminal.</description></item>
        /// <item><description>3: secure browser plugin.</description></item>
        /// <item><description>4: GuestOS application.</description></item>
        /// <item><description>5: DingTalk Wuying plugin.</description></item>
        /// <item><description>6: cloud application component.</description></item>
        /// <item><description>7: Cloud Hub.</description></item>
        /// <item><description>8: H5.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public int? ClientType { get; set; }

        /// <summary>
        /// <para>The management status. A value of true indicates managed, and a value of false indicates unmanaged. If this parameter is not specified, all terminals are queried.</para>
        /// </summary>
        [NameInMap("InManage")]
        [Validation(Required=false)]
        public bool? InManage { get; set; }

        /// <summary>
        /// <para>The business type. Default value: enterprise.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise</para>
        /// </summary>
        [NameInMap("MainBizType")]
        [Validation(Required=false)]
        public string MainBizType { get; set; }

        /// <summary>
        /// <para>The terminal model.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AS05-2DCXG</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The version type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SYS: system version.</description></item>
        /// <item><description>APP: application version.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYS</para>
        /// </summary>
        [NameInMap("VersionType")]
        [Validation(Required=false)]
        public string VersionType { get; set; }

    }

}
