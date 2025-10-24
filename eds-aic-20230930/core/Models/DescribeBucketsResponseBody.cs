// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeBucketsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeBucketsResponseBodyData> Data { get; set; }
        public class DescribeBucketsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>zydctest</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss-cn-hangzhou.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ExtranetEndpoint")]
            [Validation(Required=false)]
            public string ExtranetEndpoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-05-15 17:33:59</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss-cn-hangzhou-internal.aliyuncs.com</para>
            /// </summary>
            [NameInMap("IntranetEndpoint")]
            [Validation(Required=false)]
            public string IntranetEndpoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>center</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("OssObjectList")]
            [Validation(Required=false)]
            public List<DescribeBucketsResponseBodyDataOssObjectList> OssObjectList { get; set; }
            public class DescribeBucketsResponseBodyDataOssObjectList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>tf-testacceu-central-1ensbucketlifecycle44222</para>
                /// </summary>
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5B3C1A2E053D763E1B002CC607C5A0FE1****</para>
                /// </summary>
                [NameInMap("ETag")]
                [Validation(Required=false)]
                public string ETag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>con</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2012-02-24T08:42:32.000Z</para>
                /// </summary>
                [NameInMap("LastModified")]
                [Validation(Required=false)]
                public string LastModified { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public DescribeBucketsResponseBodyDataOssObjectListOwner Owner { get; set; }
                public class DescribeBucketsResponseBodyDataOssObjectListOwner : TeaModel {
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>395</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ongoing-request=&quot;true&quot;</para>
                /// </summary>
                [NameInMap("RestoreInfo")]
                [Validation(Required=false)]
                public string RestoreInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ARCHIVE</para>
                /// </summary>
                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>InstanceGroup</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>425F351C-3F8E-5218-A520-B6311D0D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
