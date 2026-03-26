// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ListDedicatedClusterResponseBody : TeaModel {
        [NameInMap("DedicatedClusterStatusList")]
        [Validation(Required=false)]
        public ListDedicatedClusterResponseBodyDedicatedClusterStatusList DedicatedClusterStatusList { get; set; }
        public class ListDedicatedClusterResponseBodyDedicatedClusterStatusList : TeaModel {
            [NameInMap("DedicatedClusterStatus")]
            [Validation(Required=false)]
            public List<ListDedicatedClusterResponseBodyDedicatedClusterStatusListDedicatedClusterStatus> DedicatedClusterStatus { get; set; }
            public class ListDedicatedClusterResponseBodyDedicatedClusterStatusListDedicatedClusterStatus : TeaModel {
                [NameInMap("CpuUtilization")]
                [Validation(Required=false)]
                public long? CpuUtilization { get; set; }

                [NameInMap("DedicatedClusterId")]
                [Validation(Required=false)]
                public string DedicatedClusterId { get; set; }

                [NameInMap("DedicatedClusterName")]
                [Validation(Required=false)]
                public string DedicatedClusterName { get; set; }

                [NameInMap("DiskUtilization")]
                [Validation(Required=false)]
                public long? DiskUtilization { get; set; }

                [NameInMap("DtsInstanceID")]
                [Validation(Required=false)]
                public string DtsInstanceID { get; set; }

                [NameInMap("Du")]
                [Validation(Required=false)]
                public long? Du { get; set; }

                [NameInMap("DuUtilization")]
                [Validation(Required=false)]
                public long? DuUtilization { get; set; }

                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public long? GmtCreated { get; set; }

                [NameInMap("MemUtilization")]
                [Validation(Required=false)]
                public long? MemUtilization { get; set; }

                [NameInMap("NodeCount")]
                [Validation(Required=false)]
                public long? NodeCount { get; set; }

                [NameInMap("OversoldDu")]
                [Validation(Required=false)]
                public long? OversoldDu { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("TotalCpuCore")]
                [Validation(Required=false)]
                public long? TotalCpuCore { get; set; }

                [NameInMap("TotalDiskGBSize")]
                [Validation(Required=false)]
                public long? TotalDiskGBSize { get; set; }

                [NameInMap("TotalMemGBSize")]
                [Validation(Required=false)]
                public long? TotalMemGBSize { get; set; }

                [NameInMap("UsedCpuCore")]
                [Validation(Required=false)]
                public long? UsedCpuCore { get; set; }

                [NameInMap("UsedDiskGBSize")]
                [Validation(Required=false)]
                public long? UsedDiskGBSize { get; set; }

                [NameInMap("UsedDu")]
                [Validation(Required=false)]
                public long? UsedDu { get; set; }

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
