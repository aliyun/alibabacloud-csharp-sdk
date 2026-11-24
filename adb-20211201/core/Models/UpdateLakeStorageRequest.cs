// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class UpdateLakeStorageRequest : TeaModel {
        /// <summary>
        /// <para>The ADB instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-*******</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The description of the lake storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The unique identifier of the lake storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adb-lake-cn-hangzhou-1a1aaaa11a</para>
        /// </summary>
        [NameInMap("LakeStorageId")]
        [Validation(Required=false)]
        public string LakeStorageId { get; set; }

        /// <summary>
        /// <para>The permissions of the lake storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Account&quot;:&quot;1234567890123456&quot;,&quot;Read&quot;:true,&quot;Type&quot;:&quot;User&quot;,&quot;Write&quot;:true}]</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<UpdateLakeStorageRequestPermissions> Permissions { get; set; }
        public class UpdateLakeStorageRequestPermissions : TeaModel {
            /// <summary>
            /// <para>The account ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890123456</para>
            /// </summary>
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// <para>The read permission.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Read")]
            [Validation(Required=false)]
            public bool? Read { get; set; }

            /// <summary>
            /// <para>The account type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The write permission.</para>
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
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
