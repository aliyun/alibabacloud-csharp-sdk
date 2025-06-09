// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpsertCollectionPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of centralized storage.</para>
        /// </summary>
        [NameInMap("centralizeConfig")]
        [Validation(Required=false)]
        public UpsertCollectionPolicyRequestCentralizeConfig CentralizeConfig { get; set; }
        public class UpsertCollectionPolicyRequestCentralizeConfig : TeaModel {
            /// <summary>
            /// <para>The destination logstore for centralized storage. Make sure that the region of the destination logstore is consistent with the region specified by destRegion and the destination logstore belongs to the destination project specified by destProject.</para>
            /// 
            /// <b>Example:</b>
            /// <para>your-sls-logstore-in-beijing</para>
            /// </summary>
            [NameInMap("destLogstore")]
            [Validation(Required=false)]
            public string DestLogstore { get; set; }

            /// <summary>
            /// <para>The destination project for centralized storage. Make sure that the region of the destination project is consistent with the region specified by destRegion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>your-sls-project-in-beijing</para>
            /// </summary>
            [NameInMap("destProject")]
            [Validation(Required=false)]
            public string DestProject { get; set; }

            /// <summary>
            /// <para>The destination region for centralized storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("destRegion")]
            [Validation(Required=false)]
            public string DestRegion { get; set; }

            /// <summary>
            /// <para>The data retention period for centralized storage. Unit: days. This parameter takes effect only when you use an existing logstore for centralized storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>your-sls-logstore-ttl</para>
            /// </summary>
            [NameInMap("destTTL")]
            [Validation(Required=false)]
            public int? DestTTL { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable centralized storage. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("centralizeEnabled")]
        [Validation(Required=false)]
        public bool? CentralizeEnabled { get; set; }

        /// <summary>
        /// <para>The code of the log type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>access_log</para>
        /// </summary>
        [NameInMap("dataCode")]
        [Validation(Required=false)]
        public string DataCode { get; set; }

        /// <summary>
        /// <para>The data configurations. The configuration is returned only for global logs. For example, if productCode is set to sls, the configuration is returned.</para>
        /// </summary>
        [NameInMap("dataConfig")]
        [Validation(Required=false)]
        public UpsertCollectionPolicyRequestDataConfig DataConfig { get; set; }
        public class UpsertCollectionPolicyRequestDataConfig : TeaModel {
            /// <summary>
            /// <para>The region for storing the global logs that are collected for the first time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("dataRegion")]
            [Validation(Required=false)]
            public string DataRegion { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable the policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The configurations of the policy.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("policyConfig")]
        [Validation(Required=false)]
        public UpsertCollectionPolicyRequestPolicyConfig PolicyConfig { get; set; }
        public class UpsertCollectionPolicyRequestPolicyConfig : TeaModel {
            /// <summary>
            /// <para>The IDs of the instances. This parameter takes effect only when resourceMode is set to instanceMode. Logs are collected only from instances that use the specified IDs.</para>
            /// </summary>
            [NameInMap("instanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

            /// <summary>
            /// <para>The regions of the instances. This parameter takes effect only when resourceMode is set to attributeMode. Wildcard characters are supported. If you leave this parameter empty, region-based filtering is not performed. The system considers that all instances are matched. If you specify a value for this parameter, logs of instances that reside in the specified regions are collected. Logs are collected from an instance only if the resource tags and region of the instance match the specified conditions.</para>
            /// </summary>
            [NameInMap("regions")]
            [Validation(Required=false)]
            public List<string> Regions { get; set; }

            /// <summary>
            /// <para>The resource collection mode. Valid values: all, attributeMode, and instanceMode. The value all specifies that logs of all instances within your account are collected to the default logstore. The value attributeMode specifies that logs are collected based on the regions of instances and resource tags. The value instanceMode specifies that logs are collected based on instance IDs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("resourceMode")]
            [Validation(Required=false)]
            public string ResourceMode { get; set; }

            /// <summary>
            /// <para>The resource tags. This parameter takes effect only when resourceMode is set to attributeMode. If you leave this parameter empty, resource tag-based filtering is not performed. The system considers that all instances are matched. If you specify a value for this parameter, logs of instances that use the specified resource tags are collected. Logs are collected from an instance only if the resource tags and region of the instance match the specified conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;tag1&quot;:&quot;value1&quot;,“tag2&quot;:&quot;value2&quot;}</para>
            /// </summary>
            [NameInMap("resourceTags")]
            [Validation(Required=false)]
            public Dictionary<string, object> ResourceTags { get; set; }

        }

        /// <summary>
        /// <para>The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name can contain only lowercase letters, digits, hyphens (-), and underscores (_).</description></item>
        /// <item><description>The name must start with a letter.</description></item>
        /// <item><description>The name must be 3 to 63 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>your_log_policy</para>
        /// </summary>
        [NameInMap("policyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The code of the service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The configurations of the resource directory. The account must have activated the resource directory and be a management account or a delegated administrator of the resource directory.</para>
        /// </summary>
        [NameInMap("resourceDirectory")]
        [Validation(Required=false)]
        public UpsertCollectionPolicyRequestResourceDirectory ResourceDirectory { get; set; }
        public class UpsertCollectionPolicyRequestResourceDirectory : TeaModel {
            /// <summary>
            /// <para>The mode of the resource directory. Valid values: all and custom.</para>
            /// 
            /// <b>Example:</b>
            /// <para>all,custom</para>
            /// </summary>
            [NameInMap("accountGroupType")]
            [Validation(Required=false)]
            public string AccountGroupType { get; set; }

            /// <summary>
            /// <para>The members. If accountGroupType is set to custom, the members are returned.</para>
            /// </summary>
            [NameInMap("members")]
            [Validation(Required=false)]
            public List<string> Members { get; set; }

        }

    }

}
