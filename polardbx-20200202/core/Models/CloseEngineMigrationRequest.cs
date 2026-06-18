// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CloseEngineMigrationRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to keep binlog enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Keeps binlog enabled.</description></item>
        /// <item><description><b>false</b>: Disables binlog.</description></item>
        /// </list>
        /// <para>Default value: <b>true</b>.</para>
        /// <remarks>
        /// <para>Disabling binlog restarts your PolarDB cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ContinueEnableBinlog")]
        [Validation(Required=false)]
        public string ContinueEnableBinlog { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-htri0****r4k9p</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
