// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClusterCheckItemWarningStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the container cluster.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/182997.html">DescribeGroupedContainerInstances</a> operation to query the IDs of container clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cd49575861a3044d49c954e4b3911****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The server UUID.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to query the server UUID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>e4af3620-6895-4e2f-a641-a9d8fb53****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
