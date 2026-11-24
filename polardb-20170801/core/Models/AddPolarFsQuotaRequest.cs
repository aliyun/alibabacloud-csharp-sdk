// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class AddPolarFsQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The PolarDB instance ID that the application depends on.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The Polarlakebase instance ID.</para>
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
            /// <para>The time-to-live (TTL) for the access time. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7200</para>
            /// </summary>
            [NameInMap("AccessTTL")]
            [Validation(Required=false)]
            public long? AccessTTL { get; set; }

            /// <summary>
            /// <para>The time-to-live (TTL) for the change time. Unit: seconds.</para>
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
            /// <para>Specifies whether the rule is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>True</b>: New events take effect immediately for new resources. This is the default value.</description></item>
            /// <item><description><b>False</b>: New events do not take effect for new resources.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The matching rule used to exclude specific paths.</para>
            /// <list type="bullet">
            /// <item><description>A path pattern that starts with <c>/</c>. Glob syntax such as <c>*</c>, <c>?</c>, and <c>**</c> is supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>/a/<em>project</em></para>
            /// </summary>
            [NameInMap("Exclude")]
            [Validation(Required=false)]
            public string Exclude { get; set; }

            /// <summary>
            /// <para>The maximum number of files allowed in the directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>222</para>
            /// </summary>
            [NameInMap("FileCountLimit")]
            [Validation(Required=false)]
            public long? FileCountLimit { get; set; }

            /// <summary>
            /// <para>The wildcard pattern used to match paths.</para>
            /// <list type="bullet">
            /// <item><description>A path pattern that starts with <c>/</c>. Glob syntax such as <c>*</c>, <c>?</c>, and <c>**</c> is supported.</description></item>
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
            /// <para>The maximum total capacity of files in the directory. Unit: GB.</para>
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
