// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ListDedicatedClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The statuses of all clusters.</para>
        /// </summary>
        [NameInMap("DedicatedClusterStatusList")]
        [Validation(Required=false)]
        public ListDedicatedClusterResponseBodyDedicatedClusterStatusList DedicatedClusterStatusList { get; set; }
        public class ListDedicatedClusterResponseBodyDedicatedClusterStatusList : TeaModel {
            [NameInMap("DedicatedClusterStatus")]
            [Validation(Required=false)]
            public List<ListDedicatedClusterResponseBodyDedicatedClusterStatusListDedicatedClusterStatus> DedicatedClusterStatus { get; set; }
            public class ListDedicatedClusterResponseBodyDedicatedClusterStatusListDedicatedClusterStatus : TeaModel {
                /// <summary>
                /// <para>The CPU utilization, in percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("CpuUtilization")]
                [Validation(Required=false)]
                public long? CpuUtilization { get; set; }

                /// <summary>
                /// <para>The ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dtscluster*******</para>
                /// </summary>
                [NameInMap("DedicatedClusterId")]
                [Validation(Required=false)]
                public string DedicatedClusterId { get; set; }

                /// <summary>
                /// <para>The name of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>daily_test</para>
                /// </summary>
                [NameInMap("DedicatedClusterName")]
                [Validation(Required=false)]
                public string DedicatedClusterName { get; set; }

                /// <summary>
                /// <para>The disk usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("DiskUtilization")]
                [Validation(Required=false)]
                public long? DiskUtilization { get; set; }

                /// <summary>
                /// <para>The ID of the DTS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dtsi03e3zty16i****</para>
                /// </summary>
                [NameInMap("DtsInstanceID")]
                [Validation(Required=false)]
                public string DtsInstanceID { get; set; }

                /// <summary>
                /// <para>The number of DTS units (DUs).</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Du")]
                [Validation(Required=false)]
                public long? Du { get; set; }

                /// <summary>
                /// <para>The DU usage, in percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16.6667</para>
                /// </summary>
                [NameInMap("DuUtilization")]
                [Validation(Required=false)]
                public long? DuUtilization { get; set; }

                /// <summary>
                /// <para>The time when the cluster was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1647424384606</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public long? GmtCreated { get; set; }

                /// <summary>
                /// <para>The memory usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("MemUtilization")]
                [Validation(Required=false)]
                public long? MemUtilization { get; set; }

                /// <summary>
                /// <para>The number of nodes in the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("NodeCount")]
                [Validation(Required=false)]
                public long? NodeCount { get; set; }

                /// <summary>
                /// <para>The number of over-provisioned DUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("OversoldDu")]
                [Validation(Required=false)]
                public long? OversoldDu { get; set; }

                /// <summary>
                /// <para>The ID of the region in which the DTS instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The status of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>init</b>: The cluster is being initialized.</description></item>
                /// <item><description><b>schedule</b>: The cluster is pending scheduling.</description></item>
                /// <item><description><b>running</b>: The cluster is running.</description></item>
                /// <item><description><b>upgrade</b>: The cluster is being upgraded.</description></item>
                /// <item><description><b>downgrade</b>: The cluster is being downgraded.</description></item>
                /// <item><description><b>locked</b>: The cluster is locked.</description></item>
                /// <item><description><b>releasing</b>: The cluster is being released.</description></item>
                /// <item><description><b>released</b>: The cluster is released.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>init</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The total number of CPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalCpuCore")]
                [Validation(Required=false)]
                public long? TotalCpuCore { get; set; }

                /// <summary>
                /// <para>The total disk capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2048</para>
                /// </summary>
                [NameInMap("TotalDiskGBSize")]
                [Validation(Required=false)]
                public long? TotalDiskGBSize { get; set; }

                /// <summary>
                /// <para>The total memory capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>256</para>
                /// </summary>
                [NameInMap("TotalMemGBSize")]
                [Validation(Required=false)]
                public long? TotalMemGBSize { get; set; }

                /// <summary>
                /// <para>The number of used CPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("UsedCpuCore")]
                [Validation(Required=false)]
                public long? UsedCpuCore { get; set; }

                /// <summary>
                /// <para>The used disk capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("UsedDiskGBSize")]
                [Validation(Required=false)]
                public long? UsedDiskGBSize { get; set; }

                /// <summary>
                /// <para>The number of used DUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("UsedDu")]
                [Validation(Required=false)]
                public long? UsedDu { get; set; }

                /// <summary>
                /// <para>The used memory capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>128</para>
                /// </summary>
                [NameInMap("UsedMemGBSize")]
                [Validation(Required=false)]
                public long? UsedMemGBSize { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Value of Input Parameter %s is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The page number of the returned page. The value must be an integer that is greater than 0. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>621BB4F8-3016-4FAA-8D5A-5D3163CC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The total number of clusters that meet the query condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
