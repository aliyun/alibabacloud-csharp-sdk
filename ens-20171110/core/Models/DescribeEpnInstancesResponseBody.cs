// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEpnInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of EPN instances.</para>
        /// </summary>
        [NameInMap("EPNInstances")]
        [Validation(Required=false)]
        public DescribeEpnInstancesResponseBodyEPNInstances EPNInstances { get; set; }
        public class DescribeEpnInstancesResponseBodyEPNInstances : TeaModel {
            [NameInMap("EPNInstance")]
            [Validation(Required=false)]
            public List<DescribeEpnInstancesResponseBodyEPNInstancesEPNInstance> EPNInstance { get; set; }
            public class DescribeEpnInstancesResponseBodyEPNInstancesEPNInstance : TeaModel {
                /// <summary>
                /// <para>The time when the instance was created. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-11-01T06:08:46Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The ID of the EPN instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>epn****</para>
                /// </summary>
                [NameInMap("EPNInstanceId")]
                [Validation(Required=false)]
                public string EPNInstanceId { get; set; }

                /// <summary>
                /// <para>The name of the EPN instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ens_test_epn</para>
                /// </summary>
                [NameInMap("EPNInstanceName")]
                [Validation(Required=false)]
                public string EPNInstanceName { get; set; }

                /// <summary>
                /// <para>Set the value to EdgeToEdge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EdgeToEdge</para>
                /// </summary>
                [NameInMap("EPNInstanceType")]
                [Validation(Required=false)]
                public string EPNInstanceType { get; set; }

                /// <summary>
                /// <para>The end of the time range during which the data was queried. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-11-01T06:08:46Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The inbound bandwidth. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("InternetMaxBandwidthOut")]
                [Validation(Required=false)]
                public int? InternetMaxBandwidthOut { get; set; }

                /// <summary>
                /// <para>The time when the instance was last modified. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-11-01T06:08:46Z</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>The networking mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SpeedUp: intelligent acceleration network (Internet)</description></item>
                /// <item><description>Connection: internal network</description></item>
                /// <item><description>SpeedUpAndConnection: intelligent acceleration network and internal network</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SpeedUp</para>
                /// </summary>
                [NameInMap("NetworkingModel")]
                [Validation(Required=false)]
                public string NetworkingModel { get; set; }

                /// <summary>
                /// <para>The beginning of the time range during which the data was queried. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-11-01T06:08:46Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Running</description></item>
                /// <item><description>Excuting</description></item>
                /// <item><description>Stopped</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1707FC0-430C-423A-B624-284046B20399</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
