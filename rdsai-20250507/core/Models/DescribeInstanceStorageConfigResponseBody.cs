// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeInstanceStorageConfigResponseBody : TeaModel {
        [NameInMap("BranchName")]
        [Validation(Required=false)]
        public string BranchName { get; set; }

        /// <summary>
        /// <para>The list of storage configurations.</para>
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<DescribeInstanceStorageConfigResponseBodyConfigList> ConfigList { get; set; }
        public class DescribeInstanceStorageConfigResponseBodyConfigList : TeaModel {
            /// <summary>
            /// <para>The name of the configuration item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AWS_SESSION_TOKEN</b>: the temporary access token (Session Token) of OSS.</description></item>
            /// <item><description><b>AWS_ACCESS_KEY_ID</b>: the AccessKey ID of OSS.</description></item>
            /// <item><description><b>AWS_SECRET_ACCESS_KEY</b>: the AccessKey Secret of OSS.</description></item>
            /// <item><description><b>GLOBAL_S3_BUCKET</b>: the bucket name of OSS.</description></item>
            /// <item><description><b>TENANT_ID</b>: the tenant ID of the OSS prefix (prefix or directory).</description></item>
            /// <item><description><b>GLOBAL_S3_ENDPOINT</b>: the endpoint of OSS.</description></item>
            /// <item><description><b>REGION</b>: the region of OSS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>REGION</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The value of the configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The instance ID of the AI application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ra-supabase-8moov5lxba****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329241C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
