// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeMem0InfoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeMem0InfoResponseBodyData Data { get; set; }
        public class DescribeMem0InfoResponseBodyData : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public DescribeMem0InfoResponseBodyDataInstance Instance { get; set; }
            public class DescribeMem0InfoResponseBodyDataInstance : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>mysql.x2.large.2c</para>
                /// </summary>
                [NameInMap("ClassCode")]
                [Validation(Required=false)]
                public string ClassCode { get; set; }

                [NameInMap("ConnAddrs")]
                [Validation(Required=false)]
                public List<DescribeMem0InfoResponseBodyDataInstanceConnAddrs> ConnAddrs { get; set; }
                public class DescribeMem0InfoResponseBodyDataInstanceConnAddrs : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>pxc-spsil01pww4hfz.polarx.singapore.rds.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("ConnectionString")]
                    [Validation(Required=false)]
                    public string ConnectionString { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3306</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>VPC</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>VPC ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-t4n4hf9xey7ea3lp4bwwx</para>
                    /// </summary>
                    [NameInMap("VPCId")]
                    [Validation(Required=false)]
                    public string VPCId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>vsw-t4ny14pr37spmjsbv5dc2</para>
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>pxc-spsil01pww4hfzjayd-cn-20251013180429</para>
                    /// </summary>
                    [NameInMap("VpcInstanceId")]
                    [Validation(Required=false)]
                    public string VpcInstanceId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-02-17T02:00:20Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pxc-spsil01pww4hfz-mem</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NodeCount")]
                [Validation(Required=false)]
                public int? NodeCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ap-southeast-1</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>local_ssd</para>
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// <para>VPC ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-t4n4hf9xey7ea3lp4bwwx</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-t4ny14pr37spmjsbv5dc2</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ap-southeast-1a</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C457B28E-9CAB-4B77-B5C6-5D71B7870B6E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
