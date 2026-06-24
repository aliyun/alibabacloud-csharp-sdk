// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CreateCollectorRequest : TeaModel {
        /// <summary>
        /// <para>The collection paths of fileBeat. This parameter is required only when the collector is deployed on ECS instances.</para>
        /// </summary>
        [NameInMap("collectorPaths")]
        [Validation(Required=false)]
        public List<string> CollectorPaths { get; set; }

        /// <summary>
        /// <para>The configuration file information of the collector.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<CreateCollectorRequestConfigs> Configs { get; set; }
        public class CreateCollectorRequestConfigs : TeaModel {
            /// <summary>
            /// <para>The file content.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;filebeat.inputs:xxx&quot;</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>filebeat.yml</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run without performing the actual request. This parameter is used only when you create or update a collector. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs only a dry run without creating or updating the collector.</description></item>
        /// <item><description>false: performs a dry run and sends the request.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The extended configurations of the collector.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("extendConfigs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> ExtendConfigs { get; set; }

        /// <summary>
        /// <para>The name of the collector. The name must be 1 to 30 characters in length, start with an uppercase or lowercase letter, and can contain letters, digits, underscores (_), or hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ct-test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The type of the collector. Valid values: fileBeat, metricBeat, heartBeat, and auditBeat.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fileBeat</para>
        /// </summary>
        [NameInMap("resType")]
        [Validation(Required=false)]
        public string ResType { get; set; }

        /// <summary>
        /// <para>The version of the collector. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ECS-based deployment: 6.8.5_with_community</description></item>
        /// <item><description>ACK-based deployment: 6.8.13_with_community.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6.8.5_with_community</para>
        /// </summary>
        [NameInMap("resVersion")]
        [Validation(Required=false)]
        public string ResVersion { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) where the collector resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp12nu14urf0upaf*****</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
