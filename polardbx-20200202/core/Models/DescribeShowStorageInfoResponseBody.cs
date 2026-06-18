// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeShowStorageInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code of the request. This parameter is empty when the request is successful. When the request fails, exception information such as an error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeShowStorageInfoResponseBodyData Data { get; set; }
        public class DescribeShowStorageInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of storage information.</para>
            /// </summary>
            [NameInMap("StorageInfos")]
            [Validation(Required=false)]
            public List<DescribeShowStorageInfoResponseBodyDataStorageInfos> StorageInfos { get; set; }
            public class DescribeShowStorageInfoResponseBodyDataStorageInfos : TeaModel {
                /// <summary>
                /// <para>The specification type (specification code) of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>polar.mysql.x4.large</para>
                /// </summary>
                [NameInMap("Class")]
                [Validation(Required=false)]
                public string Class { get; set; }

                /// <summary>
                /// <para>The number of databases.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("DbCount")]
                [Validation(Required=false)]
                public long? DbCount { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance can be deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("Deletable")]
                [Validation(Required=false)]
                public bool? Deletable { get; set; }

                /// <summary>
                /// <para>The number of node groups.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("GroupCount")]
                [Validation(Required=false)]
                public long? GroupCount { get; set; }

                /// <summary>
                /// <para>The role type of the instance. Valid values:
                /// MASTER: primary instance.
                /// READONLY: read-only instance.
                /// STANDBY: standby instance (high-availability scenario).</para>
                /// 
                /// <b>Example:</b>
                /// <para>MASTER</para>
                /// </summary>
                [NameInMap("InstKind")]
                [Validation(Required=false)]
                public string InstKind { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance or cluster is currently in a healthy state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsHealthy")]
                [Validation(Required=false)]
                public bool? IsHealthy { get; set; }

                /// <summary>
                /// <para>The identifier of the leader node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11.117.237.205:3029</para>
                /// </summary>
                [NameInMap("LeaderNode")]
                [Validation(Required=false)]
                public string LeaderNode { get; set; }

                /// <summary>
                /// <para>The instance status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxc-xdb-m-pxcbjrylg49skcxb17394</para>
                /// </summary>
                [NameInMap("StorageInstName")]
                [Validation(Required=false)]
                public string StorageInstName { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C458B1E8-1683-3645-B154-6BA32080EEA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
