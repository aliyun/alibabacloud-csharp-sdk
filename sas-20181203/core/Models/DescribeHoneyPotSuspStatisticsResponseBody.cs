// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeHoneyPotSuspStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9E3969FA-5ACC-4256-9FDE-BB6918CD0410</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the top 5 VPCs or assets for which alerts are most frequently generated.</para>
        /// </summary>
        [NameInMap("SuspHoneyPotStatisticsResponse")]
        [Validation(Required=false)]
        public List<DescribeHoneyPotSuspStatisticsResponseBodySuspHoneyPotStatisticsResponse> SuspHoneyPotStatisticsResponse { get; set; }
        public class DescribeHoneyPotSuspStatisticsResponseBodySuspHoneyPotStatisticsResponse : TeaModel {
            /// <summary>
            /// <para>The total number of alerts that are generated for the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8793</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The ID of the server.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>StatisticsKeyType</b> is set to <b>uuid</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>i-p0whhoba24wd28p8****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the server.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>StatisticsKeyType</b> is set to <b>uuid</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>abc-launch-advisor</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The type of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>vpcInstanceId</b>: VPC</description></item>
            /// <item><description><b>uuid</b>: server</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vpcInstanceId</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>StatisticsKeyType</b> is set to <b>vpcInstanceId</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-p0wwdsuutdyu1ygkt****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The name of the VPC.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>StatisticsKeyType</b> is set to <b>vpcInstanceId</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>abc01</para>
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

        }

    }

}
