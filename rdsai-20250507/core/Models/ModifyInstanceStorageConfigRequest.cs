// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ModifyInstanceStorageConfigRequest : TeaModel {
        /// <summary>
        /// <para>The value of the configuration item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the RDS Supabase instance.</para>
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<ModifyInstanceStorageConfigRequestConfigList> ConfigList { get; set; }
        public class ModifyInstanceStorageConfigRequestConfigList : TeaModel {
            /// <summary>
            /// <para>The name of the configuration item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AWS_SESSION_TOKEN</b> (optional): The temporary session token for OSS. If this parameter is not provided, validation is performed using the AccessKey ID and AccessKey secret.</description></item>
            /// <item><description><b>AWS_ACCESS_KEY_ID</b>: The AccessKey ID for OSS.</description></item>
            /// <item><description><b>AWS_SECRET_ACCESS_KEY</b>: The AccessKey secret for OSS.</description></item>
            /// <item><description><b>GLOBAL_S3_BUCKET</b>: The bucket name in OSS.</description></item>
            /// <item><description><b>TENANT_ID</b>: The folder name in OSS. No manual creation is required.</description></item>
            /// <item><description><b>GLOBAL_S3_ENDPOINT</b>: The endpoint (access domain name) for OSS.</description></item>
            /// <item><description><b>REGION</b>: The region of OSS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TENANT_ID</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The value of the configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-prefix</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ra-supabase-8moov5lxba****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform. Set the value to <b>ModifyInstanceStorageConfig</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
