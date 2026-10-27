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

        /// <summary>
        /// <para>The endpoint of the primary node of the target instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-*********.polarx.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("DstMainConnectString")]
        [Validation(Required=false)]
        public string DstMainConnectString { get; set; }

        /// <summary>
        /// <para>The port number of the primary node of the target instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3313</para>
        /// </summary>
        [NameInMap("DstMainPort")]
        [Validation(Required=false)]
        public string DstMainPort { get; set; }

        /// <summary>
        /// <para>Specifies whether the endpoint and port of the source or target instance is simultaneously modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
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

        /// <summary>
        /// <para>The endpoint of the primary node of the source instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-*********.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("SrcMainConnectString")]
        [Validation(Required=false)]
        public string SrcMainConnectString { get; set; }

        /// <summary>
        /// <para>The port number of the primary node of the source instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3308</para>
        /// </summary>
        [NameInMap("SrcMainPort")]
        [Validation(Required=false)]
        public string SrcMainPort { get; set; }

        /// <summary>
        /// <para>The switchover mode.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal switchover: switch_over
        /// Forced switchover: fail_over</para>
        /// </summary>
        [NameInMap("SwitchMode")]
        [Validation(Required=false)]
        public string SwitchMode { get; set; }

        /// <summary>
        /// <para>The timeout period for the switchover task, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TaskTimeout")]
        [Validation(Required=false)]
        public long? TaskTimeout { get; set; }

    }

}
