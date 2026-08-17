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
            /// <para>A list of executor IDs. You can specify up to 100 IDs.</para>
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
            /// <para>A list of private IP addresses. You can specify up to 100 IP addresses.</para>
            /// </summary>
            [NameInMap("IpAddresses")]
            [Validation(Required=false)]
            public List<string> IpAddresses { get; set; }

            /// <summary>
            /// <para>The job name. Fuzzy queries are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testJob</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>jt-xxxx</para>
            /// </summary>
            [NameInMap("JobTemplateId")]
            [Validation(Required=false)]
            public string JobTemplateId { get; set; }

            /// <summary>
            /// <para>A list of executor statuses.</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public List<string> Status { get; set; }

            /// <summary>
            /// <para>The jobs submitted after this time. This is a UNIX timestamp that is converted from the time in the region where the job is located. For sites in mainland China, the time is in the UTC+8 time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1703819914</para>
            /// </summary>
            [NameInMap("TimeCreatedAfter")]
            [Validation(Required=false)]
            public int? TimeCreatedAfter { get; set; }

            /// <summary>
            /// <para>The jobs submitted before this time. This is a UNIX timestamp that is converted from the time in the region where the job is located. For sites in mainland China, the time is in the UTC+8 time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1703820113</para>
            /// </summary>
            [NameInMap("TimeCreatedBefore")]
            [Validation(Required=false)]
            public int? TimeCreatedBefore { get; set; }

            /// <summary>
            /// <para>The virtual private cloud (VPC) ID.</para>
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
        /// <para>The current page number.<br>Start value: 1<br>Default value: 1<br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for a paged query. Default value: 50. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
