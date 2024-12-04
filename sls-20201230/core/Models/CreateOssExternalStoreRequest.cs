// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateOssExternalStoreRequest : TeaModel {
        /// <summary>
        /// <para>The name of the external store.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_oss_store</para>
        /// </summary>
        [NameInMap("externalStoreName")]
        [Validation(Required=false)]
        public string ExternalStoreName { get; set; }

        /// <summary>
        /// <para>The parameters of the external store.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("parameter")]
        [Validation(Required=false)]
        public CreateOssExternalStoreRequestParameter Parameter { get; set; }
        public class CreateOssExternalStoreRequestParameter : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LTAI5tFsHGGeYry*****1Sz</para>
            /// </summary>
            [NameInMap("accessid")]
            [Validation(Required=false)]
            public string Accessid { get; set; }

            /// <summary>
            /// <para>The AccessKey secret.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GyviCLDVHkHrOztdkxuE6******Rp6</para>
            /// </summary>
            [NameInMap("accesskey")]
            [Validation(Required=false)]
            public string Accesskey { get; set; }

            /// <summary>
            /// <para>The name of the OSS bucket.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-bucket</para>
            /// </summary>
            [NameInMap("bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>The associated fields.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("columns")]
            [Validation(Required=false)]
            public List<CreateOssExternalStoreRequestParameterColumns> Columns { get; set; }
            public class CreateOssExternalStoreRequestParameterColumns : TeaModel {
                /// <summary>
                /// <para>The name of the field.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>auto-test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The data type of the field.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sls</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The OSS endpoint. For more information, see <a href="https://help.aliyun.com/document_detail/31837.html">Regions and endpoints</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-hangzhou.aliyuncs.com</para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The associated OSS objects. Valid values of n: 1 to 100.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("objects")]
            [Validation(Required=false)]
            public List<string> Objects { get; set; }

        }

        /// <summary>
        /// <para>The type of the external store. Set the value to oss.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("storeType")]
        [Validation(Required=false)]
        public string StoreType { get; set; }

    }

}
