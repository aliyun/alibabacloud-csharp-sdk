// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ValidateImportTaskRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID. You can obtain the value of this parameter by invoking the DescribeDBInstances API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-sdfljk123****</para>
        /// </summary>
        [NameInMap("DbInstanceId")]
        [Validation(Required=false)]
        public string DbInstanceId { get; set; }

        /// <summary>
        /// <para>Estimated instance size (GB)</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("EstimatedSize")]
        [Validation(Required=false)]
        public int? EstimatedSize { get; set; }

        /// <summary>
        /// <para>Source MySQL host address</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.10.1</para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Password for the source MySQL user (Base64 encrypted)</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UGFzc3dvcmQxMjMK</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Source MySQL port number</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>Region ID. You can obtain this by invoking the DescribeRegions API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Source cloud instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-wz9ff3acy500io5wdf5s</para>
        /// </summary>
        [NameInMap("SourceInstanceId")]
        [Validation(Required=false)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// <para>Source platform type  </para>
        /// <list type="bullet">
        /// <item><description>ECS</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("SourcePlatform")]
        [Validation(Required=false)]
        public string SourcePlatform { get; set; }

        /// <summary>
        /// <para>Backup transfer port number</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9999</para>
        /// </summary>
        [NameInMap("StreamPort")]
        [Validation(Required=false)]
        public int? StreamPort { get; set; }

        /// <summary>
        /// <para>Source MySQL user</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myadmin</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

        /// <summary>
        /// <para>Path to the Xtrabackup tool on the source</para>
        /// 
        /// <b>Example:</b>
        /// <para>/usr/local/bin/xtrabackup</para>
        /// </summary>
        [NameInMap("XtrabackupPath")]
        [Validation(Required=false)]
        public string XtrabackupPath { get; set; }

    }

}
