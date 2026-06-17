// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarFsQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public string PageRecordCount { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 5 to 50. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The path of the directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/data</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The PolarFS instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-2ze0i74ka607*****</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

        /// <summary>
        /// <para>The details of the rules.</para>
        /// </summary>
        [NameInMap("PolicyItems")]
        [Validation(Required=false)]
        public List<DescribePolarFsQuotaResponseBodyPolicyItems> PolicyItems { get; set; }
        public class DescribePolarFsQuotaResponseBodyPolicyItems : TeaModel {
            /// <summary>
            /// <para>The TTL of the access time. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7200</para>
            /// </summary>
            [NameInMap("AccessTTL")]
            [Validation(Required=false)]
            public long? AccessTTL { get; set; }

            /// <summary>
            /// <para>The TTL of the change time. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7200</para>
            /// </summary>
            [NameInMap("ChangeTTL")]
            [Validation(Required=false)]
            public long? ChangeTTL { get; set; }

            /// <summary>
            /// <para>The rule description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NULL</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the rule is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The rule takes effect immediately for new events. This is the default value.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The rule does not take effect for new events.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The glob pattern of paths to exclude.</para>
            /// <list type="bullet">
            /// <item><description>The pattern must start with <c>/</c> and supports glob syntax, including <c>*</c>, <c>?</c>, and <c>**</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NULL</para>
            /// </summary>
            [NameInMap("Exclude")]
            [Validation(Required=false)]
            public string Exclude { get; set; }

            /// <summary>
            /// <para>The maximum number of files in the directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>77</para>
            /// </summary>
            [NameInMap("FileCountLimit")]
            [Validation(Required=false)]
            public long? FileCountLimit { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>73</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The glob pattern for paths to include.</para>
            /// <list type="bullet">
            /// <item><description>The pattern must start with <c>/</c> and supports glob syntax, including <c>*</c>, <c>?</c>, and <c>**</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>/a*</para>
            /// </summary>
            [NameInMap("Include")]
            [Validation(Required=false)]
            public string Include { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxx</para>
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
            /// <para>The maximum total size of files in the directory. Unit: GB.</para>
            /// <list type="bullet">
            /// <item><description>The value must be greater than or equal to 1.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SizeLimit")]
            [Validation(Required=false)]
            public long? SizeLimit { get; set; }

        }

        /// <summary>
        /// <para>The quota information.</para>
        /// </summary>
        [NameInMap("QuotaItems")]
        [Validation(Required=false)]
        public List<DescribePolarFsQuotaResponseBodyQuotaItems> QuotaItems { get; set; }
        public class DescribePolarFsQuotaResponseBodyQuotaItems : TeaModel {
            /// <summary>
            /// <para>The capacity. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1073741824</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

            /// <summary>
            /// <para>The total number of inodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Inodes")]
            [Validation(Required=false)]
            public long? Inodes { get; set; }

            /// <summary>
            /// <para>The directory path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/data</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The used capacity. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>104857600</para>
            /// </summary>
            [NameInMap("UsedCapacity")]
            [Validation(Required=false)]
            public long? UsedCapacity { get; set; }

            /// <summary>
            /// <para>The number of used inodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UsedInodes")]
            [Validation(Required=false)]
            public long? UsedInodes { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FED790E-FB61-4721-8C1C-07C627******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public string TotalRecordCount { get; set; }

    }

}
