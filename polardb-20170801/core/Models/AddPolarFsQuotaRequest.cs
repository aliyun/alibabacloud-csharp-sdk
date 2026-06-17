// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class AddPolarFsQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the PolarDB instance on which the application depends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the Polarlakebase instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-2ze0i74ka607*****</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

        /// <summary>
        /// <para>The details of the quota rules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<AddPolarFsQuotaRequestQuotas> Quotas { get; set; }
        public class AddPolarFsQuotaRequestQuotas : TeaModel {
            /// <summary>
            /// <para>The time to live (TTL) for the access time. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7200</para>
            /// </summary>
            [NameInMap("AccessTTL")]
            [Validation(Required=false)]
            public long? AccessTTL { get; set; }

            /// <summary>
            /// <para>The TTL for the change time. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7200</para>
            /// </summary>
            [NameInMap("ChangeTTL")]
            [Validation(Required=false)]
            public long? ChangeTTL { get; set; }

            /// <summary>
            /// <para>The description of the resource quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>quota_policy</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>True</b>: The rule immediately applies to new items. This is the default value.</para>
            /// </description></item>
            /// <item><description><para><b>False</b>: The rule does not apply to new items.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The rule to exclude specific paths from matching.</para>
            /// <list type="bullet">
            /// <item><description>A path pattern that starts with a forward slash (/). Supports glob syntax, including <c>*</c>, <c>?</c>, and <c>**</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>/a/<em>project</em></para>
            /// </summary>
            [NameInMap("Exclude")]
            [Validation(Required=false)]
            public string Exclude { get; set; }

            /// <summary>
            /// <para>The limit on the number of files for a user in the directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>222</para>
            /// </summary>
            [NameInMap("FileCountLimit")]
            [Validation(Required=false)]
            public long? FileCountLimit { get; set; }

            /// <summary>
            /// <para>The wildcard pattern to match paths.</para>
            /// <list type="bullet">
            /// <item><description>A path pattern that starts with a forward slash (/). Supports glob syntax, including <c>*</c>, <c>?</c>, and <c>**</c>.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/b/<em>project</em></para>
            /// </summary>
            [NameInMap("Include")]
            [Validation(Required=false)]
            public string Include { get; set; }

            /// <summary>
            /// <para>The name of the rule.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The priority of the quota rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The total size limit for files in the directory. Unit: GB.</para>
            /// <list type="bullet">
            /// <item><description>Note: The value must be at least 1 GB.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SizeLimit")]
            [Validation(Required=false)]
            public long? SizeLimit { get; set; }

        }

    }

}
