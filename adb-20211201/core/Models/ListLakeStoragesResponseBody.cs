// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ListLakeStoragesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListLakeStoragesResponseBodyItems> Items { get; set; }
        public class ListLakeStoragesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>湖存储被创建的时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-04-01T09:50:18Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>创建湖存储的用户账号的唯一标识符</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("CreatorUid")]
            [Validation(Required=false)]
            public string CreatorUid { get; set; }

            /// <summary>
            /// <para>用于指定和挂载到特定ADB主实例的湖存储</para>
            /// 
            /// <b>Example:</b>
            /// <para>amv-*******</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>对湖存储的描述信息</para>
            /// 
            /// <b>Example:</b>
            /// <para>Create a role to run ROS StackGroups.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>651</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public string FileSize { get; set; }

            /// <summary>
            /// <para>用于识别特定湖存储的唯一标识符</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("LakeStorageId")]
            [Validation(Required=false)]
            public string LakeStorageId { get; set; }

            /// <summary>
            /// <para>最后操作湖存储的用户账号的唯一标识符</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("OperatorUid")]
            [Validation(Required=false)]
            public string OperatorUid { get; set; }

            /// <summary>
            /// <para>拥有湖存储资源的用户账号的唯一标识符</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("OwnerUid")]
            [Validation(Required=false)]
            public string OwnerUid { get; set; }

            /// <summary>
            /// <para>设置湖存储的读/写权限和账户级别权限的数组</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Permissions")]
            [Validation(Required=false)]
            public List<ListLakeStoragesResponseBodyItemsPermissions> Permissions { get; set; }
            public class ListLakeStoragesResponseBodyItemsPermissions : TeaModel {
                /// <summary>
                /// <para>具有该权限的账户或RAM用户ID</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Account")]
                [Validation(Required=false)]
                public string Account { get; set; }

                /// <summary>
                /// <para>表示是否允许读取湖存储的权限</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Read")]
                [Validation(Required=false)]
                public bool? Read { get; set; }

                /// <summary>
                /// <para>指定权限的账户类型</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>表示是否允许向湖存储写入数据的权限</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Write")]
                [Validation(Required=false)]
                public bool? Write { get; set; }

            }

            /// <summary>
            /// <para>指定要操作的湖存储所在区域的ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>湖存储中库表的总数量</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TableCount")]
            [Validation(Required=false)]
            public int? TableCount { get; set; }

            /// <summary>
            /// <para>湖存储中所有库表的总数据行数</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalRows")]
            [Validation(Required=false)]
            public long? TotalRows { get; set; }

            /// <summary>
            /// <para>湖存储中数据的总存储量</para>
            /// 
            /// <b>Example:</b>
            /// <para>111333</para>
            /// </summary>
            [NameInMap("TotalStorage")]
            [Validation(Required=false)]
            public string TotalStorage { get; set; }

            /// <summary>
            /// <para>湖存储最后一次更新的时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-15T02:24:32</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>-964D-</b></b>-9D31-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
