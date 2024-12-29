// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class UpdateLakeStorageRequest : TeaModel {
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
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        /// <para>设置湖存储的读/写权限和账户级别权限的数组</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<UpdateLakeStorageRequestPermissions> Permissions { get; set; }
        public class UpdateLakeStorageRequestPermissions : TeaModel {
            /// <summary>
            /// <para>具有该权限的账户或RAM用户ID</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// <para>表示是否允许读取湖存储的权限</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Read")]
            [Validation(Required=false)]
            public bool? Read { get; set; }

            /// <summary>
            /// <para>指定权限的账户类型</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUB</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>表示是否允许向湖存储写入数据的权限</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Write")]
            [Validation(Required=false)]
            public bool? Write { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
