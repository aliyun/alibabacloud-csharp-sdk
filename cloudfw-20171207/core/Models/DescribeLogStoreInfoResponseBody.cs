// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeLogStoreInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the SLS LogStore in the log service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx-logstore</para>
        /// </summary>
        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        /// <summary>
        /// <para>The Project name of the log service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project-xxx-cn-hangzhou</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>Available log storage capacity. Unit: Byte.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50000000</para>
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public long? Quota { get; set; }

        /// <summary>
        /// <para>The region ID for log delivery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C6C3B72B********E95FB0A161</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Log storage duration. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>Used storage capacity. Unit: Byte.</para>
        /// <remarks>
        /// <para>The statistics of the log service have a delay of approximately two hours.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Used")]
        [Validation(Required=false)]
        public long? Used { get; set; }

    }

}
