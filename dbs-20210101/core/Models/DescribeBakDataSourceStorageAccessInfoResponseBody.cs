// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class DescribeBakDataSourceStorageAccessInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeBakDataSourceStorageAccessInfoResponseBodyData Data { get; set; }
        public class DescribeBakDataSourceStorageAccessInfoResponseBodyData : TeaModel {
            [NameInMap("OssAccessInfo")]
            [Validation(Required=false)]
            public DescribeBakDataSourceStorageAccessInfoResponseBodyDataOssAccessInfo OssAccessInfo { get; set; }
            public class DescribeBakDataSourceStorageAccessInfoResponseBodyDataOssAccessInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>TMP.3Kk6fNt7hhNmHrGYFkLe5WAo8qL18Hk2rKSZkDkZvrey1ksVAFgJ8Vty8isrBHaH5KUNYAwtcW8HUPzjjsNLo*******</para>
                /// </summary>
                [NameInMap("AccessKeyId")]
                [Validation(Required=false)]
                public string AccessKeyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6XzFspxx5wKjuJ2QwATkxnV7fcFxR*****</para>
                /// </summary>
                [NameInMap("AccessKeySecret")]
                [Validation(Required=false)]
                public string AccessKeySecret { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dbs-bakdata-test-cn-beijing-backup-oss-0-*****</para>
                /// </summary>
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-07-11T05:14:44Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>VN/2023/11/13/activity/20080101/activity-*****.tar</para>
                /// </summary>
                [NameInMap("ObjectKey")]
                [Validation(Required=false)]
                public string ObjectKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oss-cn-beijing.****.com</para>
                /// </summary>
                [NameInMap("OssEndpoint")]
                [Validation(Required=false)]
                public string OssEndpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oss-cn-beijing-****.aliyuncs.com</para>
                /// </summary>
                [NameInMap("OssInternalEndpoint")]
                [Validation(Required=false)]
                public string OssInternalEndpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("OssRegion")]
                [Validation(Required=false)]
                public string OssRegion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>554c0098-9858-4871-9c4c-33d9d*****</para>
                /// </summary>
                [NameInMap("SecurityToken")]
                [Validation(Required=false)]
                public string SecurityToken { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Request.Forbidden</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Have no Permissions</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D13761C3-9971-5C02-B789-3F3CD159****</para>
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
        public string Success { get; set; }

    }

}
