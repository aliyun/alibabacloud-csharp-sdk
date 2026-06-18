// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class SwitchGdnMemberRoleRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the primary instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-********</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("DstMainConnectString")]
        [Validation(Required=false)]
        public string DstMainConnectString { get; set; }

        [NameInMap("DstMainPort")]
        [Validation(Required=false)]
        public string DstMainPort { get; set; }

        [NameInMap("IsModifyEndpoint")]
        [Validation(Required=false)]
        public string IsModifyEndpoint { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SrcMainConnectString")]
        [Validation(Required=false)]
        public string SrcMainConnectString { get; set; }

        [NameInMap("SrcMainPort")]
        [Validation(Required=false)]
        public string SrcMainPort { get; set; }

        /// <summary>
        /// <para>The switchover mode.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>常规切换：switch_over
        /// 强制切换：fail_over</para>
        /// </summary>
        [NameInMap("SwitchMode")]
        [Validation(Required=false)]
        public string SwitchMode { get; set; }

        /// <summary>
        /// <para>The timeout period of the switchover task. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TaskTimeout")]
        [Validation(Required=false)]
        public long? TaskTimeout { get; set; }

    }

}
