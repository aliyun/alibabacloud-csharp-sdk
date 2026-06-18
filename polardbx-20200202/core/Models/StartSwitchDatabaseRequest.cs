// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class StartSwitchDatabaseRequest : TeaModel {
        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-xxx</para>
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
        /// <para>The port number of the target instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3313</para>
        /// </summary>
        [NameInMap("DstMainPort")]
        [Validation(Required=false)]
        public string DstMainPort { get; set; }

        /// <summary>
        /// <para>Specifies whether to modify the endpoint or port of the source or target instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsModifyEndpoint")]
        [Validation(Required=false)]
        public string IsModifyEndpoint { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the import task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>etx-szr2rr6i*****</para>
        /// </summary>
        [NameInMap("SlinkTaskId")]
        [Validation(Required=false)]
        public string SlinkTaskId { get; set; }

        /// <summary>
        /// <para>The endpoint of the primary node of the source instance, which is typically the internal or public endpoint of the instance.</para>
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

    }

}
