// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ModifyAppInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter</para>
        /// </summary>
        [NameInMap("BranchName")]
        [Validation(Required=false)]
        public string BranchName { get; set; }

        /// <summary>
        /// <para>The idempotency parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of modules.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public string ComponentsShrink { get; set; }

        /// <summary>
        /// <para>The instance ID of the ApsaraDB RDS for PostgreSQL database connected to the AI application.</para>
        /// <para><notice>Only <b>newly purchased empty ApsaraDB RDS for PostgreSQL instances</b> are supported. The major engine version must be <b>17</b>, and the minor engine version must be <b>20250630 or later</b>.</notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-2ze49qv594vi****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The instance type. Only <b>rdsai.supabase.basic</b> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rdsai.supabase.basic</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The instance ID of the AI application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ra-8moov5lxba****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter</para>
        /// </summary>
        [NameInMap("MigrationMode")]
        [Validation(Required=false)]
        public string MigrationMode { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
