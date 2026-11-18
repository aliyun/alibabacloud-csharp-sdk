// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class ListExecutorsRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions for querying executors.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public ListExecutorsRequestFilter Filter { get; set; }
        public class ListExecutorsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The list of executor IDs. A maximum of 100 IDs are supported.</para>
            /// </summary>
            [NameInMap("ExecutorIds")]
            [Validation(Required=false)]
            public List<string> ExecutorIds { get; set; }

            /// <summary>
            /// <para>The executor image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-f8z0dfa96luxxxxx</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>The list of internal IP addresses. A maximum of 100 IP addresses are supported.</para>
            /// </summary>
            [NameInMap("IpAddresses")]
            [Validation(Required=false)]
            public List<string> IpAddresses { get; set; }

            /// <summary>
            /// <para>The job name. Fuzzy match is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testJob</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The job template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jt-xxxx</para>
            /// </summary>
            [NameInMap("JobTemplateId")]
            [Validation(Required=false)]
            public string JobTemplateId { get; set; }

            /// <summary>
            /// <para>The resource pool name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyPool</para>
            /// </summary>
            [NameInMap("PoolName")]
            [Validation(Required=false)]
            public string PoolName { get; set; }

            /// <summary>
            /// <para>The list of executor statuses.</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public List<string> Status { get; set; }

            /// <summary>
            /// <para>The time after which the job was submitted. The time is converted to a UNIX timestamp based on the time zone of the region. For regions in the Chinese mainland, the time zone is UTC+8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1703819914</para>
            /// </summary>
            [NameInMap("TimeCreatedAfter")]
            [Validation(Required=false)]
            public int? TimeCreatedAfter { get; set; }

            /// <summary>
            /// <para>The time before which the job was submitted. The time is converted to a UNIX timestamp based on the time zone of the region. For regions in the Chinese mainland, the time zone is UTC+8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1703820113</para>
            /// </summary>
            [NameInMap("TimeCreatedBefore")]
            [Validation(Required=false)]
            public int? TimeCreatedBefore { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-xxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-xxx</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        /// <summary>
        /// <para>The page number. Starting value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in the paging Settings for a paged query. Default value: 50. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
