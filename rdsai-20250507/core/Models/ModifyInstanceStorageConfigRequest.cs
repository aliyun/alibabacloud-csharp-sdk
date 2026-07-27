// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ModifyInstanceStorageConfigRequest : TeaModel {
        [NameInMap("BranchName")]
        [Validation(Required=false)]
        public string BranchName { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, which ensures that the request is not repeated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of storage configurations.</para>
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<ModifyInstanceStorageConfigRequestConfigList> ConfigList { get; set; }
        public class ModifyInstanceStorageConfigRequestConfigList : TeaModel {
            /// <summary>
            /// <para>The name of the configuration item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AWS_SESSION_TOKEN</b> (optional): the temporary access token (Session Token) for OSS. If this parameter is not specified, AccessKey ID and AccessKey Secret are used for authentication.</description></item>
            /// <item><description><b>AWS_ACCESS_KEY_ID</b>: the AccessKey ID for OSS.</description></item>
            /// <item><description><b>AWS_SECRET_ACCESS_KEY</b>: the AccessKey Secret for OSS.</description></item>
            /// <item><description><b>GLOBAL_S3_BUCKET</b>: the bucket name of OSS.</description></item>
            /// <item><description><b>TENANT_ID</b>: the OSS directory name. You do not need to create it in advance.</description></item>
            /// <item><description><b>GLOBAL_S3_ENDPOINT</b>: the endpoint of OSS.</description></item>
            /// <item><description><b>REGION</b>: the region of OSS.</description></item>
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
        /// <para>The instance ID of the AI application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ra-supabase-8moov5lxba****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

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
