// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class GetCatalogKmsGrantsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ARN of the RAM role used by DLF to access catalog data. When configuring the KMS key policy, you must grant this role permissions to use the customer master key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:role/AliyunDlfNextDataAccessRole</para>
        /// </summary>
        [NameInMap("dataAccessRoleArn")]
        [Validation(Required=false)]
        public string DataAccessRoleArn { get; set; }

        /// <summary>
        /// <para>The authorization statement that must be added to the customer master key policy. This statement grants the DLF data access role corresponding to dataAccessRoleArn the KMS permissions required for data encryption and decryption.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Sid&quot;:&quot;AllowDLFDataAccess&quot;,&quot;Effect&quot;:&quot;Allow&quot;,&quot;Principal&quot;:{&quot;RAM&quot;:[&quot;acs:ram::123456789012****:role/
        ///   AliyunDlfNextDataAccessRole&quot;]},&quot;Action&quot;:[&quot;kms:Decrypt&quot;,&quot;kms:GenerateDataKey&quot;],&quot;Resource&quot;:[&quot;*&quot;]}</para>
        /// </summary>
        [NameInMap("keyPolicyStatement")]
        [Validation(Required=false)]
        public string KeyPolicyStatement { get; set; }

        /// <summary>
        /// <para>The region ID to which the catalog belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The DLF workflow role ARN. In the current version, the workflow role is not granted customer master key access permissions based on the least privilege principle. Therefore, this field returns an empty value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("workflowRoleArn")]
        [Validation(Required=false)]
        public string WorkflowRoleArn { get; set; }

    }

}
