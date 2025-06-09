// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class ListAppsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2C5DAA30-****-5181-9B87-9D6181016197</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListAppsResponseBodyResult> Result { get; set; }
        public class ListAppsResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test-abc</para>
            /// </summary>
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>代表资源名称的资源属性字段</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-severless-test-app</para>
            /// </summary>
            [NameInMap("appName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("appType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <para>代表创建时间的资源属性字段</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-27T07:09:11.000Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>应用备注</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-12-27T07:09:11.000Z</para>
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>OwnerID账号ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>*********7595</para>
            /// </summary>
            [NameInMap("ownerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>代表region的资源属性字段</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>代表资源状态的资源属性字段</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListAppsResponseBodyResultTags> Tags { get; set; }
            public class ListAppsResponseBodyResultTags : TeaModel {
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7.10</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
